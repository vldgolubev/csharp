﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoserviceCore;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AutoserviceCore
{
    public class Dbconnection
    {
        public MySqlConnection connection;
        #region Connection constructor
        public Dbconnection()
        {
            Initialize();
        }
        private void Initialize()
        {
            string connectionString = AppSettings.Default.MySQL;
            connection = new MySqlConnection(connectionString);


        }
        #endregion
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
               switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");                        
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}