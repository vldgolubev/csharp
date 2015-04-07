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
    public interface IOrderWorksInterface
    {
        void GetOrderWorksData(DataTable dt);
        void CloseForm();
        void Clear();
        string OrderID { get; set; }
        void UpdateCmbOrder(ArrayList arrayOrders);
        void UpdateCmbWorkCategory(ArrayList arrayWork);
        void UpdateCmbWork(ArrayList arrayWorks);
        event EventHandler ButInsertClick;
        event EventHandler ButDeleteClick;
        event EventHandler ButCancelClick;
        event EventHandler UpdateDataGridWorksEvent;
        event EventHandler UpdateWorkCategoryEvent;
        event EventHandler UpdateWorkEvent;
    }
    public partial class OrderWorksFormView : Form, IOrderWorksInterface
    {
        public OrderWorksFormView()
        {
            InitializeComponent();
            this.Load += OrderWorksFormView_Load;
            dataGridOrderWorks.CellClick += dataGridOrderWorks_CellClick;
            butCancel.Click += butCancel_Click;
            butDelete.Click += butDelete_Click;
            butInsert.Click += butInsert_Click;
            cmbCategory.TextChanged += cmbCategory_TextChanged;
        }

        void cmbCategory_TextChanged(object sender, EventArgs e)
        {
           // if (UpdateWorkEvent != null) UpdateWorkEvent(this, EventArgs.Empty);
        }

        void butInsert_Click(object sender, EventArgs e)
        {
            if (ButInsertClick != null) ButInsertClick(this, EventArgs.Empty);
        }

        void butDelete_Click(object sender, EventArgs e)
        {

            if (ButDeleteClick != null) ButDeleteClick(this, EventArgs.Empty);
        }

        void butCancel_Click(object sender, EventArgs e)
        {
            if (ButCancelClick != null) ButCancelClick(this, EventArgs.Empty);
        }

        void dataGridOrderWorks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridOrderWorks.Rows[e.RowIndex];
                OrderID = row.Cells["OrderWorkID"].Value.ToString();
            }
        }

        void OrderWorksFormView_Load(object sender, EventArgs e)
        {
            if (UpdateDataGridWorksEvent != null) UpdateDataGridWorksEvent(this, EventArgs.Empty);
            if (UpdateWorkCategoryEvent != null) UpdateWorkCategoryEvent(this, EventArgs.Empty);
        }

       


        public event EventHandler UpdateDataGridWorksEvent; 
        public void GetOrderWorksData(DataTable dt)
        { 
            dataGridOrderWorks.DataSource = dt;
            dataGridOrderWorks.Columns[0].Visible = true;
            dataGridOrderWorks.Columns[1].HeaderText = "Мастер";
            dataGridOrderWorks.Columns[2].HeaderText = "Автомобиль";
            dataGridOrderWorks.Columns[3].HeaderText = "Услуга";
            dataGridOrderWorks.Columns[4].HeaderText = "Стоимость";
            dataGridOrderWorks.Columns[5].HeaderText = "Дата обращения";
            dataGridOrderWorks.Columns[6].HeaderText = "Дата выплонения";
        }


        public string OrderID
        {
            get
            {
                return txtOrderID.Text;
            }
            set
            {
                txtOrderID.Text = value;
            }
        }

        public void UpdateCmbOrder(ArrayList arrayOrders)
        {
            throw new NotImplementedException();

        }

        public void UpdateCmbWorkCategory(ArrayList arrayWorkCategory)
        {
            cmbCategory.DataSource = arrayWorkCategory;
            cmbCategory.DisplayMember = "getWorkCategoryName";
            cmbCategory.ValueMember = "getWorkCategoryID";
        }

        public event EventHandler ButInsertClick;

        public event EventHandler ButDeleteClick;

        public event EventHandler ButCancelClick;


        public void CloseForm()
        {
            this.Close();
        }

        public void Clear()
        {
            
        }


        public event EventHandler UpdateWorkCategoryEvent;


        public event EventHandler UpdateWorkEvent;


        public void UpdateCmbWork(ArrayList arrayWorks)
        {
            cmbWork.DataSource = arrayWorks;
            cmbWork.DisplayMember = "Workname";
            cmbWork.ValueMember = "Workid";
        }


    }
}
