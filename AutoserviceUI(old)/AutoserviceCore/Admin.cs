using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace AutoserviceCore
{
    public interface IAdminInterface
    {
        string GetHash(string password);
        bool InsertAdmin(string login, string password);
        void SelectAdmins(DataGridView dataGridView);
    }
    public class Admin: Dbconnection, IAdminInterface
    {

      public string GetHash(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

        public bool InsertAdmin(string login, string password)
        {
            try
            {
                string query = string.Format("INSERT INTO admin(Login,Password) VALUES('{0}','{1}')", login, GetHash(password));
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    int result = cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    if (result > 0) return true;
                    else return false;
                }
                return false;
            }
            catch (MySqlException)
            {
                return false;
            }
        }


        public void SelectAdmins(DataGridView dataGridView)
        {
            try
            {
                string query = string.Format("SELECT AdminID, Login FROM admin");
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable db = new DataTable();
                    sda.Fill(db);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = db;
                    dataGridView.DataSource = bSource;
                    sda.Update(db);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка извлечения");
            }
        }
    }
}
