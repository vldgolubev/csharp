using System;using System.Collections;using System.Collections.Generic;using System.ComponentModel;using System.Data;using System.Drawing;using System.Linq;using System.Text;using System.Threading.Tasks;using System.Windows.Forms;/* Интерфейс Работы в заказе*/namespace AutoserviceUI.View{    public interface IOrderWorksInterface    {
        event EventHandler ButCancelClick;

        event EventHandler ButDeleteClick;

        event EventHandler ButInsertClick;

        event EventHandler ButSelectWorksByID;

        event EventHandler UpdateComboOrdersEvent;

        event EventHandler UpdateDataGridWorksEvent;

        event EventHandler UpdateOrderSum;

        event EventHandler UpdateWorkCategoryEvent;

        event EventHandler UpdateWorkEvent;

        string OrderID { get; set; }

        decimal OrderSum { get; set; }

        int WorkCategorySelected { get; }

        void Clear();

        void CloseForm();

        int GetOrderSelectedID();

        void GetOrderWorksData(DataTable dt);        int GetWorkSelectedID();        void UpdateCmbOrder(ArrayList arrayOrders);
        void UpdateCmbWork(ArrayList arrayWorks);

        void UpdateCmbWorkCategory(ArrayList arrayWork);    }    public partial class OrderWorksFormView : Form, IOrderWorksInterface    {        /* Вызов событий */        public OrderWorksFormView()        {            InitializeComponent();            this.Load+=OrderWorksFormView_Load;            dataGridOrderWorks.CellClick += dataGridOrderWorks_CellClick;            butCancel.Click += butCancel_Click;            butDelete.Click += butDelete_Click;            butInsert.Click += butInsert_Click;            cmbWork.Click += cmbWork_Click;            butSelectWorksByOrder.Click += OrderWorksFormView_ButSelectWorksByID;        }                #region Проброс событий
        public event EventHandler ButCancelClick;

        public event EventHandler ButDeleteClick;

        public event EventHandler ButInsertClick;

        public event EventHandler ButSelectWorksByID;

        public event EventHandler UpdateComboOrdersEvent;

        public event EventHandler UpdateDataGridWorksEvent;

        public event EventHandler UpdateOrderSum;

        public event EventHandler UpdateWorkCategoryEvent;

        public event EventHandler UpdateWorkEvent;

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

        public int WorkCategorySelected
        {
            get { return Convert.ToInt32(cmbCategory.SelectedValue); }
        }

        public void Clear()
        {
            txtOrderID.Text = "";
        }

        public void CloseForm()
        {
            this.Close();
        }

        public int GetOrderSelectedID()
        {
            return Convert.ToInt32(cmbOrder.SelectedValue);
        }

        public void GetOrderWorksData(DataTable dt)
        {
            dataGridOrderWorks.DataSource = dt;
            dataGridOrderWorks.Columns[0].Visible = false;
            dataGridOrderWorks.Columns[1].HeaderText = "Автомобиль";
            dataGridOrderWorks.Columns[1].Width = 170;
            dataGridOrderWorks.Columns[2].HeaderText = "Мастер";
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

        public int GetWorkSelectedID()
        {
            return Convert.ToInt32(cmbWork.SelectedValue);
        }

        public void UpdateCmbOrder(ArrayList arrayOrders)
        {
            cmbOrder.DataSource = arrayOrders;
            cmbOrder.DisplayMember = "Orderdescription";
            cmbOrder.ValueMember = "Orderid";

        }

        public void UpdateCmbWork(ArrayList arrayWorks)
        {

            cmbWork.DataSource = arrayWorks;
            cmbWork.DisplayMember = "Workname";
            cmbWork.ValueMember = "Workid";

        }

        public void UpdateCmbWorkCategory(ArrayList arrayWorkCategory)
        {
            cmbCategory.DataSource = arrayWorkCategory;
            cmbCategory.DisplayMember = "getWorkCategoryName";
            cmbCategory.ValueMember = "getWorkCategoryID";
        }

        void butCancel_Click(object sender, EventArgs e)
        {
            if (ButCancelClick != null) ButCancelClick(this, EventArgs.Empty);
        }

        void butDelete_Click(object sender, EventArgs e)
        {

            if (ButDeleteClick != null) ButDeleteClick(this, EventArgs.Empty);
            if (UpdateOrderSum != null) UpdateOrderSum(this, EventArgs.Empty);
        }

        void butInsert_Click(object sender, EventArgs e)
        {
            if (ButInsertClick != null) ButInsertClick(this, EventArgs.Empty);
            if (UpdateOrderSum != null) UpdateOrderSum(this, EventArgs.Empty);
        }

        void cmbWork_Click(object sender, EventArgs e)
        {
            if (UpdateWorkEvent != null) UpdateWorkEvent(this, EventArgs.Empty);
        }

        void dataGridOrderWorks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridOrderWorks.Rows[e.RowIndex];
                OrderID = row.Cells["OrderWorkID"].Value.ToString();
            }
        }

        void OrderWorksFormView_ButSelectWorksByID(object sender, EventArgs e)        {            if (ButSelectWorksByID != null) ButSelectWorksByID(this, EventArgs.Empty);        }        void OrderWorksFormView_Load(object sender, EventArgs e)        {            if (UpdateComboOrdersEvent != null) UpdateComboOrdersEvent(this, EventArgs.Empty);            if (UpdateDataGridWorksEvent != null) UpdateDataGridWorksEvent(this, EventArgs.Empty);            if (UpdateWorkCategoryEvent != null) UpdateWorkCategoryEvent(this, EventArgs.Empty);        }        #endregion    }}
