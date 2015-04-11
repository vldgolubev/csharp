using System;using System.Collections.Generic;using System.ComponentModel;using System.Data;using System.Drawing;using System.Linq;using System.Text;using System.Threading.Tasks;using System.Windows.Forms;namespace AutoserviceUI.View{    public interface IMarkInterface    {
        event EventHandler butCancelMarkClick;

        event EventHandler butDeleteMarkClick;

        event EventHandler butInsertMarkClick;

        event EventHandler DataGridMarkUpdate;

        string Country { get; set; }

        string MarkID { get; set; }

        string MarkName { get; set; }

        void CloseForm();

        void DataClear();        void UpdateMark(DataTable dt);    }    public partial class MarkFormView : Form, IMarkInterface    {        public MarkFormView()        {            InitializeComponent();            this.Load += MarkForm_Load;            butCancelMark.Click += butCancelMark_Click;            butDeleteMark.Click += butDeleteMark_Click;            butInsertMark.Click += butInsertMark_Click;            dataGridMark.CellClick += dataGridMark_CellContentClick;        }

        public event EventHandler butCancelMarkClick;

        public event EventHandler butDeleteMarkClick;

        public event EventHandler butInsertMarkClick;

        public event EventHandler DataGridMarkUpdate;

        public string Country
        {
            get
            {
                return textMarkCountry.Text;
            }
            set
            {
                textMarkCountry.Text = value;
            }
        }

        public string MarkID
        {
            get
            {
                return textMarkID.Text;
            }
            set
            {
                textMarkID.Text = value;
            }
        }

        public string MarkName
        {
            get
            {
                return textMarkName.Text;
            }
            set
            {
                textMarkName.Text = value;
            }
        }

        public void CloseForm()
        {
            this.Close();
        }

        public void DataClear()
        {
            MarkID = "";
            MarkName = "";
            Country = "";
        }

        public void UpdateMark(DataTable dt)
        {
            dataGridMark.DataSource = dt;
            dataGridMark.Columns[0].HeaderText = "Идентификатор";
            dataGridMark.Columns[1].HeaderText = "Название марки";
            dataGridMark.Columns[1].Width = 140;
            dataGridMark.Columns[1].HeaderText = "Страна";
            dataGridMark.Columns[2].Width = 140;
        }

        void butCancelMark_Click(object sender, EventArgs e)
        {
            if (butCancelMarkClick != null) butCancelMarkClick(this, EventArgs.Empty);
        }

        void butDeleteMark_Click(object sender, EventArgs e)
        {
            if (butDeleteMarkClick != null) butDeleteMarkClick(this, EventArgs.Empty);
        }

        void butInsertMark_Click(object sender, EventArgs e)
        {
            if (butInsertMarkClick != null) butInsertMarkClick(this, EventArgs.Empty);
        }

        void dataGridMark_CellContentClick(object sender, DataGridViewCellEventArgs e)        {            if (e.RowIndex >= 0)            {                DataGridViewRow row = this.dataGridMark.Rows[e.RowIndex];                MarkID = row.Cells["MarkID"].Value.ToString();                MarkName = row.Cells["MarkName"].Value.ToString();                Country = row.Cells["Country"].Value.ToString();            }        }        void MarkForm_Load(object sender, EventArgs e)        {            if (DataGridMarkUpdate != null) DataGridMarkUpdate(this, EventArgs.Empty);        }        #region Проброс событий        #endregion        #region Свойства Edit        #endregion    }}
