using System;
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
        event EventHandler AdminFormClick;
        event EventHandler ModelsFormClick;
        event EventHandler MarksFormClick;
        event EventHandler TypesFormClick;
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

        }
        #region MainForm Events
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

        public event EventHandler AdminFormClick;
        public event EventHandler ModelsFormClick;
        public event EventHandler MarksFormClick;
        public event EventHandler TypesFormClick;
        #endregion

    }
}
