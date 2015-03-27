using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoserviceCore;
using System.Windows.Forms;

namespace AutoserviceUI.Presenters
{
    class TypeModelFormPresenter
    {
        private readonly View.ITypeModelInterface _view;
        private readonly MessageService _messageService;
        private readonly ITypeModel _manageTypeModel;

        public TypeModelFormPresenter(View.ITypeModelInterface view, MessageService service, ITypeModel manageTypeModel)
        {
            _view = view;
            _messageService = service;
            _manageTypeModel = manageTypeModel;

            _view.butCancelTypeModelClick += _view_butCancelTypeModelEventClick;
            _view.butDeleteTypeModelClick += _view_butDeleteTypeModelClick;
            _view.butInsertTypeModelClick += _view_butInsertTypeModelClick;
            _view.dataGridLoad += _view_dataGridLoad;
        }
        private void UpdateTypeModelGrid()
        {
            _view.UpdateTypeModel(_manageTypeModel.GetAllTypeModel());
        }
        void _view_dataGridLoad(object sender, EventArgs e)
        {
            UpdateTypeModelGrid();
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
                UpdateTypeModelGrid();
            }
        }

        void _view_butDeleteTypeModelClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void _view_butCancelTypeModelEventClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        } 
    }
}
