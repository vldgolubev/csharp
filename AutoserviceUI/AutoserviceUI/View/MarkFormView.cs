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
    public interface IMarkInterface
    {
        void DataClear();
        string MarkID { get; set; }
        string MarkName { get; set; }
        string Country { get; set; }
        void CloseForm();
        void UpdateMark(DataTable dt);
        event EventHandler butInsertMarkClick;
        event EventHandler butCancelMarkClick;
        event EventHandler butDeleteMarkClick;
        event EventHandler DataGridMarkUpdate;
    }
    public partial class MarkFormView : Form, IMarkInterface
    {
        public MarkFormView()
        {
            InitializeComponent();
            this.Load += MarkForm_Load;
            butCancelMark.Click += butCancelMark_Click;
            butDeleteMark.Click += butDeleteMark_Click;
            butInsertMark.Click += butInsertMark_Click;
            dataGridMark.CellClick += dataGridMark_CellContentClick;
        }

        void dataGridMark_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridMark.Rows[e.RowIndex];
                MarkID = row.Cells["MarkID"].Value.ToString();
                MarkName = row.Cells["MarkName"].Value.ToString();
                Country = row.Cells["Country"].Value.ToString();
            }
        }

        void MarkForm_Load(object sender, EventArgs e)
        {
            if (DataGridMarkUpdate != null) DataGridMarkUpdate(this, EventArgs.Empty);
        }
        #region Проброс событий
        void butInsertMark_Click(object sender, EventArgs e)
        {
            if (butInsertMarkClick != null) butInsertMarkClick(this, EventArgs.Empty);
        }

        void butDeleteMark_Click(object sender, EventArgs e)
        {
            if (butDeleteMarkClick != null) butDeleteMarkClick(this, EventArgs.Empty);
        }

        void butCancelMark_Click(object sender, EventArgs e)
        {
            if (butCancelMarkClick != null) butCancelMarkClick(this, EventArgs.Empty);
        }
        public event EventHandler butInsertMarkClick;
        public event EventHandler butCancelMarkClick;
        public event EventHandler butDeleteMarkClick;
        #endregion
        #region Свойства Edit
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
        #endregion
        public void DataClear(){
            MarkID = "";
            MarkName = "";
            Country = "";
        }


        public void UpdateMark(DataTable dt)
        {
            dataGridMark.DataSource = dt;
        }


        public event EventHandler DataGridMarkUpdate;


        public void CloseForm()
        {
            this.Close();
        }
    }
}
