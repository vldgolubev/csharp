using System;using System.Collections.Generic;using System.Data;using System.Linq;using System.Text;using System.Threading.Tasks;using MySql.Data.MySqlClient;using System.Windows.Forms;namespace AutoserviceCore{    public interface IClient    {
        void DeleteClient(string lastname, string firstname, string fathname, string passport);

        DataTable GetAllClients();

        bool InsertClient(string lastname, string firstname, string fathname, string passport, string address, string phone);    }    public class Client : Dbconnection,IClient    {

        public void DeleteClient(string lastname, string firstname, string fathname, string passport)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM owners WHERE OwnerLn = @ownerln AND OwnerFn = @ownerfn AND OwnerPn = @ownerpn AND OwnerPassport = @ownerpassport";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@ownerln", lastname);
                    cmd.Parameters.AddWithValue("@ownerfn", firstname);
                    cmd.Parameters.AddWithValue("@ownerpn", fathname);
                    cmd.Parameters.AddWithValue("@ownerpassport", passport);

                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
            catch (Exception)
            {
                this.CloseConnection();
                MessageBox.Show("Ошибка удаления клиента!");
            }
        }

        public DataTable GetAllClients()
        {
            DataTable clientsDt = new DataTable();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT OwnerLn,OwnerFn,OwnerPn,OwnerPassport,OwnerAddress,OwnerPhone FROM owners";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    clientsDt.Load(dr);
                    dr.Close();
                }

                this.CloseConnection();
                return clientsDt;
            }
            return clientsDt;
        }

        public bool InsertClient(string lastname, string firstname, string fathname, string passport, string address, string phone)        {           try           {               if (this.OpenConnection() == true)               {                   MySqlCommand cmd = new MySqlCommand();                   cmd.Connection = connection;                   cmd.CommandText = "INSERT INTO owners(OwnerLn, OwnerFn, OwnerPn, OwnerPassport, OwnerAddress, OwnerPhone) VALUES (@ownerln, @ownerfn, @ownerpn, @ownerpassport, @owneraddress,@ownerphone)";                   cmd.Prepare();                   cmd.Parameters.AddWithValue("@ownerln", lastname);                   cmd.Parameters.AddWithValue("@ownerfn", firstname);                   cmd.Parameters.AddWithValue("@ownerpn", fathname);                   cmd.Parameters.AddWithValue("@ownerpassport", passport);                   cmd.Parameters.AddWithValue("@owneraddress", address);                   cmd.Parameters.AddWithValue("@ownerphone", phone);                   int result = cmd.ExecuteNonQuery();                   this.CloseConnection();                   if (result > 0) return true;                   else return false;               }               return false;           }           catch (MySqlException ex)           {               this.CloseConnection();               switch (ex.Number)               {                   case 1062: MessageBox.Show("Клиент уже существует!");                       break;               }               return false;           }        }    }}
