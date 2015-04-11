using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using System.Windows.Forms;using AutoserviceCore;namespace AutoserviceUI.Presenters{    class ModelFormPresenter    {
        private readonly IModel _manageModel;
        private readonly MessageService _service;
        private readonly View.IModelInterface _view;        public ModelFormPresenter(View.IModelInterface view, MessageService service, IModel manageModel)        {            _view = view;            _service = service;            _manageModel = manageModel;            _view.UpdateMarkLoadForm += _view_UpdateMarkLoadForm;            _view.UpdateGridModel += _view_UpdateGridModel;            _view.UpdateTypeModelLoadForm += _view_UpdateTypeModelLoadForm;            _view.ButInsertModelClick += _view_ButInsertModelClick;            _view.ButCancelModelClick += _view_ButCancelModelClick;            _view.ButDeleteModelClick += _view_ButDeleteModelClick;        }
        void _view_ButCancelModelClick(object sender, EventArgs e)
        {
            _view.CloseForm();
        }

        void _view_ButDeleteModelClick(object sender, EventArgs e)
        {
            if (_view.Modelname == "")
            {
                _service.ShowMessage("Пожалуйста, выберите модель!");
                return;
            }
            DialogResult result = _service.ConfimDeleteModel(_view.Modelname);
            if (result == DialogResult.Yes)
            {
                _manageModel.DeleteModel(_view.Modelname);
                _service.ShowMessage(string.Format("Модель с названием {0} удалена!", _view.Modelname));
                UpdateModelGrid();
                _view.Clear();
            }
        }

        void _view_ButInsertModelClick(object sender, EventArgs e)
        {
            try
            {
                if (_view.Modelname == "" || _view.Volume == "" || _view.Power == "")
                {
                    _service.ShowError("Поля не могут быть пустыми!");
                    return;
                }

                if (_manageModel.InsertModel(Convert.ToInt32(_view.cmbMarkID), _view.Modelname, Convert.ToInt32(_view.Volume), Convert.ToInt32(_view.Power), Convert.ToInt32(_view.cmbTypeModelID)) == true)
                {
                    _service.ShowMessage("Модель добавлена!");
                    UpdateModelGrid();
                    _view.Clear();

                }
                else _service.ShowExclamation("Такая модель уже существует!");
            }
            catch (FormatException)
            {
                _service.ShowError("Поля 'Объем двигателя' и 'Мощьность двигателя' должны содержать число!");
                return;
            }
        }

        void _view_UpdateGridModel(object sender, EventArgs e)
        {
            UpdateModelGrid();
        }

        void _view_UpdateMarkLoadForm(object sender, EventArgs e)
        {
            _view.cmbMarkUpdate(_manageModel.GetComboMarks());
        }

        void _view_UpdateTypeModelLoadForm(object sender, EventArgs e)
        {
            _view.cmbTypeModelUpdate(_manageModel.GetComboType());
        }

        private void UpdateModelGrid()        {            _view.UpdateModel(_manageModel.GetAllModels());        }        #region Реализация событий IModel        #endregion    }}
