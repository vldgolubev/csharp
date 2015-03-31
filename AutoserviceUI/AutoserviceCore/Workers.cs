using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AutoserviceCore
{
    public interface IWorkersInterface
    {
        bool InsertWorker(string laststname, string firstname, string fathname, string passport, string address, string phone );
        void DeleteWorker(string lastname, string firstname, string fathname, string passport);
        DataTable GetAllWorkers();
    }
    public class Workers:Dbconnection, IWorkersInterface
    {
        public bool InsertWorker(string laststname, string firstname, string fathname, string passport, string address, string phone)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO workers(WorkerLn, WorkerFn, WorkerPn, WorkerPassport, WorkerAddress, WorkerPhone) VALUES (@workerln, @workerfn, @workerpn, @workerpassport, @workeraddress,@workerphone)";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@workerln",laststname);
                    cmd.Parameters.AddWithValue("@workerfn",firstname);
                    cmd.Parameters.AddWithValue("@workerpn",fathname);
                    cmd.Parameters.AddWithValue("@workerpassport",passport);
                    cmd.Parameters.AddWithValue("@workeraddress",address);
                    cmd.Parameters.AddWithValue("@workerphone",phone);

                    int result = cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    if (result > 0) return true;
                    else return false;
                }
                return false;
            }
            catch (MySqlException ex) {
                this.CloseConnection();
                switch (ex.Number)
                {
                    case 1062: MessageBox.Show("Такой Номер паспорта или Телефон уже существуют!");
                        break;
                }
                return false;
            }
        }

        public void DeleteWorker(string lastname, string firstname, string fathname, string passport)
        {
            try {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM workers WHERE WorkerLn = @workerln AND WorkerFn = @workerfn AND WorkerPn = @workerpn AND WorkerPassport = @workerpassport";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@workerln", lastname);
                    cmd.Parameters.AddWithValue("@workerfn", firstname);
                    cmd.Parameters.AddWithValue("@workerpn", fathname);
                    cmd.Parameters.AddWithValue("@workerpassport", passport);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
                }
            catch (Exception)
            {
                MessageBox.Show("Ошибка удаления рабочего!");
            }
        }

        public DataTable GetAllWorkers()
        {
            DataTable workersDt = new DataTable();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT WorkerLn, WorkerFn, WorkerPn, WorkerPassport, WorkerAddress, WorkerPhone FROM workers";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    workersDt.Load(dr);
                    dr.Close();
                }
                this.CloseConnection();
                return workersDt;
            }
            return workersDt;
        }
    }
}
