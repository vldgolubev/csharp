using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoserviceCore;

namespace AutoserviceUI.Presenters
{
    class AdminFormPresenter
    {
        private readonly View.IAdminForm _view;
        private readonly MessageService _messageService;
        private readonly IAdminInterface _manageAdmin;

        public AdminFormPresenter(View.IAdminForm view, MessageService service, IAdminInterface manageAdmin)
        {
            _view = view;
            _messageService = service;
            _manageAdmin = manageAdmin;

            _view.InsertAdminClick += _view_InsertAdminClick;
            _view.CancelAdminClick += _view_CancelAdminClick;
           
        }

        void _view_CancelAdminClick(object sender, EventArgs e)
        {
            _view.CloseForm();
        }

        void _view_InsertAdminClick(object sender, EventArgs e)
        {
            if (_view.Login == "" || _view.Password == "")
            {
                _messageService.ShowError("Поля не могут быть пустыми!");
                return;
            }

            if (_manageAdmin.InsertAdmin(_view.Login, _view.Password) == true)
            {
                _messageService.ShowMessage("Пользователь добавлен!");
                _manageAdmin.SelectAdmins(_view.DataAdminGrid);
            }
            else _messageService.ShowExclamation("Такой пользователь уже сущетсвует!");
            
        }
    }
}
