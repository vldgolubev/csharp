using System;using System.Collections.Generic;using System.ComponentModel;using System.Data;using System.Drawing;using System.Linq;using System.Text;using System.Threading.Tasks;using System.Windows.Forms;/* Интерфейс Формы авторизации */namespace AutoserviceUI.View{    public interface ILoginInterface    {
        event EventHandler ButCancelClick;

        event EventHandler ButLoginClick;

        string Login { get; }        string Password { get; }        void ApplicationExit();        void RunMain();    }    public partial class LoginFormView : Form, ILoginInterface    {        public LoginFormView()        {            InitializeComponent();            butLoginAccept.Click += butLoginAccept_Click;            butLoginCancel.Click += butLoginCancel_Click;        }

        public event EventHandler ButCancelClick;

        public event EventHandler ButLoginClick;

        public string Login
        {
            get { return txtLogin.Text; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
        }

        public void ApplicationExit()
        {

            Application.Exit();
        }

        public void RunMain()
        {
            this.DialogResult = DialogResult.OK;
        }

        void butLoginAccept_Click(object sender, EventArgs e)
        {
            if (ButLoginClick != null) ButLoginClick(this, EventArgs.Empty);
        }

        void butLoginCancel_Click(object sender, EventArgs e)        {            if (ButCancelClick != null) ButCancelClick(this, EventArgs.Empty);        }    }}
