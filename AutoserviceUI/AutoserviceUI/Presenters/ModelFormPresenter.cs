using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoserviceCore;

namespace AutoserviceUI.Presenters
{
    class ModelFormPresenter
    {
        private readonly View.IModelInterface _view;
        private readonly MessageService _service;
        private readonly IModel _manageModel;

        public ModelFormPresenter(View.IModelInterface view, MessageService service, IModel manageModel)
        {
            _view = view;
            _service = service;
            _manageModel = manageModel;
            _view.UpdateMarkLoadForm += _view_UpdateMarkLoadForm;
            _view.UpdateTypeModelLoadForm += _view_UpdateTypeModelLoadForm;
            _view.ButInsertModelClick += _view_ButInsertModelClick;


        }

        void _view_UpdateTypeModelLoadForm(object sender, EventArgs e)
        {
            _view.cmbTypeModelUpdate(_manageModel.GetComboType());
        }

        void _view_UpdateMarkLoadForm(object sender, EventArgs e)
        {
            _view.cmbMarkUpdate(_manageModel.GetComboMarks());
        }



        void _view_ButInsertModelClick(object sender, EventArgs e)
        {
            
          ///
        }

    }
}
