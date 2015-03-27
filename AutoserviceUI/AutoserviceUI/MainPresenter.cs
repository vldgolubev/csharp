using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoserviceCore;

namespace AutoserviceUI
{
    class MainPresenter
    {
        private readonly IMainForm _view;
        private readonly IMessageService _messageService;

        public MainPresenter(IMainForm view, IMessageService messageService)
        {
            _view = view;
            _messageService = messageService;

            _view.AdminFormClick += _view_AdminFormClick;
            _view.MarksFormClick += _view_MarksFormClick;
            _view.ModelsFormClick += _view_ModelsFormClick;
            _view.TypesFormClick += _view_TypesFormClick;
        }

        void _view_TypesFormClick(object sender, EventArgs e)
        {
            View.TypeModelForm form = new View.TypeModelForm();
            MessageService service = new MessageService();
            TypeModel typeModelLogic = new TypeModel();
            Presenters.TypeModelFormPresenter presenter = new Presenters.TypeModelFormPresenter(form, service, typeModelLogic);
            form.ShowDialog();
        }

        void _view_ModelsFormClick(object sender, EventArgs e)
        {
            //
        }

        void _view_MarksFormClick(object sender, EventArgs e)
        {
            View.MarkForm form = new View.MarkForm();
            MessageService service = new MessageService();
            Mark markLogic = new Mark();
            Presenters.MarkFormPresenter presenter = new Presenters.MarkFormPresenter(form, service, markLogic);
            form.ShowDialog();
        }

        void _view_AdminFormClick(object sender, EventArgs e)
        {
            View.AdminForm form = new View.AdminForm();
            MessageService service = new MessageService();
            Admin adminLogic = new Admin();
            Presenters.AdminFormPresenter presenter = new Presenters.AdminFormPresenter(form, service, adminLogic);
            form.ShowDialog(); 

        }
    }
}
