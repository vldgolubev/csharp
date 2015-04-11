using System;using System.Collections.Generic;using System.ComponentModel;using System.Data;using System.Drawing;using System.Linq;using System.Text;using System.Threading.Tasks;using System.Windows.Forms;/* Интерфейс формы Рабочие*/namespace AutoserviceUI.View{    public interface IWorkersInterface    {
        event EventHandler ButCancelClickEvent;

        event EventHandler ButDeleteClickEvent;

        event EventHandler ButInsertClickEvent;

        event EventHandler DataGridWorkersUpdateEvent;

        string Address { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }
        string Passport { get; set; }

        string PathName { get; set; }        string Phone { get; set; }        void ClearForm();        void CloseForm();        void DataGridDataTable(DataTable dt);    }    public partial class WorkersFormView : Form, IWorkersInterface    {        public WorkersFormView()        {            InitializeComponent();            butCancel.Click += butCancel_Click;            butDelete.Click += butDelete_Click;            butInsert.Click += butInsert_Click;            this.Load += WorkersFormView_Load;            dataGridWorkers.CellClick += dataGridWorkers_CellClick;        }

        public event EventHandler ButCancelClickEvent;

        public event EventHandler ButDeleteClickEvent;

        public event EventHandler ButInsertClickEvent;

        public event EventHandler DataGridWorkersUpdateEvent;

        public string Address
        {
            get
            {
                return txtAddress.Text;
            }
            set
            {
                txtAddress.Text = value;
            }
        }

        public string FirstName
        {
            get
            {
                return txtFirstName.Text;
            }
            set
            {
                txtFirstName.Text = value;
            }
        }

        public string LastName
        {
            get
            {
                return txtLastName.Text;
            }
            set
            {
                txtLastName.Text = value;
            }
        }

        public string Passport
        {
            get
            {
                return txtPassport.Text;
            }
            set
            {
                txtPassport.Text = value;
            }
        }

        public string PathName
        {
            get
            {
                return txtFathName.Text;
            }
            set
            {
                txtFathName.Text = value;
            }
        }

        public string Phone
        {
            get
            {
                return txtPhone.Text;
            }
            set
            {
                txtPhone.Text = value;
            }
        }

        public void ClearForm()
        {
            LastName = "";
            FirstName = "";
            PathName = "";
            Passport = "";
            Address = "";
            Phone = "";
        }

        public void CloseForm()
        {
            this.Close();
        }

        public void DataGridDataTable(DataTable dt)
        {
            dataGridWorkers.DataSource = dt;
            dataGridWorkers.Columns[0].HeaderText = "Фамилия";
            dataGridWorkers.Columns[1].HeaderText = "Имя";
            dataGridWorkers.Columns[2].HeaderText = "Отчество";
            dataGridWorkers.Columns[3].HeaderText = "Паспорт";
            dataGridWorkers.Columns[4].HeaderText = "Адрес";
            dataGridWorkers.Columns[4].Width = 275;
            dataGridWorkers.Columns[5].HeaderText = "Телефон";
        }

        void butCancel_Click(object sender, EventArgs e)
        {
            if (ButCancelClickEvent != null) ButCancelClickEvent(this, EventArgs.Empty);
        }

        void butDelete_Click(object sender, EventArgs e)
        {
            if (ButDeleteClickEvent != null) ButDeleteClickEvent(this, EventArgs.Empty);
        }

        void butInsert_Click(object sender, EventArgs e)
        {
            if (ButInsertClickEvent != null) ButInsertClickEvent(this, EventArgs.Empty);
        }

        void dataGridWorkers_CellClick(object sender, DataGridViewCellEventArgs e)        {            if (e.RowIndex >= 0)            {                DataGridViewRow row = this.dataGridWorkers.Rows[e.RowIndex];                LastName = row.Cells["WorkerLn"].Value.ToString();                FirstName = row.Cells["WorkerFn"].Value.ToString();                PathName = row.Cells["WorkerPn"].Value.ToString();                Passport = row.Cells["WorkerPassport"].Value.ToString();                Address = row.Cells["WorkerAddress"].Value.ToString();                Phone = row.Cells["WorkerPhone"].Value.ToString();            }        }        #region Проброс событий        void WorkersFormView_Load(object sender, EventArgs e)        {            if (DataGridWorkersUpdateEvent != null) DataGridWorkersUpdateEvent(this, EventArgs.Empty);        }        #endregion    }}
