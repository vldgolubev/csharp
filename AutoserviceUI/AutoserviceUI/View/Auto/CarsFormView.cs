using System;using System.Collections;using System.Collections.Generic;using System.ComponentModel;using System.Data;using System.Drawing;using System.Linq;using System.Text;using System.Threading.Tasks;using System.Windows.Forms;namespace AutoserviceUI.View{    public interface ICarsInterface    {
        event EventHandler ButCancelClickEvent;

        event EventHandler ButDeleteClickEvent;

        event EventHandler ButInsertClickEvent;

        event EventHandler UpdateCarGridViewEvent;

        string CarID { get; set; }

        string cmbModelID { get; }          string cmbOwnerID { get; }
        string Color { get; set; }

        string Number { get; set; }

        void ClearForm();

        void CloseForm();

        void cmbModelUpdate(ArrayList arrayModels);

        void cmbOwnerUpdate(ArrayList arrayOwners);        void UpdateGrid(DataTable dt);    }    public partial class CarsFormView : Form, ICarsInterface    {        public CarsFormView()        {            InitializeComponent();            butCancelCar.Click += butCancelCar_Click;            butInsertCar.Click += butInsertCar_Click;            butDeleteCar.Click += butDeleteCar_Click;            dataGridCars.CellClick += dataGridCars_CellClick;            this.Load += Cars_Load;        }

        public event EventHandler ButCancelClickEvent;

        public event EventHandler ButDeleteClickEvent;

        public event EventHandler ButInsertClickEvent;

        public event EventHandler UpdateCarGridViewEvent;

        public string CarID
        {
            get
            {
                return txtOwnerCarID.Text;
            }
            set
            {
                txtOwnerCarID.Text = value;
            }
        }

        public string cmbModelID
        {
            get { return cmbModel.SelectedValue.ToString(); }
        }

        public string cmbOwnerID
        {
            get { return cmbOwner.SelectedValue.ToString(); }
        }

        public string Color
        {
            get
            {
                return txtColor.Text;
            }
            set
            {
                txtColor.Text = value;
            }
        }

        public string Number
        {
            get
            {
                return txtNumberAuto.Text;
            }
            set
            {
                txtNumberAuto.Text = value;
            }
        }

        public void ClearForm()
        {
            txtColor.Text = "";
            txtNumberAuto.Text = "";
            txtOwnerCarID.Text = "";
        }

        public void CloseForm()
        {
            this.Close();
        }

        public void cmbModelUpdate(ArrayList arrayModels)
        {
            cmbModel.DataSource = arrayModels;
            cmbModel.DisplayMember = "Modelname";
            cmbModel.ValueMember = "Modelid";
        }

        public void cmbOwnerUpdate(ArrayList arrayOwners)
        {
            cmbOwner.DataSource = arrayOwners;
            cmbOwner.DisplayMember = "Ownerfio";
            cmbOwner.ValueMember = "Ownerid";
        }

        public void UpdateGrid(DataTable dt)
        {
            dataGridCars.DataSource = dt;
            dataGridCars.Columns[0].Visible = false;
            dataGridCars.Columns[1].HeaderText = "Марка";
            dataGridCars.Columns[2].HeaderText = "Модель";
            dataGridCars.Columns[3].HeaderText = "Цвет";
            dataGridCars.Columns[4].HeaderText = "Владелец";
            dataGridCars.Columns[4].Width = 190;
            dataGridCars.Columns[5].HeaderText = "ГРЗ";
            dataGridCars.Columns[6].HeaderText = "Объем двигателя";
            dataGridCars.Columns[7].HeaderText = "Мощность";
        }

        void butCancelCar_Click(object sender, EventArgs e)
        {
            if (ButCancelClickEvent != null) ButCancelClickEvent(this, EventArgs.Empty);
        }

        void butDeleteCar_Click(object sender, EventArgs e)
        {
            if (ButDeleteClickEvent != null) ButDeleteClickEvent(this, EventArgs.Empty);
        }

        void butInsertCar_Click(object sender, EventArgs e)
        {
            if (ButInsertClickEvent != null) ButInsertClickEvent(this, EventArgs.Empty);
        }

        void Cars_Load(object sender, EventArgs e)
        {
            if (UpdateCarGridViewEvent != null) UpdateCarGridViewEvent(this, EventArgs.Empty);
        }

        void dataGridCars_CellClick(object sender, DataGridViewCellEventArgs e)        {            if (e.RowIndex >= 0)            {                DataGridViewRow row = this.dataGridCars.Rows[e.RowIndex];                CarID = row.Cells["OwnerCarID"].Value.ToString();            }        }        #region Проброс событий        #endregion    }}
