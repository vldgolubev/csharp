using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoserviceCore;
using System.Windows.Forms;

namespace AutoserviceUI.Presenters
{
    class WorksFormPresenter
    {
        private readonly View.IWorksInterface _view;
        private readonly MessageService _messageService;
        private readonly IWorksInterface _manageWorks;

        public WorksFormPresenter(View.IWorksInterface view, MessageService messageService, IWorksInterface manageWorks) 
        {
            _view = view;
            _messageService = messageService;
            _manageWorks = manageWorks;

            _view.ButCancelClick += _view_ButCancelClick;
            _view.ButInsertClick += _view_ButInsertClick;
            _view.ButDeleteClick += _view_ButDeleteClick;
            _view.UpdateGridEvent += _view_UpdateGridEvent;
            _view.UpdateComboWorksEvent += _view_UpdateComboWorksEvent;
        }

        void _view_UpdateComboWorksEvent(object sender, EventArgs e)
        {
            _view.UpdateCmbCaterogy(_manageWorks.getComboWorksCategory());
        }
        /// <summary>
        /// Событие, возникающее при нажатии кнопки ButDeleteClick
        /// </summary>
        void _view_ButDeleteClick(object sender, EventArgs e)
        {
            if (_view.WorkName == "")
            {
                _messageService.ShowMessage("Выберите работу для удаления!");
                return;
            }
            DialogResult result = _messageService.ConfimDeleteWorkCategory(_view.WorkName);
            if (result == DialogResult.Yes)
            {
                _manageWorks.DeleteWork(_view.WorkName);
                _messageService.ShowMessage(string.Format("Работа с именем {0} удалена!", _view.WorkName));
                _view.Clear();
                UpdateGrid();
            }

        }
        /// <summary>
        /// Событие, возникающее при загрузки формы
        /// </summary>
        void _view_UpdateGridEvent(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            _view.UpdateWorks(_manageWorks.GetAllWorks());
        }
        /// <summary>
        /// Событие, возникающее при нажатии кнопки ButInsertClick 
        /// </summary>
        void _view_ButInsertClick(object sender, EventArgs e)
        {
            try
            {
                if (_view.WorkName == "")
                {
                    _messageService.ShowMessage("Поля не могут быть пустыми!");
                    return;
                }
                if (_manageWorks.InsertWork(_view.WorkName, Convert.ToDouble(_view.WorkCost), Convert.ToInt32(_view.cmbWorkCategoryID)) == true)
                {
                    UpdateGrid();
                    _messageService.ShowMessage(string.Format("Работа с названием {0} добавлена!", _view.WorkName));
                    _view.Clear();
                }
            }
            catch (FormatException)
            {
                _messageService.ShowMessage("Поле 'Стоимость' должно являться числом!");
                _view.Clear();
            }
        }
        /// <summary>
        /// Событие, возникающее при нажатии кнопки ButCancelClick
        /// </summary>
        void _view_ButCancelClick(object sender, EventArgs e)
        {
            _view.CloseForm();
        }
    }
}
