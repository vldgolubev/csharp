using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;

namespace AutoserviceCore
{   public interface IMainInterface{
    int CountUncompleteOrders();
    ArrayList WorkersList();
    }
public class AddWorker
{
    private int Worker_ID;
    private string Worker_FIO;
    public AddWorker(string worker_fio, int worker_id){
        Worker_ID = worker_id;
        Worker_FIO = worker_fio;
    }
    public int Worker_id
    {
        get { return Worker_ID; }
    }
    public string Worker_fio
    {
        get { return Worker_FIO; }
    }
}
    public class Main:Dbconnection,IMainInterface
    {
  
        /* Обновление счетчика невыполненных заказов*/
        public int CountUncompleteOrders()
        {
            if (this.OpenConnection() == true)
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT COUNT(OrderID) AS count FROM orders WHERE DateComplete is NULL";
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    this.CloseConnection();
                    return count;
                }
            }
            return 0;
        }

        /* Запрос на извлечение рабочих*/
        public ArrayList WorkersList()
        {
            ArrayList Workers = new ArrayList();
            if (this.OpenConnection() == true)
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT WorkerID, CONCAT(WorkerFn,' ',SUBSTRING(WorkerLn,1,1),'.',SUBSTRING(WorkerPn,1,1)) AS WorkerFIO FROM workers;";
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Workers.Add(new AddWorker(dr.GetString(1),dr.GetInt32(0)));
                    }
                }
                this.CloseConnection();
                return Workers;
            }   
            return Workers;
        }
    }
}
