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
        void DeleteAdmin(string id, string login);
        DataTable GetAllAdmins();
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
               
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO admin(Login,Password) VALUES(@Login,@Password)";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@Login", login);
                    cmd.Parameters.AddWithValue("@Password", password);

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
        public DataTable GetAllAdmins()
        {
            DataTable adminDt = new DataTable();
            if (this.OpenConnection() == true)
            {
                
                string query = "Select AdminID,Login FROM admin";
                using (MySqlCommand cmd = new MySqlCommand(query,connection))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    
                    adminDt.Load(dr);
                    dr.Close();
                }
                this.CloseConnection();
                return adminDt;
            }
            return adminDt;
        }


        public void DeleteAdmin(string id, string login)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM admin WHERE `AdminID` = @id AND `Login` = @login";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
                } catch(Exception){
                   MessageBox.Show("Ошибка удаления пользователя!");
                }
            }
    }
}
