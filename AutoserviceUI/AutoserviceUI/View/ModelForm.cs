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
        string cmbTypeModelID { get; }
        string Modelname { get; set; }
        int Volume { get; set; }
        int Power { get; set; }
        event EventHandler ButDeleteModelClick;
        event EventHandler ButCancelModelClick;
        event EventHandler ButInsertModelClick;
        event EventHandler UpdateGridModel;
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

        

        public string cmbMarkID
        {
            get { return cmbMark.SelectedValue.ToString(); }
        }
        public string cmbTypeModelID
        {
            get { return cmbTypeModel.SelectedValue.ToString(); }
        }
        void ModelForm_Load(object sender, EventArgs e)
        {
            if (UpdateMarkLoadForm != null) UpdateMarkLoadForm(this, EventArgs.Empty);
            if (UpdateTypeModelLoadForm != null) UpdateTypeModelLoadForm(this, EventArgs.Empty);
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


        public string Modelname
        {
            get
            {
                return textModelName.Text;
            }
            set
            {
                textModelName.Text = value;
            }
        }

        public int Volume
        {
            get
            {
                return Convert.ToInt32(textVolume.Text);
            }
            set
            {
                textVolume.Text = value.ToString();
            }
        }

        public int Power
        {
            get
            {
                return Convert.ToInt32(textPower.Text);
            }
            set
            {
                textPower.Text = value.ToString();
            }
        }

        public event EventHandler ButDeleteModelClick;
        public event EventHandler ButCancelModelClick;
        public event EventHandler UpdateGridModel;
    }
}
