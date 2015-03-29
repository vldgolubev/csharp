using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
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
    }
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

    }
}
