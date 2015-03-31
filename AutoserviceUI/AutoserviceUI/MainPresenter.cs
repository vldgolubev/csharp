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
            _view.WorksTypeFormClick += _view_WorksTypeFormClick;
            _view.WorksFormClick += _view_WorksFormClick;
            _view.WorkersFormClick += _view_WorkersFormClick;
        }

        void _view_WorkersFormClick(object sender, EventArgs e)
        {
            View.WorkersFormView form = new View.WorkersFormView();
            MessageService service = new MessageService();
            Workers workersLogic = new Workers();
            Presenters.WorkersFormPresenter presenter = new Presenters.WorkersFormPresenter(form, service, workersLogic);
            form.ShowDialog();
        }

        void _view_WorksFormClick(object sender, EventArgs e)
        {
            View.WorksFormView form = new View.WorksFormView();
            MessageService service = new MessageService();
            Works worksLogic = new Works();
            Presenters.WorksFormPresenter presenter = new Presenters.WorksFormPresenter(form, service, worksLogic);
            form.ShowDialog();
        }

        void _view_WorksTypeFormClick(object sender, EventArgs e)
        {
            View.WorkCategoryFormView form = new View.WorkCategoryFormView();
            MessageService service = new MessageService();
            WorksCategory worksCategoryLogic = new WorksCategory();
            Presenters.WorkCategoryFormPresenter presenter = new Presenters.WorkCategoryFormPresenter(form, service, worksCategoryLogic);
            form.ShowDialog();
        }

        void _view_TypesFormClick(object sender, EventArgs e)
        {
            View.TypeModelFormView form = new View.TypeModelFormView();
            MessageService service = new MessageService();
            TypeModel typeModelLogic = new TypeModel();
            Presenters.TypeModelFormPresenter presenter = new Presenters.TypeModelFormPresenter(form, service, typeModelLogic);
            form.ShowDialog();
        }

        void _view_ModelsFormClick(object sender, EventArgs e)
        {
            View.ModelFormView form = new View.ModelFormView();
            MessageService service = new MessageService();
            Model ModelLogic = new Model();
            Presenters.ModelFormPresenter presenter = new Presenters.ModelFormPresenter(form, service, ModelLogic);
            form.ShowDialog();

        }

        void _view_MarksFormClick(object sender, EventArgs e)
        {
            View.MarkFormView form = new View.MarkFormView();
            MessageService service = new MessageService();
            Mark markLogic = new Mark();
            Presenters.MarkFormPresenter presenter = new Presenters.MarkFormPresenter(form, service, markLogic);
            form.ShowDialog();
        }

        void _view_AdminFormClick(object sender, EventArgs e)
        {
            View.AdminFormView form = new View.AdminFormView();
            MessageService service = new MessageService();
            Admin adminLogic = new Admin();
            Presenters.AdminFormPresenter presenter = new Presenters.AdminFormPresenter(form, service, adminLogic);
            form.ShowDialog(); 

        }
    }
}
