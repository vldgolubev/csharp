using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoserviceCore;
using System.Windows.Forms;

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
            _view.DataGridAdminUpdate+=_view_DataGridAdminUpdate;
            _view.InsertAdminClick += _view_InsertAdminClick;
            _view.CancelAdminClick += _view_CancelAdminClick;
            _view.DeleteAdminClick += _view_DeleteAdminClick;
           
        }

        void _view_DeleteAdminClick(object sender, EventArgs e)
        {
            if (_view.Login == "" || _view.AdminID == ""  )
            {
                _messageService.ShowMessage("Пожалуйста, выберите пользователя!");
                return;
            }
            DialogResult result = _messageService.ConfirmDeleteMessageAdmin(_view.Login);
            if (result == DialogResult.Yes)
            {
                _manageAdmin.DeleteAdmin(_view.AdminID, _view.Login);
                _messageService.ShowMessage(string.Format("Пользователь с именем {0} удален!", _view.Login));
                _view.AdminID = ""; _view.Login = "";
                AdminDataGridUpdate();
            }
        }


        private void AdminDataGridUpdate()
        {
            _view.UpdateAdmin(_manageAdmin.GetAllAdmins());
        }

        void _view_DataGridAdminUpdate(object sender, EventArgs e)
        {
            AdminDataGridUpdate();
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
                _view.Login = ""; _view.Password = ""; _view.AdminID = "";
                AdminDataGridUpdate();
            }
            else _messageService.ShowExclamation("Такой пользователь уже сущетсвует!");
            
        }
    }
}
