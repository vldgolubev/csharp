using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using AutoserviceCore;using System.Windows.Forms;/* Контроллер формы рабочии*/namespace AutoserviceUI.Presenters{    class WorkersFormPresenter    {
        private readonly MessageService _messageService;
        private readonly View.IWorkersInterface _view;        private readonly IWorkersInterface _workersManager;        public WorkersFormPresenter(View.IWorkersInterface view, MessageService messageService, IWorkersInterface workersManager)        {            _view = view;            _messageService = messageService;            _workersManager = workersManager;            _view.DataGridWorkersUpdateEvent += _view_DataGridWorkersUpdateEvent;            _view.ButCancelClickEvent += _view_ButCancelClickEvent;            _view.ButInsertClickEvent += _view_ButInsertClickEvent;            _view.ButDeleteClickEvent += _view_ButDeleteClickEvent;                    }

        void _view_ButCancelClickEvent(object sender, EventArgs e)
        {
            _view.CloseForm();
        }

        void _view_ButDeleteClickEvent(object sender, EventArgs e)        {            if (_view.LastName == "" || _view.FirstName == "" || _view.PathName == "" || _view.Passport == "")            {                _messageService.ShowMessage("Пожалуйста, выберите рабочего которого хотите удалить!");                return;            }            DialogResult result = _messageService.ConfimDeleteWorker(_view.LastName,_view.FirstName,_view.PathName);            if(result == DialogResult.Yes)            {                _workersManager.DeleteWorker(_view.LastName,_view.FirstName,_view.PathName,_view.Passport);                _messageService.ShowMessage(string.Format("Рабочий {0} {1} {2} удален!", _view.LastName,_view.FirstName,_view.PathName));                _view.ClearForm();                UpdateGrid();            }        }        void _view_ButInsertClickEvent(object sender, EventArgs e)        {            if (_view.LastName == "" || _view.FirstName == "" || _view.PathName == "" || _view.Passport == "" || _view.Address == "" || _view.Phone == "")            {                _messageService.ShowError("Поля не могут быть пустыми!");                return;            }            if (_workersManager.InsertWorker(_view.LastName, _view.FirstName, _view.PathName, _view.Passport, _view.Address, _view.Phone) == true)            {                _messageService.ShowMessage(string.Format("Рабочий {0} {1} {2} успешно добавлен!", _view.LastName, _view.FirstName, _view.PathName));                _view.ClearForm();                UpdateGrid();            }        }
        void _view_DataGridWorkersUpdateEvent(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()        {            _view.DataGridDataTable(_workersManager.GetAllWorkers());        }    }}
