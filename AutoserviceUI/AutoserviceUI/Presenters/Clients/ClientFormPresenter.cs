using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using AutoserviceCore;using System.Windows.Forms;namespace AutoserviceUI.Presenters{    class ClientFormPresenter    {
        private readonly IClient _manageClient;
        private readonly IMessageService _messageService;
        private readonly View.IClientInterface _view;        public ClientFormPresenter(View.IClientInterface view, IMessageService messageService, IClient manageClient)        {            _view = view;            _messageService = messageService;            _manageClient = manageClient;            _view.ButCancelClickEvent += _view_ButCancelClickEvent;            _view.ButDeleteClickEvent += _view_ButDeleteClickEvent;            _view.ButInsertClickEvent += _view_ButInsertClickEvent;            _view.DataGridClientsUpdateEvent += _view_DataGridClientsUpdateEvent;        }

        void _view_ButCancelClickEvent(object sender, EventArgs e)
        {
            _view.CloseForm();
        }

        void _view_ButDeleteClickEvent(object sender, EventArgs e)
        {
            if (_view.LastName == "" || _view.FirstName == "" || _view.FathName == "" || _view.Passport == "")
            {
                _messageService.ShowMessage("Пожалуйста, выберите клиента которого хотите удалить!");
                return;
            }
            DialogResult result = _messageService.ConfimDeleteClient(_view.LastName, _view.FathName, _view.FathName);
            if (result == DialogResult.Yes)
            {
                _manageClient.DeleteClient(_view.LastName, _view.FirstName, _view.FathName, _view.Passport);
                _messageService.ShowMessage(string.Format("Клиент {0} {1} {2} удален!", _view.LastName, _view.FathName, _view.FathName));
                _view.ClearForm();
                UpdateGrid();
            }
        }

        void _view_ButInsertClickEvent(object sender, EventArgs e)
        {
            if (_view.LastName == "" || _view.FirstName == "" || _view.FathName == "" || _view.Passport == "" || _view.Address == "" || _view.Phone == "")
            {
                _messageService.ShowError("Поля не могут быть пустыми?");
                return;
            }
            if (_manageClient.InsertClient(_view.LastName, _view.FirstName, _view.FathName, _view.Passport, _view.Address, _view.Phone) == true)
            {
                _messageService.ShowMessage("Клиент добавлен!");
                _view.ClearForm();
                UpdateGrid();
            }

        }

        void _view_DataGridClientsUpdateEvent(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()        {            _view.DataGridDataTable(_manageClient.GetAllClients());        }    }}
