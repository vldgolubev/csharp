using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using AutoserviceCore;using System.Windows.Forms;namespace AutoserviceUI.Presenters{    class CarsFormPresenter    {
        private readonly ICarsManager _manageCars;
        private readonly IMessageService _messageService;
        private readonly View.ICarsInterface _view;        public CarsFormPresenter(View.ICarsInterface view, IMessageService messageService, ICarsManager manageCars)         {            _view = view;            _messageService = messageService;            _manageCars = manageCars;            _view.ButCancelClickEvent += _view_ButCancelClickEvent;            _view.ButDeleteClickEvent += _view_ButDeleteClickEvent;            _view.ButInsertClickEvent += _view_ButInsertClickEvent;            _view.UpdateCarGridViewEvent += _view_UpdateCarGridViewEvent;        }

        void _view_ButCancelClickEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void _view_ButDeleteClickEvent(object sender, EventArgs e)
        {
            if (_view.CarID == "")
            {
                _messageService.ShowError("Пожалуйста, выберете автомобиль который хотите удалить!");
                return;
            }
            DialogResult result = _messageService.ConfimDeleteCar();
            if (result == DialogResult.Yes)
            {
                _manageCars.DeleteCar(_view.CarID);
                _messageService.ShowMessage("Автомобиль удален!");
                _view.ClearForm();
                UpdateGrid();
            }
        }

        void _view_ButInsertClickEvent(object sender, EventArgs e)
        {
            try
            {
                if (_view.Color == "" || _view.Number == "")
                {
                    _messageService.ShowMessage("Поля не могут быть пустыми!");
                    return;
                }
                if (_manageCars.InsertCar(_view.cmbOwnerID, _view.cmbModelID, _view.Color, _view.Number) == true)
                {
                    _messageService.ShowMessage("Машина добавлена!");
                    UpdateGrid();
                    _view.ClearForm();
                }
                else _messageService.ShowExclamation("Такая модель уже существует!");
            }
            catch (FormatException)
            {
                _messageService.ShowError("Поле 'Номер' не может быть пустым!");
                return;
            }
        }

        void _view_UpdateCarGridViewEvent(object sender, EventArgs e)
        {
            _view.cmbModelUpdate(_manageCars.GetModelList());
            _view.cmbOwnerUpdate(_manageCars.GetOwnerList());
            UpdateGrid();
        }

        private void UpdateGrid()        {            _view.UpdateGrid(_manageCars.GetAllCars());        }    }}
