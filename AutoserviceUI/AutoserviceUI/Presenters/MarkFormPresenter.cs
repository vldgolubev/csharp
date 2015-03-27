using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoserviceCore;

namespace AutoserviceUI.Presenters
{
    class MarkFormPresenter
    {
        private readonly View.IMarkInterface _view;
        private readonly MessageService _messageService;
        private readonly IMarkInterface _manageMark;

        public MarkFormPresenter(View.IMarkInterface view, MessageService service, IMarkInterface manageMark)
        {
            _view = view;
            _messageService = service;
            _manageMark = manageMark;

            _view.DataGridMarkUpdate += _view_DataGridMarkUpdate;
            _view.butCancelMarkClick += _view_butCancelMarkClick;
            _view.butDeleteMarkClick += _view_butDeleteMarkClick;
            _view.butInsertMarkClick += _view_butInsertMarkClick;
        }

        void _view_DataGridMarkUpdate(object sender, EventArgs e)
        {
            _view.UpdateMark(_manageMark.GetAllMarks());
        }
        private void MarksDataGridUpdate()
        {
            _view.UpdateMark(_manageMark.GetAllMarks());
        }
        void _view_butInsertMarkClick(object sender, EventArgs e)
        {
            if (_view.MarkName == "" || _view.Country == "")
            {
                _messageService.ShowError("Поля не могут быть пустыми!");
                return;
            }
            if (_manageMark.InsertMark(_view.MarkName, _view.Country) == true)
            {
                _messageService.ShowMessage("Марка добавлена!");
                _view.DataClear();
                MarksDataGridUpdate();
            }
            else { 
                _messageService.ShowExclamation("Такая марка уже существует!");
                _view.DataClear();
            }
        }

        void _view_butDeleteMarkClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void _view_butCancelMarkClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
