﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoserviceCore;

namespace AutoserviceUI.Presenters
{
    class SearchAutoFormPresenter
    {
        private readonly ISearchAutoView _view;
        private readonly IMessageService _messageService;
        private readonly ISearchAuto _searchManager;

        public SearchAutoFormPresenter(ISearchAutoView view, IMessageService messageService, ISearchAuto searchManager)
        {
            _view = view;
            _messageService = messageService;
            _searchManager = searchManager;

            _view.UpdateDataGridSearch += _view_UpdateDataGridSearch;

        }

        void _view_UpdateDataGridSearch(object sender, EventArgs e)
        {
            switch (_view.Searchtypename)
            {
                case "NumberAuto":
                    _view.UpdateDataGrid(_searchManager.SelectAutoByNumberAuto(_view.Searchvalue));
                    break;
                case "LastName":
                    _view.UpdateDataGrid(_searchManager.SelectAutoByLastName(_view.Searchvalue));
                    break;
                case "PassportName":
                    _view.UpdateDataGrid(_searchManager.SelectAutoByNumberPassport(_view.Searchvalue));
                    break;
            }
        }
    }
}