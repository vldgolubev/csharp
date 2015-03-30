using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoserviceCore
{
    public interface IModel
    {
        ArrayList GetComboMarks();
        ArrayList GetComboType();
        bool InsertModel(int Mark, string NameModel, int Volume, int Power, int Type );
        void DeleteModel(string modelname);
        DataTable GetAllModels();
    }
    #region Combobox классы
    public class AddMark
    {
        private int MarkID;
        private string MarkName;
        public AddMark(string markname, int markid)
        {
            MarkID = markid;
            MarkName = markname;
        }
        public int Markid
        {
            get { return MarkID; }
        }
        public string Markname
        {
            get { return MarkName; }
        }
    }
    public class AddTypeModel
    {
        private int TypeModelID;
        private string NameType;
        public AddTypeModel(string nametype, int typemodelid)
        {
            TypeModelID = typemodelid;
            NameType = nametype;
        }
        public int Typemodelid
        {
            get { return TypeModelID; }
        }
        public string Nametype
        {
            get { return NameType; }
        }
    }
    #endregion
    public class Model : Dbconnection, IModel
    {
  public ArrayList GetComboMarks()
        {
            ArrayList Marks = new ArrayList();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT MarkID, MarkName FROM marks";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Marks.Add(new AddMark(dr.GetString(1),dr.GetInt32(0)));
                    }
                }    
                
                
            this.CloseConnection();
            return Marks;
            }
            return Marks;
        }
  public ArrayList GetComboType()
  {
      ArrayList TypeModels = new ArrayList();
      if (this.OpenConnection() == true)
      {
          string query = "SELECT TypeModelID,NameType FROM typemodel";
          using (MySqlCommand cmd = new MySqlCommand(query, connection))
          {
              MySqlDataReader dr = cmd.ExecuteReader();
              while (dr.Read())
              {
                  TypeModels.Add(new AddTypeModel(dr.GetString(1),dr.GetInt32(0)));
              }
              
          }

          this.CloseConnection();
          return TypeModels;
      }
      return TypeModels;
  }
  public bool InsertModel(int Mark, string NameModel, int Volume, int Power, int Type)
  {
      try
      {
          if (this.OpenConnection() == true)
          {
              MySqlCommand cmd = new MySqlCommand();
              cmd.Connection = connection;
              cmd.CommandText = "INSERT INTO models(MarkID,ModelName,Volume,Power,Type) VALUES(@Markid,@Modelname,@Volume,@Power,@Type)";
              cmd.Prepare();

              cmd.Parameters.AddWithValue("@Markid",Mark);
              cmd.Parameters.AddWithValue("@Modelname", NameModel);
              cmd.Parameters.AddWithValue("@Volume", Volume);
              cmd.Parameters.AddWithValue("@Power", Power);
              cmd.Parameters.AddWithValue("@Type", Type);

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
  public DataTable GetAllModels()
  {
      DataTable ModelsDt = new DataTable();
      if (this.OpenConnection() == true)
      {
          string query = "SELECT ModelID,ModelName,Volume,Power,MarkName,NameType  FROM models,marks,typemodel WHERE models.MarkID = marks.MarkID AND models.Type = typemodel.TypeModelID";
          using (MySqlCommand cmd = new MySqlCommand(query, connection))
          {
              MySqlDataReader dr = cmd.ExecuteReader();
              ModelsDt.Load(dr);
              dr.Close();
          }
          this.CloseConnection();
          return ModelsDt;
      }
      this.CloseConnection();
      return ModelsDt;
  }
  public void DeleteModel(string modelname)
  {
      try
      {
          if (this.OpenConnection() == true)
          {
              MySqlCommand cmd = new MySqlCommand();
              cmd.Connection = connection;
              cmd.CommandText = "DELETE FROM models WHERE `ModelName` = @modelname";
              cmd.Prepare();

              cmd.Parameters.AddWithValue("@modelname", modelname);
              cmd.ExecuteNonQuery();
              this.CloseConnection();
          }
      }
      catch (Exception)
      {
          MessageBox.Show("Ошибка удаления пользователя!");
      }
  }
    }
}
