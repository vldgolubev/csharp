﻿using System;
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
        event EventHandler WorksTypeFormClick;
        event EventHandler WorksFormClick;
        event EventHandler WorkersFormClick;
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

            WorkCategoryMenuItem.Click += WorkCategoryMenuItem_Click;
            WorksMenuItem.Click += WorksMenuItem_Click;
            WorkersMenuItem.Click += WorkersMenuItem_Click;

        }

        #region MainForm Events
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

        public event EventHandler AdminFormClick;
        public event EventHandler ModelsFormClick;
        public event EventHandler MarksFormClick;
        public event EventHandler TypesFormClick;
        public event EventHandler WorksTypeFormClick;
        public event EventHandler WorksFormClick;
        public event EventHandler WorkersFormClick;
        #endregion



        
    }
}
