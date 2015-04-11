using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using AutoserviceCore;using System.Windows.Forms;namespace AutoserviceUI.Presenters{    class TypeModelFormPresenter    {
        private readonly ITypeModel _manageTypeModel;
        private readonly MessageService _messageService;
        private readonly View.ITypeModelInterface _view;        public TypeModelFormPresenter(View.ITypeModelInterface view, MessageService service, ITypeModel manageTypeModel)        {            _view = view;            _messageService = service;            _manageTypeModel = manageTypeModel;            _view.butCancelTypeModelClick += _view_butCancelTypeModelClick;            _view.butDeleteTypeModelClick += _view_butDeleteTypeModelClick;            _view.butInsertTypeModelClick += _view_butInsertTypeModelClick;            _view.dataGridLoad += _view_dataGridLoad;        }        void _view_butCancelTypeModelClick(object sender, EventArgs e)        {            _view.TypeModelFormClose();        }
        void _view_butDeleteTypeModelClick(object sender, EventArgs e)
        {
            if (_view.TypeModelName == "" || _view.TypeModelID == "")
            {
                _messageService.ShowMessage("Пожалуйста, выберите модель!");
                return;
            }
            DialogResult result = _messageService.ConfimDeleteTypeModel(_view.TypeModelName);
            if (result == DialogResult.Yes)
            {
                _manageTypeModel.DeleteTypeModel(_view.TypeModelID, _view.TypeModelName);
                _messageService.ShowMessage(string.Format("Тип кузова с названием {0} удалена!", _view.TypeModelName));
                _view.TypeModelID = ""; _view.TypeModelName = "";
                UpdateTypeModelGrid();
            }
        }

        void _view_butInsertTypeModelClick(object sender, EventArgs e)
        {
            if (_view.TypeModelName == "")
            {
                _messageService.ShowError("Поле 'Тип' не может быть пустым!");
                return;
            }
            if (_manageTypeModel.InsertTypeModel(_view.TypeModelName) == true)
            {
                _messageService.ShowMessage("Новый тип кузова, добавлен!");
                _view.TypeModelName = "";
                UpdateTypeModelGrid();
            }
            else _messageService.ShowExclamation("Такой тип уже существует!");
        }

        void _view_dataGridLoad(object sender, EventArgs e)
        {
            UpdateTypeModelGrid();
        }

        private void UpdateTypeModelGrid()        {            _view.UpdateTypeModel(_manageTypeModel.GetAllTypeModel());        }    }}
