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
    public interface IWorkCategory
    {
        string WorkCategory { get; set; }
        void Clear();
        void CloseForm();
        void GetAllCategory(DataTable dt);
        event EventHandler ButtonInsertClick;
        event EventHandler ButtonCloseClick;
        event EventHandler ButtonDeleteClick;
        event EventHandler UpdateDataGridCategory;

    }
    public partial class WorkCategoryFormView : Form,IWorkCategory
    {
        public WorkCategoryFormView()
        {
            InitializeComponent();
            btnInsert.Click += btnInsert_Click;
            btnDelete.Click += btnDelete_Click;
            btnClose.Click += btnClose_Click;
            this.Load += WorkCategoryFormView_Load;
            dataGridCategory.CellClick += dataGridCategory_CellClick;
           
        }

        void dataGridCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               DataGridViewRow row = this.dataGridCategory.Rows[e.RowIndex];
              WorkCategory = row.Cells["WorkCategoryName"].Value.ToString();
            }
        }

        #region Проброс событий
        void WorkCategoryFormView_Load(object sender, EventArgs e)
        {
            if (UpdateDataGridCategory != null) UpdateDataGridCategory(this, EventArgs.Empty);
        }
        void btnClose_Click(object sender, EventArgs e)
        {
            if (ButtonCloseClick != null) ButtonCloseClick(this, EventArgs.Empty);
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (ButtonDeleteClick != null) ButtonDeleteClick(this, EventArgs.Empty);
        }

        void btnInsert_Click(object sender, EventArgs e)
        {
            if (ButtonInsertClick != null) ButtonInsertClick(this, EventArgs.Empty);
        }
        public event EventHandler ButtonInsertClick;
        public event EventHandler ButtonCloseClick;
        public event EventHandler ButtonDeleteClick;
        public event EventHandler UpdateDataGridCategory;
        #endregion
        #region IWorkCategory Аксессры и чистка
        public void GetAllCategory(DataTable dt)
        {
            dataGridCategory.DataSource = dt;
            dataGridCategory.Columns[0].HeaderText = "Название работы";
            dataGridCategory.Columns[0].Width = 250;
        }
        public string WorkCategory
        {
            get
            {
                return txtWorkCategoryName.Text;
            }
            set
            {
                txtWorkCategoryName.Text = value;
            }
        }
        public void Clear()
        {
            txtWorkCategoryName.Text = "";
        }
        public void CloseForm() {
            this.Close();
        }
        #endregion
    }
}
