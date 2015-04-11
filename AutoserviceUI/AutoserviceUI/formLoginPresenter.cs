using AutoserviceCore;
using AutoserviceUI.View;
using System;
using System.Windows.Forms;
/* Контроллер формы авторизации*/
namespace AutoserviceUI
{
    public class formLoginPresenter
    {
        private readonly IAdminInterface _manageLogin;
        private readonly IMessageService _messageService;
        private readonly ILoginInterface _view;
        public formLoginPresenter(ILoginInterface view, IMessageService messageService, IAdminInterface manageLogin)
        {
            _view = view;
            _messageService = messageService;
            _manageLogin = manageLogin;

            _view.ButCancelClick += _view_ButCancelClick;
            _view.ButLoginClick += _view_ButLoginClick;
        }
        private void _view_ButCancelClick(object sender, EventArgs e)
        {
            if (_messageService.ConfimApplicationExit() == DialogResult.Yes)
                _view.ApplicationExit();
            return;
        }
        private void _view_ButLoginClick(object sender, EventArgs e)
        {
            if (_view.Login == "" || _view.Password == "")
            {
                _messageService.ShowExclamation("Поля Логин и Пароль не могут быть пустыми!");
                return;
            }
            if (_manageLogin.AutorizationCheck(_view.Login, _view.Password) == true)
            {
                _view.RunMain();
            }
            else
            {
                _messageService.ShowError("Ошибка авторизации, проверьте правильность комбинации логин/пароль");
                return;
            }
        }
    }
}