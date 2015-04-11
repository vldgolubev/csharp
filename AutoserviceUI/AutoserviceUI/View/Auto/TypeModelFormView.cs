using System;using System.Collections.Generic;using System.ComponentModel;using System.Data;using System.Drawing;using System.Linq;using System.Text;using System.Threading.Tasks;using System.Windows.Forms;namespace AutoserviceUI.View{    public interface ITypeModelInterface    {
        event EventHandler butCancelTypeModelClick;

        event EventHandler butDeleteTypeModelClick;

        event EventHandler butInsertTypeModelClick;

        event EventHandler dataGridLoad;

        string TypeModelID { get; set; }        string TypeModelName { get; set; }
        void TypeModelFormClose();

        void UpdateTypeModel(DataTable dt);    }    public partial class TypeModelFormView : Form,ITypeModelInterface    {        public TypeModelFormView()        {            InitializeComponent();            this.Load += TypeModelForm_Load;            butCancelTypeModel.Click += butCancelTypeModel_Click;            butDeleteTypeModel.Click += butDeleteTypeModel_Click;            butInsertTypeModel.Click += butInsertTypeModel_Click;            dataGridTypeModel.CellClick += dataGridTypeModel_CellClick;        }

        public event EventHandler butCancelTypeModelClick;

        public event EventHandler butDeleteTypeModelClick;

        public event EventHandler butInsertTypeModelClick;

        public event EventHandler dataGridLoad;

        public string TypeModelID
        {
            get
            {
                return textTypeModelID.Text;
            }
            set
            {
                textTypeModelID.Text = value;
            }
        }

        public string TypeModelName
        {
            get
            {
                return textTypeModelType.Text;
            }
            set
            {
                textTypeModelType.Text = value;
            }
        }

        public void TypeModelFormClose()
        {
            this.Close();
        }

        public void UpdateTypeModel(DataTable dt)
        {
            dataGridTypeModel.DataSource = dt;
            dataGridTypeModel.Columns[0].HeaderText = "Идентификатор";
            dataGridTypeModel.Columns[1].HeaderText = "Название кузова";
            dataGridTypeModel.Columns[1].Width = 174;
        }

        void butCancelTypeModel_Click(object sender, EventArgs e)
        {
            if (butCancelTypeModelClick != null) butCancelTypeModelClick(this, EventArgs.Empty);
        }

        void butDeleteTypeModel_Click(object sender, EventArgs e)
        {
            if (butDeleteTypeModelClick != null) butDeleteTypeModelClick(this, EventArgs.Empty);
        }

        void butInsertTypeModel_Click(object sender, EventArgs e)
        {
            if (butInsertTypeModelClick != null) butInsertTypeModelClick(this, EventArgs.Empty);
        }

        void dataGridTypeModel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridTypeModel.Rows[e.RowIndex];
                TypeModelID = row.Cells["TypeModelID"].Value.ToString();
                TypeModelName = row.Cells["NameType"].Value.ToString();
            }
        }

        void TypeModelForm_Load(object sender, EventArgs e)        {            if (dataGridLoad != null) dataGridLoad(this, EventArgs.Empty);        }    }}
