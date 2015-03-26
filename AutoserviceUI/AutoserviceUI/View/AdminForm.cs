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
        string Login { get; set; }
        string Password { get; set; }
        void CloseForm();
        event EventHandler InsertAdminClick;
        event EventHandler CancelAdminClick;
    }
    public partial class AdminForm : Form,IAdminForm
    {
        public AdminForm()
        {
            InitializeComponent();
            butInsertAdmin.Click += butInsertAdmin_Click;
            butCancelAdmin.Click += butCancelAdmin_Click;

        }

        void butCancelAdmin_Click(object sender, EventArgs e)
        {
            if (CancelAdminClick != null) CancelAdminClick(this, EventArgs.Empty);
        }

        void butInsertAdmin_Click(object sender, EventArgs e)
        {
            if (InsertAdminClick != null) InsertAdminClick(this, EventArgs.Empty);
        }
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
        public event EventHandler InsertAdminClick;
        public event EventHandler CancelAdminClick;



       
    }
}
