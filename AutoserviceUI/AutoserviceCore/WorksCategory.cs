using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace AutoserviceCore
{
    public interface IWorksCategory
    {
        bool InsertWorkCategory(string categoryName);
        void DeleteWorkCategory(string categoryName);
        DataTable GetAllCategory();
    }
    public class WorksCategory: Dbconnection, IWorksCategory
    {
        public bool InsertWorkCategory(string categoryName)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO workcategory(WorkCategoryName) VALUES(@Categoryname)";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@Categoryname", categoryName);

                    int result = cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    if(result > 0)return true;
                    else return false;
                }
                return false;
            }
            catch (MySqlException)
            {
            this.CloseConnection();
            return false;
            }
        }
        public void DeleteWorkCategory(string categoryName)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM workcategory WHERE `WorkCategoryName` = @Workcategoryname";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@Workcategoryname", categoryName);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошиька удаления категории!");
            }
        }
        public DataTable GetAllCategory()
        {
            DataTable categoryDt = new DataTable();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT WorkCategoryName FROM workcategory";
                using(MySqlCommand cmd = new MySqlCommand(query,connection)){
                    MySqlDataReader dr = cmd.ExecuteReader();
                    categoryDt.Load(dr);
                    dr.Close();

                }
                this.CloseConnection();
                return categoryDt;
            }
            return categoryDt;
        }
    }
}
