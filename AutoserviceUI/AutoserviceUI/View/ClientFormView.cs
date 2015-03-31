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
    public interface IClientInterface
    {
        string LastName { get; set; }
        string FirstName { get; set; }
        string FathName { get; set; }
        string Passport { get; set; }
        string Address { get; set; }
        string Phone { get; set; }
        void ClearForm();
        void CloseForm();
        void DataGridDataTable(DataTable dt);
        event EventHandler ButInsertClickEvent;
        event EventHandler ButCancelClickEvent;
        event EventHandler ButDeleteClickEvent;
        event EventHandler DataGridClientsUpdateEvent;
    }
    public partial class ClientFormView : Form, IClientInterface
    {
        public ClientFormView()
        {
            InitializeComponent();
            butCancelClient.Click += butCancelClient_Click;
            butInsertClient.Click += butInsertClient_Click;
            butDeleteClient.Click += butDeleteClient_Click;
            dataGridClient.CellClick += dataGridClient_CellClick;
            this.Load += ClientFormView_Load;
        }

        void dataGridClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridClient.Rows[e.RowIndex];
                LastName = row.Cells["OwnerLn"].Value.ToString();
                FirstName = row.Cells["OwnerFn"].Value.ToString();
                FathName = row.Cells["OwnerPn"].Value.ToString();
                Passport = row.Cells["OwnerPassport"].Value.ToString();
                Address = row.Cells["OwnerAddress"].Value.ToString();
                Phone = row.Cells["OwnerPhone"].Value.ToString();
            }
        }
        #region Проброс событий
        void ClientFormView_Load(object sender, EventArgs e)
        {
            if (DataGridClientsUpdateEvent != null) DataGridClientsUpdateEvent(this, EventArgs.Empty);
        }
        void butDeleteClient_Click(object sender, EventArgs e)
        {
            if (ButDeleteClickEvent != null) ButDeleteClickEvent(this, EventArgs.Empty);
        }
        void butInsertClient_Click(object sender, EventArgs e)
        {
            if (ButInsertClickEvent != null) ButInsertClickEvent(this, EventArgs.Empty);
        }
        void butCancelClient_Click(object sender, EventArgs e)
        {
            if (ButCancelClickEvent != null) ButCancelClickEvent(this, EventArgs.Empty);
        }
        public event EventHandler ButInsertClickEvent;
        public event EventHandler ButCancelClickEvent;
        public event EventHandler ButDeleteClickEvent;
        public event EventHandler DataGridClientsUpdateEvent;
        #endregion
        #region Accessors
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
        public string FathName
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
        #endregion

        public void ClearForm()
        {
            LastName = "";
            FirstName = "";
            FathName = "";
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
            dataGridClient.DataSource = dt;
            dataGridClient.Columns[0].HeaderText = "Фамилия";
            dataGridClient.Columns[1].HeaderText = "Имя";
            dataGridClient.Columns[2].HeaderText = "Отчество";
            dataGridClient.Columns[3].HeaderText = "Паспорт";
            dataGridClient.Columns[4].HeaderText = "Адрес";
            dataGridClient.Columns[4].Width = 275;
            dataGridClient.Columns[5].HeaderText = "Телефон";
        }


    }
}
