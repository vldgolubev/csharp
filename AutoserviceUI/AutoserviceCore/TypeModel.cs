using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using MySql.Data.MySqlClient;using System.Windows.Forms;using System.Data;namespace AutoserviceCore{    public interface ITypeModel    {
        void DeleteTypeModel(string id, string nametype);

        DataTable GetAllTypeModel();

        bool InsertTypeModel(string nametype);    }    public class TypeModel : Dbconnection,ITypeModel{

        public void DeleteTypeModel(string id, string nametype)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM typemodel WHERE `TypeModelID` = @id AND `NameType` = @nametype";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nametype", nametype);

                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка удаления типа кузова!");
            }
        }

        public DataTable GetAllTypeModel()
        {
            DataTable typemodelDt = new DataTable();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT * FROM typemodel";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();

                    typemodelDt.Load(dr);
                    dr.Close();
                }
                this.CloseConnection();
                return typemodelDt;
            }
            return typemodelDt;
        }

        public bool InsertTypeModel(string nametype)        {            try            {                if (this.OpenConnection() == true)                {                    MySqlCommand cmd = new MySqlCommand();                    cmd.Connection = connection;                    cmd.CommandText = "INSERT INTO typemodel(NameType) VALUES (@nametype)";                    cmd.Prepare();                    cmd.Parameters.AddWithValue("@nametype", nametype);                    int result = cmd.ExecuteNonQuery();                    this.CloseConnection();                    if (result > 0) return true;                    else return false;                }                return false;            }            catch (MySqlException)            {                this.CloseConnection();                return false;            }        }    }}
