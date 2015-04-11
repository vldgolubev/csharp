using System;using System.Collections.Generic;using System.ComponentModel;using System.Data;using System.Drawing;using System.Linq;using System.Text;using System.Threading.Tasks;using System.Windows.Forms;/* Интерфейс формы категории работ*/namespace AutoserviceUI.View{    public interface IWorkCategory    {
        event EventHandler ButtonCloseClick;

        event EventHandler ButtonDeleteClick;

        event EventHandler ButtonInsertClick;

        event EventHandler UpdateDataGridCategory;

        string WorkCategory { get; set; }        void Clear();        void CloseForm();        void GetAllCategory(DataTable dt);    }    public partial class WorkCategoryFormView : Form,IWorkCategory    {        public WorkCategoryFormView()        {            InitializeComponent();            btnInsert.Click += btnInsert_Click;            btnDelete.Click += btnDelete_Click;            btnClose.Click += btnClose_Click;            this.Load += WorkCategoryFormView_Load;            dataGridCategory.CellClick += dataGridCategory_CellClick;                   }

        public event EventHandler ButtonCloseClick;

        public event EventHandler ButtonDeleteClick;

        public event EventHandler ButtonInsertClick;

        public event EventHandler UpdateDataGridCategory;

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

        public void CloseForm()
        {
            this.Close();
        }

        public void GetAllCategory(DataTable dt)
        {
            dataGridCategory.DataSource = dt;
            dataGridCategory.Columns[0].HeaderText = "Название работы";
            dataGridCategory.Columns[0].Width = 250;
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

        void dataGridCategory_CellClick(object sender, DataGridViewCellEventArgs e)        {            if (e.RowIndex >= 0)            {               DataGridViewRow row = this.dataGridCategory.Rows[e.RowIndex];              WorkCategory = row.Cells["WorkCategoryName"].Value.ToString();            }        }        #region Проброс событий        void WorkCategoryFormView_Load(object sender, EventArgs e)        {            if (UpdateDataGridCategory != null) UpdateDataGridCategory(this, EventArgs.Empty);        }        #endregion        #region IWorkCategory Аксессры и чистка        #endregion    }}
