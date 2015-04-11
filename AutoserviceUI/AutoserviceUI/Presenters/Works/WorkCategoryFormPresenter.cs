using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using AutoserviceCore;using System.Windows.Forms;namespace AutoserviceUI.Presenters{/* Контроллер формы Категории работ */    class WorkCategoryFormPresenter    {
        private readonly IWorksCategory _manageWorkCategory;
        private readonly IMessageService _messageService;
        private readonly View.IWorkCategory _view;        public WorkCategoryFormPresenter(View.IWorkCategory view, IMessageService messageService, IWorksCategory manageWorkCategory)        {            _view = view;            _messageService = messageService;            _manageWorkCategory = manageWorkCategory;            _view.ButtonCloseClick += _view_ButtonCloseClick;            _view.ButtonDeleteClick += _view_ButtonDeleteClick;            _view.ButtonInsertClick += _view_ButtonInsertClick;            _view.UpdateDataGridCategory += _view_UpdateDataGridCategory;                   }

        void _view_ButtonCloseClick(object sender, EventArgs e)
        {
            _view.CloseForm();
        }

        void _view_ButtonDeleteClick(object sender, EventArgs e)
        {
            if (_view.WorkCategory == "")
            {
                _messageService.ShowMessage("Пожалуйста, выберите категрию!");
                return;
            }
            DialogResult result = _messageService.ConfimDeleteWorkCategory(_view.WorkCategory);
            if (result == DialogResult.Yes)
            {
                _manageWorkCategory.DeleteWorkCategory(_view.WorkCategory);
                _messageService.ShowMessage(string.Format("Категория с названием {0} удалена!", _view.WorkCategory));
                _view.Clear();
            }
        }

        void _view_ButtonInsertClick(object sender, EventArgs e)
        {
            if (_manageWorkCategory.InsertWorkCategory(_view.WorkCategory) == true)
            {
                _messageService.ShowMessage(string.Format("Категория с названием {0} добавлена!", _view.WorkCategory));
                UpdateDataGrid();
                _view.Clear();
            }
            else
            {
                _messageService.ShowMessage(string.Format("Категория с названием {0} уже существует!", _view.WorkCategory));
                _view.Clear();
            }

        }

        void _view_UpdateDataGridCategory(object sender, EventArgs e)        {            UpdateDataGrid();        }        private void UpdateDataGrid()        {            _view.GetAllCategory(_manageWorkCategory.GetAllCategory());        }    }}
