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

            _view.butCancelMarkClick += _view_butCancelMarkClick;
            _view.butDeleteMarkClick += _view_butDeleteMarkClick;
            _view.butInsertMarkClick += _view_butInsertMarkClick;
        }

        void _view_butInsertMarkClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
