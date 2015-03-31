using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace AutoserviceCore
{
    public interface IWorksInterface
    {
        bool InsertWork(string workname, double workcost, int workcategoryid);
        void DeleteWork(string workname);
        ArrayList getComboWorksCategory();
        DataTable GetAllWorks();
    }
    public class AddWorkCategory
    {
        private string WorkCategoryName;
        private int WorkCategoryID;
        public AddWorkCategory(string workname, int catigoryid)
        {
            WorkCategoryName = workname;
            WorkCategoryID = catigoryid;
            
        }
        public string getWorkCategoryName
        {
            get { return WorkCategoryName; }
        }
        public int getWorkCategoryID
        {
            get { return WorkCategoryID; }
        }
        
    }
    public class Works : Dbconnection, IWorksInterface
    {
        public bool InsertWork(string workname, double workcost, int workcategoryid)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO works(WorkName,WorkCost,WorkCategoryID) VALUES(@workname,@workcost,@workcategoryid)";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@workname", workname);
                    cmd.Parameters.AddWithValue("@workcost", workcost);
                    cmd.Parameters.AddWithValue("@workcategoryid", workcategoryid);

                    int result = cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    if (result > 0) return true;
                    else return false;
                }
                return false;
            }
            catch (MySqlException)
            {
                this.CloseConnection();
                MessageBox.Show("Ошибка дбавления работы!");
                return false;
            }
        }
        public void DeleteWork(string workname)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM works WHERE `WorkName` = @workname";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@workname", workname);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка удаления категории!");
            }
        }

        public DataTable GetAllWorks()
        {
            DataTable WorksDt = new DataTable();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT WorkName,WorkCost, WorkCategoryName FROM works,workcategory WHERE works.WorkCategoryID = workcategory.WorkCategoryID";
                using(MySqlCommand cmd = new MySqlCommand(query,connection))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    WorksDt.Load(dr);
                    dr.Close();
                }
                this.CloseConnection();
                return WorksDt;
            }
            
            return WorksDt;
        }
        public ArrayList getComboWorksCategory()
        {
            ArrayList WorksCategory = new ArrayList();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT WorkCategoryID,WorkCategoryName FROM workcategory";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        WorksCategory.Add(new AddWorkCategory(dr.GetString(1),dr.GetInt32(0)));
                    }
                }
                this.CloseConnection();
                return WorksCategory;
            }
             return WorksCategory;
        }
    }
}
