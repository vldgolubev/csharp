using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AutoserviceCore
{   public interface IMainInterface{
    void InsertOrder();
    int CountUncompleteOrders();
    }
    public class Main:Dbconnection,IMainInterface
    {
        public void InsertOrder()
        {
            throw new NotImplementedException();
        }


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
    }
}
