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
    public interface ISearchAutoView{
        string Searchtypename { get; }
        string Selectedautoname { get; set; }
        string Searchvalue { get; }
        int AutoSelectedID { get; set; }
        void UpdateDataGrid(DataTable dt);
        event EventHandler UpdateDataGridSearch;

    }
    public partial class SearchAutoView : Form,ISearchAutoView
    {
        private string SearchTypeName;
        private string SearchValue;
        private string SelectedAutoName;
        private int SelectedID;
        public int AutoSelectedID {
            get { return SelectedID; }
            set { SelectedID = value; }
        }
        public string Selectedautoname
        {
            get { return SelectedAutoName;}
            set{SelectedAutoName = value;}
        }
        public SearchAutoView(string type, string value)
        {
            SearchTypeName = type;
            SearchValue = value;
            InitializeComponent();
            this.Load += SearchAutoView_Load;
            dataGridSearchAuto.CellClick += dataGridSearchAuto_CellClick;
            butAccept.Click += butAccept_Click;
        }

        void butAccept_Click(object sender, EventArgs e)
        {
            if (AutoSelectedID == 0) MessageBox.Show("Пожалуйста, выберите автомобиль!");
        }

        void dataGridSearchAuto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridSearchAuto.Rows[e.RowIndex];
                AutoSelectedID = Convert.ToInt32(row.Cells["OwnerCarID"].Value);
                Selectedautoname = row.Cells["Auto"].Value.ToString()+" ГРЗ: "+row.Cells["OwnerNumCar"].Value.ToString();
            }
        }

        void SearchAutoView_Load(object sender, EventArgs e)
        {
            if (UpdateDataGridSearch != null) UpdateDataGridSearch(this, EventArgs.Empty);
        }



        public string Searchtypename
        {
            get { return SearchTypeName; }
        }

        public string Searchvalue
        {
            get { return SearchValue; }
        }


        public event EventHandler UpdateDataGridSearch;


        public void UpdateDataGrid(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                dataGridSearchAuto.DataSource = dt;
                dataGridSearchAuto.Columns[0].Visible = true;
                dataGridSearchAuto.Columns[0].HeaderText = "ID";
                dataGridSearchAuto.Columns[1].HeaderText = "Автомобиль";
                dataGridSearchAuto.Columns[2].HeaderText = "ГРЗ";
                dataGridSearchAuto.Columns[3].HeaderText = "Цвет";
            }
            else MessageBox.Show("Автомобиля с таким данными нет в БД!");
        }


        //public string Selectedautoname
        //{
        //    get
        //    {
        //        return SelectedAutoName;
        //    }
        //    set
        //    {
        //        SelectedAutoName = value;
        //    }
        //}
    }
}
