using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoserviceCore;

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
        }

        void _view_UpdateWorkEvent(object sender, EventArgs e)
        {
            _view.UpdateCmbWork(_managerOrder.GetWorksList(0));    
        }

        void _view_UpdateWorkCategoryEvent(object sender, EventArgs e)
        {
            _view.UpdateCmbWorkCategory(_managerOrder.GetWorksCategory());
        }

        void _view_UpdateDataGridWorksEvent(object sender, EventArgs e)
        {
            _view.GetOrderWorksData(_managerOrder.GetOrderData());
        }
    }
}
