using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoserviceCore;
using System.Windows.Forms;

namespace AutoserviceUI.Presenters
{
    public class OrderWorksFormPresenter
    {
        private readonly View.IOrderWorksInterface _view;
        private readonly IMessageService _messageService;
        private readonly IOrderWorksManager _managerOrder;
        public OrderWorksFormPresenter(View.IOrderWorksInterface view, IMessageService messageService, IOrderWorksManager managerOrder)
        {
            _view = view;
            _messageService = messageService;
            _managerOrder = managerOrder;

            _view.UpdateDataGridWorksEvent += _view_UpdateDataGridWorksEvent;
            _view.UpdateWorkCategoryEvent += _view_UpdateWorkCategoryEvent;
            _view.UpdateWorkEvent += _view_UpdateWorkEvent;
            _view.UpdateComboOrdersEvent +=_view_UpdateComboOrdersEvent;
            _view.ButSelectWorksByID += _view_ButSelectWorksByID;
            _view.ButInsertClick += _view_ButInsertClick;
            _view.ButDeleteClick += _view_ButDeleteClick;
            _view.ButCancelClick += _view_ButCancelClick;
            _view.UpdateOrderSum += _view_UpdateOrderSum;
         
        }

        void _view_UpdateOrderSum(object sender, EventArgs e)
        {
            _managerOrder.UpdateOrderSum(_view.GetOrderSelectedID(),_view.OrderSum);
        }


        void _view_ButCancelClick(object sender, EventArgs e)
        {
            _view.CloseForm();
        }

        void _view_ButDeleteClick(object sender, EventArgs e)
        {
            if(_view.OrderID == ""){ _messageService.ShowMessage("Пожалуйста, выберите работу которую хотите удалить!");
            return;}
            if(_messageService.ConfimDeleteWork() == DialogResult.Yes)
            if (_managerOrder.DeleteWorkByID(Convert.ToInt32(_view.OrderID)) == true)
            {
                _messageService.ShowMessage("Работа удалена!");
                _view.GetOrderWorksData(_managerOrder.GetOrderDataByID(_view.GetOrderSelectedID()));
                _view.Clear();

            }
        }

        void _view_ButInsertClick(object sender, EventArgs e)
        {
            if (_managerOrder.IsNotExistWork(_view.GetOrderSelectedID(), _view.GetWorkSelectedID()) == true)
                _messageService.ShowMessage("Такая рабта уже существует!");
            else
            {
                _managerOrder.InsertWork(_view.GetOrderSelectedID(), _view.GetWorkSelectedID());
                _messageService.ShowMessage("Работа успешно добавлена!");
                _view.GetOrderWorksData(_managerOrder.GetOrderDataByID(_view.GetOrderSelectedID()));
            }
        }

        void _view_ButSelectWorksByID(object sender, EventArgs e)
        {
            _view.GetOrderWorksData(_managerOrder.GetOrderDataByID(_view.GetOrderSelectedID()));
        }
        /* Обновление combobox с заказами */
        void _view_UpdateComboOrdersEvent(object sender, EventArgs e)
        {
            _view.UpdateCmbOrder(_managerOrder.GetOrdersList());
        }
        /* Обновление combobox с Работами*/
        void _view_UpdateWorkEvent(object sender, EventArgs e)
        {
            _view.UpdateCmbWork(_managerOrder.GetWorksList(_view.WorkCategorySelected));
        }
        /* Обновление combobox с категориями работ */
        void _view_UpdateWorkCategoryEvent(object sender, EventArgs e)
        {
            _view.UpdateCmbWorkCategory(_managerOrder.GetWorksCategory());
            
        }
        /* Обновление таблицы с работами */
        void _view_UpdateDataGridWorksEvent(object sender, EventArgs e)
        {
            _view.GetOrderWorksData(_managerOrder.GetOrderData());
        }
    }
}
