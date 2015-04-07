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

namespace AutoserviceUI
{
    public interface IMainForm
    {
        string SelectedAuto { get; set; }
        string Search { get;}
        string SerchValue { get; set; }
        bool RadioNumberChecked { get; }
        bool RadioLastNameChecked { get; }
        bool RadioPassportNumberChecked { get; }
        event EventHandler AdminFormClick;
        event EventHandler ModelsFormClick;
        event EventHandler MarksFormClick;
        event EventHandler TypesFormClick;
        event EventHandler WorksTypeFormClick;
        event EventHandler WorksFormClick;
        event EventHandler WorkersFormClick;
        event EventHandler OrdersFormClick;
        event EventHandler ClientFormClick;
        event EventHandler AutoClientFormClick;
        event EventHandler LoadMainFromEvent;
        event EventHandler UpdateCmbWorkerEvent;
        event EventHandler ChoiceAutoSearch;
        void UncompleteOrdersCount(int count);
        void UpdateCmbWorker(ArrayList workers);
    }
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            AdminsMenuItem.Click += AdminsMenuItem_Click;
            ModelsMenuItem.Click += ModelsMenuItem_Click;
            MarksMenuItem.Click+=MarksMenuItem_Click;
            TypesMenuItem.Click += TypesMenuItem_Click;
            butSearchAuto.Click += butSearchAuto_Click;

            WorkCategoryMenuItem.Click += WorkCategoryMenuItem_Click;
            WorksMenuItem.Click += WorksMenuItem_Click;
            WorkersMenuItem.Click += WorkersMenuItem_Click;
            ClientMenuItem.Click += ClientMenuItem_Click;
            AutoClientMenuItem.Click += AutoClientMenuItem_Click;
            OrdersMenuItem.Click += OrdersMenuItem_Click;
            this.Load += MainForm_Load;

        }
        #region MainForm Events
        void butSearchAuto_Click(object sender, EventArgs e)
        {
            if (ChoiceAutoSearch != null) ChoiceAutoSearch(this, EventArgs.Empty);
        }
        void MainForm_Load(object sender, EventArgs e)
        {
            if (LoadMainFromEvent != null) LoadMainFromEvent(this, EventArgs.Empty);
            if (UpdateCmbWorkerEvent != null) UpdateCmbWorkerEvent(this, EventArgs.Empty);
        }
        void OrdersMenuItem_Click(object sender, EventArgs e)
        {
            if (OrdersFormClick != null) OrdersFormClick(this, EventArgs.Empty);
        }
        void WorkersMenuItem_Click(object sender, EventArgs e)
        {
            if (WorkersFormClick != null) WorkersFormClick(this, EventArgs.Empty);
        }
        void WorksMenuItem_Click(object sender, EventArgs e)
        {
            if(WorksFormClick != null) WorksFormClick(this,EventArgs.Empty);
        }
        void WorkCategoryMenuItem_Click(object sender, EventArgs e)
        {
            if (WorksTypeFormClick != null) WorksTypeFormClick(this, EventArgs.Empty);
        }
        void TypesMenuItem_Click(object sender, EventArgs e)
        {
            if (TypesFormClick != null) TypesFormClick(this, EventArgs.Empty);
        }
        void MarksMenuItem_Click(object sender, EventArgs e)
        {
 	       if(MarksFormClick !=null) MarksFormClick(this,EventArgs.Empty);}
        void ModelsMenuItem_Click(object sender, EventArgs e)
        {
           if( ModelsFormClick != null) ModelsFormClick(this,EventArgs.Empty);
        }
        void AdminsMenuItem_Click(object sender, EventArgs e)
        {
            if (AdminFormClick != null) AdminFormClick(this, EventArgs.Empty);
        }
        void AutoClientMenuItem_Click(object sender, EventArgs e)
        {
            if (AutoClientFormClick != null) AutoClientFormClick(this, EventArgs.Empty);
        }
        void ClientMenuItem_Click(object sender, EventArgs e)
        {
            
            if (ClientFormClick != null) ClientFormClick(this, EventArgs.Empty);
        }

        public event EventHandler OrdersFormClick;
        public event EventHandler AdminFormClick;
        public event EventHandler ModelsFormClick;
        public event EventHandler MarksFormClick;
        public event EventHandler TypesFormClick;
        public event EventHandler WorksTypeFormClick;
        public event EventHandler WorksFormClick;
        public event EventHandler WorkersFormClick;
        public event EventHandler ClientFormClick;
        public event EventHandler AutoClientFormClick; 
        public event EventHandler LoadMainFromEvent;
        public event EventHandler UpdateCmbWorkerEvent;
        public event EventHandler ChoiceAutoSearch;
        #endregion

        public void UncompleteOrdersCount(int count)
        {
            toolCountUncompleteOrders.Text = count.ToString();
        }
        public void UpdateCmbWorker(ArrayList workers)
        {
            cmbWorker.DataSource = workers;
            cmbWorker.DisplayMember = "Worker_fio";
            cmbWorker.ValueMember = "Worker_id";
        }



        #region ComboSearch
        public bool RadioNumberChecked
        {
            get {
                if (rdoNumberAuto.Checked == true) return true;
                return false;
                }
        }


        public bool RadioLastNameChecked
        {
            get {
                if (rdoLastName.Checked == true) return true;
                return false;
                }
        }

        public bool RadioPassportNumberChecked
        {
            get {
                if (rdoPassportNum.Checked == true) return true;
                return false;
                }
        }
        #endregion

        public string Search
        {
            get { return txtSearch.Text; }
        }


        public string SerchValue
        {
            get
            {
                return txtSearchValue.Text;
            }
            set
            {
                txtSearchValue.Text = value.ToString();
            }
        }

        public string SelectedAuto
        {
            get
            {
                return txtSelectedAuto.Text;
            }
            set
            {
                try
                {
                    txtSelectedAuto.Text = value;
                }
                catch (NullReferenceException) { MessageBox.Show("Автомобиль не выбран!"); }
            }
        }
    }
}
