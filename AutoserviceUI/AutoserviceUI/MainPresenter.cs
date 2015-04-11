using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoserviceCore;
using AutoserviceUI.Presenters;
using System.Windows.Forms;

namespace AutoserviceUI
    /* Контроллер главной формы*/
{   class MainPresenter
    {
        private readonly IMainInterface _mainManager;
        private readonly IMessageService _messageService;
        private readonly IMainForm _view;
        public MainPresenter(IMainForm view, IMessageService messageService,IMainInterface mainManager)
        {
            _view = view;
            _messageService = messageService;
            _mainManager = mainManager;
            _view.AdminFormClick += _view_AdminFormClick;
            _view.MarksFormClick += _view_MarksFormClick;
            _view.ModelsFormClick += _view_ModelsFormClick;
            _view.TypesFormClick += _view_TypesFormClick;
            _view.WorksTypeFormClick += _view_WorksTypeFormClick;
            _view.WorksFormClick += _view_WorksFormClick;
            _view.WorkersFormClick += _view_WorkersFormClick;
            _view.ClientFormClick += _view_ClientFormClick;
            _view.AutoClientFormClick += _view_AutoClientFormClick;
            _view.OrdersFormClick += _view_OrdersFormClick;
            _view.LoadMainFromEvent += _view_LoadMainFromEvent;
            _view.UpdateCmbWorkerEvent += _view_UpdateCmbWorkerEvent;
            _view.ChoiceAutoSearch += _view_ChoiceAutoSearch;
            _view.UpdateDataGridEvent += _view_UpdateDataGrid;
            _view.InsertOrderEvent += _view_InsertOrderEvent;
            _view.DeleteOrderEvent += _view_DeleteOrderEvent;
            _view.ButUpdateClickEvent += _view_ButUpdateClickEvent;
            _view.ButSerchWorkerLastNameEvent += _view_ButSerchWorkerLastNameEvent;
            _view.ButSearchMarkAutoEvent += _view_ButSearchMarkAutoEvent;
            _view.ButSerchOwnerLastNameEvent += _view_ButSerchOwnerLastNameEvent;
            _view.ButSerchNumberAutoEvent += _view_ButSerchNumberAutoEvent;
            _view.ButSearchCompleteEvent += _view_ButSearchCompleteEvent;
            _view.ButSearchUnCompleteEvent += _view_ButSearchUnCompleteEvent;
        }



        void _view_AdminFormClick(object sender, EventArgs e)
        {
            View.AdminFormView form = new View.AdminFormView();
            MessageService service = new MessageService();
            Admin adminLogic = new Admin();
            Presenters.AdminFormPresenter presenter = new Presenters.AdminFormPresenter(form, service, adminLogic);
            form.ShowDialog();

        }

        void _view_AutoClientFormClick(object sender, EventArgs e)
        {
            View.CarsFormView form = new View.CarsFormView();
            MessageService service = new MessageService();
            Cars carsLogic = new Cars();
            Presenters.CarsFormPresenter presenter = new Presenters.CarsFormPresenter(form, service, carsLogic);
            form.ShowDialog();
        }

        void _view_ButSearchCompleteEvent(object sender, EventArgs e)
        {
            _view.UpdateDataGrid(_mainManager.GetAllCompleteOrders());
        }

        void _view_ButSearchMarkAutoEvent(object sender, EventArgs e)
        {
            _view.UpdateDataGrid(_mainManager.GetAllOrdersByMarkAuto(_view.TxtSearchByMarkAuto));
        }

        void _view_ButSearchUnCompleteEvent(object sender, EventArgs e)
        {
            _view.UpdateDataGrid(_mainManager.GetAllUnCompleteOrders());
        }
        void _view_ButSerchNumberAutoEvent(object sender, EventArgs e)
        {
            _view.UpdateDataGrid(_mainManager.GetAllOrdersByCarNumber(_view.TxtSearchByNumberAuto));
        }

        void _view_ButSerchOwnerLastNameEvent(object sender, EventArgs e)
        {
            _view.UpdateDataGrid(_mainManager.GetAllOrdersByOwner(_view.TxtSearchByOwnerLastName));
        }
        void _view_ButSerchWorkerLastNameEvent(object sender, EventArgs e)
        {
            _view.UpdateDataGrid(_mainManager.GetAllOrdersByWorker(_view.TxtSearchByWorkerLastName));
        }

        void _view_ButUpdateClickEvent(object sender, EventArgs e)
        {
            if (_view.SelectedOrderID.ToString() == "")
            {
                MessageBox.Show("Пожалуйста, выберете заказ, который хотите Обновить!");
                return;
            }
            _mainManager.CompleteOrder(Convert.ToInt32(_view.SelectedOrderID),_view.DateTimeComplete);
            _messageService.ShowMessage("Заказ успешно обновлен!");
            _view.UpdateDataGrid(_mainManager.GetAllOrders());
        }

        void _view_ChoiceAutoSearch(object sender, EventArgs e)
        {
            if (_view.RadioNumberChecked == true)
            {
                if (_view.Search != "")
                {
                    SearchAutoView form = new SearchAutoView("NumberAuto", _view.Search);
                    MessageService messageService = new MessageService();
                    SearchAuto manageSerch = new SearchAuto();
                    SearchAutoFormPresenter presenter = new SearchAutoFormPresenter(form, messageService, manageSerch);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _view.SerchValue = form.AutoSelectedID.ToString();
                        _view.SelectedAuto = form.Selectedautoname;
                        _view.UpdateDataGrid(_mainManager.GetAllOrders());

                    }
                }
            }

            if (_view.RadioLastNameChecked == true)
            {
                if (_view.Search != "")
                {
                    SearchAutoView form = new SearchAutoView("LastName", _view.Search);
                    MessageService messageService = new MessageService();
                    SearchAuto manageSerch = new SearchAuto();
                    SearchAutoFormPresenter presenter = new SearchAutoFormPresenter(form, messageService, manageSerch);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _view.SerchValue = form.AutoSelectedID.ToString();
                        _view.SelectedAuto = form.Selectedautoname;
                        _view.UpdateDataGrid(_mainManager.GetAllOrders());
                    }
                }
            }
            if (_view.RadioPassportNumberChecked == true)
            {
                if (_view.Search != "")
                {
                    SearchAutoView form = new SearchAutoView("PassportName", _view.Search);
                    MessageService messageService = new MessageService();
                    SearchAuto manageSerch = new SearchAuto();
                    SearchAutoFormPresenter presenter = new SearchAutoFormPresenter(form, messageService, manageSerch);
                    if (form.ShowDialog() == DialogResult.OK)
                    {


                        _view.SerchValue = form.AutoSelectedID.ToString();
                        _view.SelectedAuto = form.Selectedautoname;
                        _view.UpdateDataGrid(_mainManager.GetAllOrders());


                    }
                }
            }
        }

        /// <summary>
        /// Событие вызова формы View.Clients.ClientFormView
        /// </summary>
        void _view_ClientFormClick(object sender, EventArgs e)
        {
            View.ClientFormView form = new View.ClientFormView();
            MessageService service = new MessageService();
            Client clientLogic = new Client();
            Presenters.ClientFormPresenter presenter = new Presenters.ClientFormPresenter(form, service, clientLogic);
            form.ShowDialog();
        }

        void _view_DeleteOrderEvent(object sender, EventArgs e)
        {
            if (_view.SelectedOrderID.ToString() == "")
            {
                MessageBox.Show("Пожалуйста, выберете заказ, который хотите удалить!");
                return;
            }
            _mainManager.DeleteOrder(Convert.ToInt32(_view.SelectedOrderID));
            _view.UpdateDataGrid(_mainManager.GetAllOrders());
        }

        void _view_InsertOrderEvent(object sender, EventArgs e)
        {
            if (_view.SelectedAuto == "")
            {
                MessageBox.Show("Пожалуйста, выберете автомобиль!");
                return;
            }
            _mainManager.InsertOrder(_view.GetWorkerID,_view.GetAutoID);
            _messageService.ShowMessage("Автомобиль добавлен!");
            _view.UpdateDataGrid(_mainManager.GetAllOrders());

        }

        void _view_LoadMainFromEvent(object sender, EventArgs e)
        {
            _view.UncompleteOrdersCount(_mainManager.CountUncompleteOrders());
        }

        void _view_MarksFormClick(object sender, EventArgs e)
        {
            View.MarkFormView form = new View.MarkFormView();
            MessageService service = new MessageService();
            Mark markLogic = new Mark();
            Presenters.MarkFormPresenter presenter = new Presenters.MarkFormPresenter(form, service, markLogic);
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

        void _view_OrdersFormClick(object sender, EventArgs e)
        {
            View.OrderWorksFormView form = new View.OrderWorksFormView();
            MessageService service = new MessageService();
            OrderWorks orderManage = new OrderWorks();
            Presenters.OrderWorksFormPresenter presenter = new Presenters.OrderWorksFormPresenter(form, service, orderManage);
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

        void _view_UpdateCmbWorkerEvent(object sender, EventArgs e)
        {
            _view.UpdateCmbWorker(_mainManager.WorkersList());
        }

        void _view_UpdateDataGrid(object sender, EventArgs e)
        {
            _view.UpdateDataGrid(_mainManager.GetAllOrders());
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
    }
}
