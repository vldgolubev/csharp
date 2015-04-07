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

namespace AutoserviceUI.View
{
    public interface ICarsInterface
    {
        string cmbModelID { get; }  
        string cmbOwnerID { get; }
        void cmbOwnerUpdate(ArrayList arrayOwners);
        void cmbModelUpdate(ArrayList arrayModels);
        string CarID { get; set; }
        string Color { get; set; }
        string Number { get; set; }
        void UpdateGrid(DataTable dt);
        void ClearForm();
        void CloseForm();
        event EventHandler ButInsertClickEvent;
        event EventHandler ButCancelClickEvent;
        event EventHandler ButDeleteClickEvent;
        event EventHandler UpdateCarGridViewEvent;
    }
    public partial class CarsFormView : Form, ICarsInterface
    {
        public CarsFormView()
        {
            InitializeComponent();
            butCancelCar.Click += butCancelCar_Click;
            butInsertCar.Click += butInsertCar_Click;
            butDeleteCar.Click += butDeleteCar_Click;
            dataGridCars.CellClick += dataGridCars_CellClick;
            this.Load += Cars_Load;
        }

        void dataGridCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridCars.Rows[e.RowIndex];
                CarID = row.Cells["OwnerCarID"].Value.ToString();
            }
        }
        #region Проброс событий
        void Cars_Load(object sender, EventArgs e)
        {
            if (UpdateCarGridViewEvent != null) UpdateCarGridViewEvent(this, EventArgs.Empty);
        }
        void butDeleteCar_Click(object sender, EventArgs e)
        {
            if (ButDeleteClickEvent != null) ButDeleteClickEvent(this, EventArgs.Empty);
        }
        void butInsertCar_Click(object sender, EventArgs e)
        {
            if (ButInsertClickEvent != null) ButInsertClickEvent(this, EventArgs.Empty);
        }
        void butCancelCar_Click(object sender, EventArgs e)
        {
            if (ButCancelClickEvent != null) ButCancelClickEvent(this, EventArgs.Empty);
        }
        public event EventHandler ButInsertClickEvent;
        public event EventHandler ButCancelClickEvent;
        public event EventHandler ButDeleteClickEvent;
        public event EventHandler UpdateCarGridViewEvent;
        #endregion
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
        public void cmbOwnerUpdate(ArrayList arrayOwners)
        {
            cmbOwner.DataSource = arrayOwners;
            cmbOwner.DisplayMember = "Ownerfio";
            cmbOwner.ValueMember = "Ownerid";
        }
        public void cmbModelUpdate(ArrayList arrayModels)
        {
            cmbModel.DataSource = arrayModels;
            cmbModel.DisplayMember = "Modelname";
            cmbModel.ValueMember = "Modelid";
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
    }
}
