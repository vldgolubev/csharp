﻿using System;using System.Collections;using System.Collections.Generic;using System.ComponentModel;using System.Data;using System.Drawing;using System.Linq;using System.Text;using System.Threading.Tasks;using System.Windows.Forms;/* Интерфейс работ*/namespace AutoserviceUI.View{    public interface IWorksInterface    {
        event EventHandler ButCancelClick;

        event EventHandler ButDeleteClick;

        event EventHandler ButInsertClick;

        event EventHandler UpdateComboWorksEvent;

        event EventHandler UpdateGridEvent;

        string cmbWorkCategoryID { get; }

        string WorkCost { get; set; }

        string WorkName { get; set; }

        void Clear();        void CloseForm();
        void UpdateCmbCaterogy(ArrayList workCategory);

        void UpdateWorks(DataTable dt);    }    public partial class WorksFormView : Form, IWorksInterface    {        public WorksFormView()        {            InitializeComponent();            btnCancel.Click += btnCancel_Click;            btnDelete.Click += btnDelete_Click;            btnInsert.Click += btnInsert_Click;            dataGridWorks.CellClick += dataGridWorks_CellClick;            this.Load += WorksFormView_Load;                  }

        public event EventHandler ButCancelClick;

        public event EventHandler ButDeleteClick;

        public event EventHandler ButInsertClick;

        public event EventHandler UpdateComboWorksEvent;

        public event EventHandler UpdateGridEvent;

        public string cmbWorkCategoryID
        {
            get { return cmbWorkCategory.SelectedValue.ToString(); }
        }

        public string WorkCost
        {
            get
            {
                return txtWorkCost.Text;
            }
            set
            {
                txtWorkCost.Text = value;
            }
        }

        public string WorkName
        {
            get
            {
                return txtWorkName.Text;
            }
            set
            {
                txtWorkName.Text = value;
            }
        }

        public void Clear()
        {
            WorkName = ""; WorkCost = "";
        }

        public void CloseForm()
        {
            this.Close();
        }

        public void UpdateCmbCaterogy(ArrayList workCategory)
        {
            cmbWorkCategory.DataSource = workCategory;
            cmbWorkCategory.DisplayMember = "getWorkCategoryName";
            cmbWorkCategory.ValueMember = "getWorkCategoryID";
        }

        public void UpdateWorks(DataTable dt)
        {
            dataGridWorks.DataSource = dt;
            dataGridWorks.Columns[0].HeaderText = "Наименование";
            dataGridWorks.Columns[0].Width = 260;
            dataGridWorks.Columns[1].HeaderText = "Стоимость";
            dataGridWorks.Columns[2].HeaderText = "Категория";
            dataGridWorks.Columns[2].Width = 178;

        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            if (ButCancelClick != null) ButCancelClick(this, EventArgs.Empty);
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (ButDeleteClick != null) ButDeleteClick(this, EventArgs.Empty);
        }

        void btnInsert_Click(object sender, EventArgs e)
        {
            if (ButInsertClick != null) ButInsertClick(this, EventArgs.Empty);
        }

        void dataGridWorks_CellClick(object sender, DataGridViewCellEventArgs e)        {            if (e.RowIndex >= 0)            {                DataGridViewRow row = this.dataGridWorks.Rows[e.RowIndex];                WorkName = row.Cells["WorkName"].Value.ToString();                WorkCost = row.Cells["WorkCost"].Value.ToString();            }        }        #region Проброс событий        void WorksFormView_Load(object sender, EventArgs e)        {            if (UpdateGridEvent != null) UpdateGridEvent(this, EventArgs.Empty);            if (UpdateComboWorksEvent != null) UpdateComboWorksEvent(this, EventArgs.Empty);        }        #endregion    }}
