﻿using System;using System.Collections;using System.Collections.Generic;using System.ComponentModel;using System.Data;using System.Drawing;using System.Linq;using System.Text;using System.Threading.Tasks;using System.Windows.Forms;namespace AutoserviceUI.View{    public interface IModelInterface    {
        event EventHandler ButCancelModelClick;

        event EventHandler ButDeleteModelClick;

        event EventHandler ButInsertModelClick;

        event EventHandler UpdateGridModel;

        event EventHandler UpdateMarkLoadForm;

        event EventHandler UpdateTypeModelLoadForm;

        string cmbMarkID { get; }

        string cmbTypeModelID { get; }

        string Modelname { get; set; }

        string Power { get; set; }

        string Volume { get; set; }

        void Clear();

        void CloseForm();        void cmbMarkUpdate(ArrayList arrayMarks);        void cmbTypeModelUpdate(ArrayList arrayTypeModels);        void UpdateModel(DataTable dt);    }    public partial class ModelFormView : Form,IModelInterface    {        public ModelFormView()        {            InitializeComponent();            butInsertModel.Click += butInsertModel_Click;            this.Load += ModelForm_Load;            butCancelModel.Click += butCancelModel_Click;            butDeleteModel.Click += butDeleteModel_Click;            dataGridModels.CellClick += dataGridModels_CellClick;        }

        public event EventHandler ButCancelModelClick;

        public event EventHandler ButDeleteModelClick;

        public event EventHandler ButInsertModelClick;

        public event EventHandler UpdateGridModel;

        public event EventHandler UpdateMarkLoadForm;

        public event EventHandler UpdateTypeModelLoadForm;

        public string cmbMarkID
        {
            get { return cmbMark.SelectedValue.ToString(); }
        }

        public string cmbTypeModelID
        {
            get { return cmbTypeModel.SelectedValue.ToString(); }
        }

        public string Modelname
        {
            get
            {
                return textModelName.Text;
            }
            set
            {
                textModelName.Text = value;
            }
        }

        public string Power
        {
            get
            {
                return textPower.Text;
            }
            set
            {
                textPower.Text = value;
            }
        }

        public string Volume
        {
            get
            {
                return textVolume.Text;
            }
            set
            {
                textVolume.Text = value;
            }
        }

        public void Clear()
        {
            textModelName.Text = "";
            textPower.Text = "";
            textVolume.Text = "";
        }

        public void CloseForm()
        {
            this.Close();
        }

        public void cmbMarkUpdate(ArrayList arrayMarks)
        {
            cmbMark.DataSource = arrayMarks;
            cmbMark.DisplayMember = "MarkName";
            cmbMark.ValueMember = "MarkID";
        }

        public void cmbTypeModelUpdate(ArrayList arrayTypeModels)
        {
            cmbTypeModel.DataSource = arrayTypeModels;
            cmbTypeModel.DisplayMember = "NameType";
            cmbTypeModel.ValueMember = "TypeModelID";
        }

        public void UpdateModel(DataTable dt)
        {
            dataGridModels.DataSource = dt;
            dataGridModels.Columns[0].HeaderText = "Идентификатор";
            dataGridModels.Columns[1].HeaderText = "Название модели";
            dataGridModels.Columns[1].Width = 115;
            dataGridModels.Columns[2].HeaderText = "Объем двигателя";
            dataGridModels.Columns[3].HeaderText = "Мощьность двигателя";
            dataGridModels.Columns[4].HeaderText = "Марка";
            dataGridModels.Columns[5].HeaderText = "Тип кузова";
        }

        void butCancelModel_Click(object sender, EventArgs e)
        {
            if (ButCancelModelClick != null) ButCancelModelClick(this, EventArgs.Empty);
        }

        void butDeleteModel_Click(object sender, EventArgs e)
        {
            if (ButDeleteModelClick != null) ButDeleteModelClick(this, EventArgs.Empty);
        }

        void butInsertModel_Click(object sender, EventArgs e)
        {
            if (ButInsertModelClick != null) ButInsertModelClick(this, EventArgs.Empty);
        }

        void dataGridModels_CellClick(object sender, DataGridViewCellEventArgs e)        {            if (e.RowIndex >= 0)            {                DataGridViewRow row = this.dataGridModels.Rows[e.RowIndex];                Modelname = row.Cells["ModelName"].Value.ToString();                Volume = row.Cells["Volume"].Value.ToString();                Power = row.Cells["Power"].Value.ToString();            }        }        #region IModel проброс событий        void ModelForm_Load(object sender, EventArgs e)            {                if (UpdateGridModel != null) UpdateGridModel(this, EventArgs.Empty);                if (UpdateMarkLoadForm != null) UpdateMarkLoadForm(this, EventArgs.Empty);                if (UpdateTypeModelLoadForm != null) UpdateTypeModelLoadForm(this, EventArgs.Empty);            }#endregion        #region IModel аксессоры и очистка        #endregion    }}
