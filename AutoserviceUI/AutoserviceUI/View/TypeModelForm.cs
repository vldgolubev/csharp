using System;
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
    public interface ITypeModelInterface
    {
        string TypeModelID { get; set; }
        string TypeModelName { get; set; }
        void UpdateTypeModel(DataTable dt);
        void TypeModelFormClose();
        event EventHandler butInsertTypeModelClick;
        event EventHandler butCancelTypeModelClick;
        event EventHandler butDeleteTypeModelClick;
        event EventHandler dataGridLoad;
    }
    public partial class TypeModelForm : Form,ITypeModelInterface
    {
        public TypeModelForm()
        {
            InitializeComponent();
            this.Load += TypeModelForm_Load;
            butCancelTypeModel.Click += butCancelTypeModel_Click;
            butDeleteTypeModel.Click += butDeleteTypeModel_Click;
            butInsertTypeModel.Click += butInsertTypeModel_Click;
            dataGridTypeModel.CellClick += dataGridTypeModel_CellClick;
        }

        void TypeModelForm_Load(object sender, EventArgs e)
        {
            if (dataGridLoad != null) dataGridLoad(this, EventArgs.Empty);
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

        void butInsertTypeModel_Click(object sender, EventArgs e)
        {
            if (butInsertTypeModelClick != null) butInsertTypeModelClick(this, EventArgs.Empty);
        }

        void butDeleteTypeModel_Click(object sender, EventArgs e)
        {
            if (butDeleteTypeModelClick != null) butDeleteTypeModelClick(this, EventArgs.Empty);
        }

        void butCancelTypeModel_Click(object sender, EventArgs e)
        {
            if (butCancelTypeModelClick != null) butCancelTypeModelClick(this, EventArgs.Empty);
        }

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

        public event EventHandler butInsertTypeModelClick;

        public event EventHandler butCancelTypeModelClick;

        public event EventHandler butDeleteTypeModelClick;


        public void UpdateTypeModel(DataTable dt)
        {
            dataGridTypeModel.DataSource = dt;
        }


        public event EventHandler dataGridLoad;


        public void TypeModelFormClose()
        {
            this.Close();
        }
    }
}
