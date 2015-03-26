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
    public interface IAdminForm
    {
        string AdminID { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        void UpdateAdmin(DataTable dt);
        void CloseForm();
        event EventHandler DataGridAdminUpdate;
        event EventHandler InsertAdminClick;
        event EventHandler CancelAdminClick;
        event EventHandler DeleteAdminClick;

    }
    public partial class AdminForm : Form,IAdminForm
    {
        public AdminForm()
        {
            InitializeComponent();
            butInsertAdmin.Click += butInsertAdmin_Click;
            butCancelAdmin.Click += butCancelAdmin_Click;
            this.Load += AdminForm_Load;
            dataAdminGridView.CellContentClick += dataAdminGridView_CellContentClick;
            butAdminDelete.Click += butAdminDelete_Click;

        }

        void butAdminDelete_Click(object sender, EventArgs e)
        {
            if (DeleteAdminClick != null) DeleteAdminClick(this, EventArgs.Empty);
        }

        void dataAdminGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataAdminGridView.Rows[e.RowIndex];
                AdminID = row.Cells["AdminID"].Value.ToString();
                Login = row.Cells["Login"].Value.ToString();
            }
        }
        #region Вспомогательные функции
        public void CloseForm()
        {
            this.Close();
        }
        public string Login
        {
            get
            {
                return textLogin.Text;
            }
            set
            {
                textLogin.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return textPassword.Text;
            }
            set
            {
                textPassword.Text = value;
            }
        }
        public void UpdateAdmin(DataTable dt)
                {

                    dataAdminGridView.DataSource = dt;
                    
                }
        #endregion
        #region Проброс событий
        void AdminForm_Load(object sender, EventArgs e)
        {
            if (DataGridAdminUpdate != null) DataGridAdminUpdate(this, EventArgs.Empty);
        }
        void butCancelAdmin_Click(object sender, EventArgs e)
        {
            if (CancelAdminClick != null) CancelAdminClick(this, EventArgs.Empty);
        }
        void butInsertAdmin_Click(object sender, EventArgs e)
        {
            if (InsertAdminClick != null) InsertAdminClick(this, EventArgs.Empty);
        }
     
        public event EventHandler InsertAdminClick;
        public event EventHandler CancelAdminClick;
        public event EventHandler DataGridAdminUpdate;
        public event EventHandler DeleteAdminClick;
        #endregion






        public string AdminID
        {
            get
            {
                return textAdminID.Text;
            }
            set
            {
                textAdminID.Text = value;
            }
        }


        
    }
}
