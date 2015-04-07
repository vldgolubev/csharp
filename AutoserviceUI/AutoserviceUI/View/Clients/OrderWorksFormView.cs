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
        decimal OrderSum { get; set; }
        string OrderID { get; set; }
        int WorkCategorySelected { get; }
        int GetOrderSelectedID();
        int GetWorkSelectedID();
        void UpdateCmbOrder(ArrayList arrayOrders);
        void UpdateCmbWorkCategory(ArrayList arrayWork);
        void UpdateCmbWork(ArrayList arrayWorks);
        event EventHandler ButSelectWorksByID;
        event EventHandler ButInsertClick;
        event EventHandler ButDeleteClick;
        event EventHandler ButCancelClick;
        event EventHandler UpdateDataGridWorksEvent;
        event EventHandler UpdateWorkCategoryEvent;
        event EventHandler UpdateWorkEvent;
        event EventHandler UpdateComboOrdersEvent;
        event EventHandler UpdateOrderSum;
    }
    public partial class OrderWorksFormView : Form, IOrderWorksInterface
    {
        /* Вызов событий */
        public OrderWorksFormView()
        {
            InitializeComponent();
            this.Load+=OrderWorksFormView_Load;
            dataGridOrderWorks.CellClick += dataGridOrderWorks_CellClick;
            butCancel.Click += butCancel_Click;
            butDelete.Click += butDelete_Click;
            butInsert.Click += butInsert_Click;
            cmbWork.Click += cmbWork_Click;
            butSelectWorksByOrder.Click += OrderWorksFormView_ButSelectWorksByID;
        }

        
        #region Проброс событий
        void OrderWorksFormView_ButSelectWorksByID(object sender, EventArgs e)
        {
            if (ButSelectWorksByID != null) ButSelectWorksByID(this, EventArgs.Empty);
        }

        void cmbWork_Click(object sender, EventArgs e)
        {
            if (UpdateWorkEvent != null) UpdateWorkEvent(this, EventArgs.Empty);
        }
        void butInsert_Click(object sender, EventArgs e)
        {
            if (ButInsertClick != null) ButInsertClick(this, EventArgs.Empty);
            if (UpdateOrderSum != null) UpdateOrderSum(this, EventArgs.Empty);
        }
        void butDelete_Click(object sender, EventArgs e)
        {

            if (ButDeleteClick != null) ButDeleteClick(this, EventArgs.Empty);
            if (UpdateOrderSum != null) UpdateOrderSum(this, EventArgs.Empty);
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
            if (UpdateComboOrdersEvent != null) UpdateComboOrdersEvent(this, EventArgs.Empty);
            if (UpdateDataGridWorksEvent != null) UpdateDataGridWorksEvent(this, EventArgs.Empty);
            if (UpdateWorkCategoryEvent != null) UpdateWorkCategoryEvent(this, EventArgs.Empty);

        }
        public event EventHandler ButInsertClick;
        public event EventHandler ButDeleteClick;
        public event EventHandler ButCancelClick;
        public event EventHandler UpdateWorkCategoryEvent;
        public event EventHandler UpdateWorkEvent;
        public event EventHandler UpdateComboOrdersEvent;
        public event EventHandler ButSelectWorksByID;
        public event EventHandler UpdateDataGridWorksEvent;
        #endregion
        public void GetOrderWorksData(DataTable dt)
        { 
            dataGridOrderWorks.DataSource = dt;
            dataGridOrderWorks.Columns[0].Visible = false;
            dataGridOrderWorks.Columns[1].HeaderText = "Мастер";
            dataGridOrderWorks.Columns[1].Width = 170;
            dataGridOrderWorks.Columns[2].HeaderText = "Автомобиль";
            dataGridOrderWorks.Columns[2].Width = 170;
            dataGridOrderWorks.Columns[3].HeaderText = "Услуга";
            dataGridOrderWorks.Columns[3].Width = 362;
            dataGridOrderWorks.Columns[4].HeaderText = "Стоимость";
            try
            {
                OrderSum = (decimal)dt.Compute("Sum(WorkCost)", "");

            }
            catch (InvalidCastException)
            {
                OrderSum = 0;
            }

        }
        public void UpdateCmbWork(ArrayList arrayWorks)
        {
           
                cmbWork.DataSource = arrayWorks;
                cmbWork.DisplayMember = "Workname";
                cmbWork.ValueMember = "Workid";
           
        }
        public void UpdateCmbOrder(ArrayList arrayOrders)
            {
                cmbOrder.DataSource = arrayOrders;
                cmbOrder.DisplayMember = "Orderdescription";
                cmbOrder.ValueMember = "Orderid";

            }
        public void UpdateCmbWorkCategory(ArrayList arrayWorkCategory)
        {
            cmbCategory.DataSource = arrayWorkCategory;
            cmbCategory.DisplayMember = "getWorkCategoryName";
            cmbCategory.ValueMember = "getWorkCategoryID";
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
        public void CloseForm()
        {
            this.Close();
        }
        public void Clear()
        {
            txtOrderID.Text = "";   
        }
        public int WorkCategorySelected
        {
            get { return Convert.ToInt32(cmbCategory.SelectedValue); }
        }
        public int GetOrderSelectedID()
        {
            return Convert.ToInt32(cmbOrder.SelectedValue);
        }
        public int GetWorkSelectedID()
        {
            return Convert.ToInt32(cmbWork.SelectedValue);
        }


        public decimal OrderSum
        {
            get
            {
                return Convert.ToDecimal(txtSumWork.Text);
            }
            set
            {
                txtSumWork.Text = value.ToString();
            }
        }






        public event EventHandler UpdateOrderSum;
    }
}
