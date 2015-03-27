﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AutoserviceCore
{
    public interface IMarkInterface
    {
        bool InsertMark(string markname, string country);
        void DeleteMark(string id, string markname);
        DataTable GetAllMarks();
    }
    public class Mark : Dbconnection, IMarkInterface
    {

        public bool InsertMark(string markname, string country)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO marks(MarkName,Country) VALUES(@markname,@country)";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@markname", markname);
                    cmd.Parameters.AddWithValue("@country", country);

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

        public void DeleteMark(string id, string markname)
        {
            try 
            { 
                if(this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM marks WHERE `MarkID` = @id AND `MarkName` = @markname";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@markname", markname);

                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка удаления марки!");
            }
        }

        public DataTable GetAllMarks()
        {
            DataTable markDt = new DataTable();
            if (this.CloseConnection() == true)
            {
                string query = "SELECT * FROM marks";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();

                    markDt.Load(dr);
                    dr.Close();
                }
                this.CloseConnection();
                return markDt;
            }
            return markDt;
        }
    }
}
