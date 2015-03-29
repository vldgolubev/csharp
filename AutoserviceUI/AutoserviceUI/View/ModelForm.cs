using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoserviceUI.View
{
    public interface IModelInterface
    {
        void cmbMarkUpdate(ArrayList arrayMarks);
        void cmbTypeModelUpdate(ArrayList arrayTypeModels);
        string cmbMarkID { get; }

        event EventHandler ButInsertModelClick;
        event EventHandler UpdateMarkLoadForm;
        event EventHandler UpdateTypeModelLoadForm;
    }

    public partial class ModelForm : Form,IModelInterface
    {


        public ModelForm()
        {
            InitializeComponent();
            butInsertModel.Click += butInsertModel_Click;
            this.Load += ModelForm_Load;
        }

        void ModelForm_Load(object sender, EventArgs e)
        {
            if (UpdateMarkLoadForm != null) UpdateMarkLoadForm(this, EventArgs.Empty);
            if (UpdateTypeModelLoadForm != null) UpdateTypeModelLoadForm(this, EventArgs.Empty);
        }

        public string cmbMarkID
        {
            get { return cmbMark.SelectedValue.ToString(); }
        }
        public void cmbMarkUpdate(ArrayList arrayMarks)
        {
            cmbMark.DataSource = arrayMarks;
            cmbMark.DisplayMember = "MarkName";
            cmbMark.ValueMember = "MarkID";
        }
        public void cmbTypeModelUpdate(ArrayList arrayTypeModels)
        {
            cmbTypeModel.DataSource = arrayTypeModels;
            cmbTypeModel.DisplayMember = "NameType";
            cmbTypeModel.ValueMember = "TypeModelID";
        }
        void butInsertModel_Click(object sender, EventArgs e)
        {
            if (ButInsertModelClick != null) ButInsertModelClick(this, EventArgs.Empty);
        }

        public event EventHandler ButInsertModelClick;




        public event EventHandler UpdateMarkLoadForm;





        public event EventHandler UpdateTypeModelLoadForm;
    }
}
