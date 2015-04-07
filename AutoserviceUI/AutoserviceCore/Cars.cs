using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AutoserviceCore
{
    public interface ICarsManager
    {
        bool InsertCar(string ownerid, string modelid, string color, string number);
        void DeleteCar(string ownercarid);
        ArrayList GetOwnerList();
        ArrayList GetModelList();
        DataTable GetAllCars();
    }
    public class AddOwner
    {
        private int OwnerID;
        private string OwnerFIO;
        public AddOwner(string ownerfio, int ownerid)
        {
            OwnerID = ownerid;
            OwnerFIO = ownerfio;
        }
        public int Ownerid
        {
            get { return OwnerID; }
        }
        public string Ownerfio
        {
            get { return OwnerFIO; }
        }

    }
    public class AddModel
    {
        private int ModelID;
        private string ModelName;
        public AddModel(string modelname, int modelid)
        {
            ModelID = modelid;
            ModelName = modelname;
        }
        public int Modelid
        {
            get { return ModelID; }
        }
        public string Modelname
        {
            get { return ModelName; }
        }
    }
    public class Cars : Dbconnection, ICarsManager
    {
        public bool InsertCar(string ownerid, string modelid, string color, string number)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO ownercars(OwnerID,ModelID,OwnerCarLolor,OwnerNumCar) VALUES(@ownerid,@modelid,@color,@number)";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@ownerid",ownerid);
                    cmd.Parameters.AddWithValue("@modelid",modelid);
                    cmd.Parameters.AddWithValue("@color",color);
                    cmd.Parameters.AddWithValue("@number",number);

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
                return false;
            }
        }

        public void DeleteCar(string ownercarid)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM ownercars WHERE OwnerCarID = @ownercarid";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@ownercarid", ownercarid);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка удаления автомобиля!");
            }
        }

        public ArrayList GetOwnerList()
        {
            ArrayList Owners = new ArrayList();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT OwnerID, CONCAT(OwnerLn,' ',OwnerFn,' ',OwnerPn) AS OwnerFIO FROM owners";
                using (MySqlCommand cmd = new MySqlCommand(query,connection))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Owners.Add(new AddOwner(dr.GetString(1),dr.GetInt32(0)));
                    }
                }
                this.CloseConnection();
                return Owners;
            }
            return Owners;
        }

        public ArrayList GetModelList()
        {
            ArrayList Models = new ArrayList();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT ModelID, CONCAT(MarkName,' -> ',ModelName) AS Mark FROM models JOIN marks ON models.MarkID = marks.MarkID GROUP BY MarkName ASC";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Models.Add(new AddModel(dr.GetString(1),dr.GetInt32(0)));
                    }
                }
                this.CloseConnection();
                return Models;
            }
            return Models;
        }

        public DataTable GetAllCars()
        {
            DataTable CarsDt = new DataTable();
            if(this.OpenConnection() == true)
            {
                string query = "SELECT OwnerCarID,MarkName,ModelName,OwnerCarLolor,CONCAT(OwnerLn,' ',OwnerFn,' ',OwnerPn) AS FIO,OwnerNumCar,Volume,Power FROM owners AS o JOIN ownercars AS oc JOIN models AS m JOIN marks AS mr ON o.OwnerID = oc.OwnerID AND oc.ModelID = m.ModelID AND m.MarkID = mr.MarkID";
            using(MySqlCommand cmd = new MySqlCommand(query,connection))
            {
                MySqlDataReader dr = cmd.ExecuteReader();
                CarsDt.Load(dr);
                dr.Close();
            }
            this.CloseConnection();
            return CarsDt;
            }
            this.CloseConnection();
            return CarsDt;
        }

    }
}
