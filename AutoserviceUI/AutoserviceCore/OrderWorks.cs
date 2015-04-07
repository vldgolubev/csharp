using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Windows.Forms;

namespace AutoserviceCore
{
    public interface IOrderWorksManager
    {
        DataTable GetOrderData();
        DataTable GetOrderDataByID(int orderid );
        ArrayList GetOrdersList();
        ArrayList GetWorksList(int Work_category_id);
        ArrayList GetWorksCategory();
        bool InsertWork(int orderid, int workid);
        bool IsNotExistWork(int orderid, int workid);
        bool DeleteWorkByID(int orderworkid);
        void UpdateOrderSum(int orderid, decimal ordersum);
       
    }
    
    /* Классы формирования ComboBox*/
    public class AddOrder
    {
        private string Order_description;
        private int Order_id;
        public AddOrder(string description, int id)
        {
            Order_description = description;
            Order_id = id;
        }
        public string Orderdescription
        {
            get { return Order_description; }
        }
        public int Orderid
        {
            get { return Order_id; }
        }
    }
    public class AddWork
    {
        private string Work_name;
        private int Work_id;
        public AddWork(string workname, int workid)
        {
            Work_name = workname;
            Work_id = workid;
        }
        public string Workname{
            get { return Work_name; }
        }
        public int Workid
        {
            get { if (Work_id != 0) return Work_id; else return 1; }
        }
    }
    public class AddOrderWorkCategory
    {
        private string WorkOrderCategoryName;
        private int WorkOrderCategoryID;
        public AddOrderWorkCategory(string workname, int catigoryid)
        {
            WorkOrderCategoryName = workname;
            WorkOrderCategoryID = catigoryid;

        }
        public string getWorkCategoryName
        {
            get { return WorkOrderCategoryName; }
        }
        public int getWorkCategoryID
        {
            get { return WorkOrderCategoryID; }
        }

    }
    /* -------------------------- */


    public class OrderWorks: Dbconnection,IOrderWorksManager
    {
        public DataTable GetOrderDataByID(int orderid){
            DataTable OrdersDt = new DataTable();
            if (this.OpenConnection() == true)
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT ow.OrderWorkID, CONCAT(w.WorkerFn,' ',w.WorkerLn) AS Worker, CONCAT(mark.MarkName,' ',m.ModelName) AS Auto,wrk.WorkName, wrk.WorkCost FROM orderworks AS ow JOIN orders AS o ON ow.OrderID = o.OrderID JOIN workers AS w ON o.WorkerID = w.WorkerID JOIN works AS wrk ON wrk.WorkID = ow.WorkID JOIN ownercars AS owncars ON owncars.OwnerCarID = o.OwnerCarID JOIN models AS m ON m.ModelID = owncars.ModelID JOIN marks AS mark ON m.MarkID = mark.MarkID WHERE ow.OrderID =@orderid";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@orderid",orderid);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    OrdersDt.Load(dr);
                    dr.Close();
                }
                this.CloseConnection();
                return OrdersDt;
            }
            this.CloseConnection();
            return OrdersDt;
        }
        public DataTable GetOrderData()
        {
            DataTable OrdersDt = new DataTable();
            
                if (this.OpenConnection() == true)
                {
                    string query = "SELECT ow.OrderWorkID, CONCAT(w.WorkerFn,' ',w.WorkerLn) AS Worker, CONCAT(mark.MarkName,' ',m.ModelName) AS Auto,wrk.WorkName, wrk.WorkCost FROM orderworks AS ow JOIN orders AS o ON ow.OrderID = o.OrderID JOIN workers AS w ON o.WorkerID = w.WorkerID JOIN works AS wrk ON wrk.WorkID = ow.WorkID JOIN ownercars AS owncars ON owncars.OwnerCarID = o.OwnerCarID JOIN models AS m ON m.ModelID = owncars.ModelID JOIN marks AS mark ON m.MarkID = mark.MarkID";
                 using (MySqlCommand cmd = new MySqlCommand(query, connection))
                 {
                     MySqlDataReader dr = cmd.ExecuteReader();
                     OrdersDt.Load(dr);
                     dr.Close();
                 }
                 this.CloseConnection();
                 return OrdersDt;
                   
                }
            this.CloseConnection();
            return OrdersDt;
        }
        public ArrayList GetOrdersList()
        {
            ArrayList Orders = new ArrayList();
            if (this.OpenConnection() == true)
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT OrderID, CONCAT('Автомобиль: ',mark.MarkName,' ',model.ModelName,' ГРЗ: ',ocars.OwnerNumCar,' Владелец: ',owners.OwnerLn,'.',SUBSTRING(owners.OwnerFn,1,1),'.',SUBSTRING(owners.OwnerPn,1,1)) AS Owner FROM orders AS o JOIN ownercars AS ocars ON o.OwnerCarID = ocars.OwnerCarID JOIN models AS model ON ocars.ModelID = model.ModelID JOIN owners AS owners ON ocars.OwnerID = owners.OwnerID JOIN marks AS mark ON model.MarkID = mark.MarkID";
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Orders.Add(new AddOrder(dr.GetString(1),dr.GetInt32(0)));
                    }
                    this.CloseConnection();
                    return Orders;                   
                }
            }
            this.CloseConnection();
            return Orders;
        }
        public ArrayList GetWorksList(int Work_category_id)
        {
            ArrayList Works = new ArrayList();
            if (this.OpenConnection() == true)
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT WorkID,WorkName FROM works WHERE WorkCategoryID = @workcategoryid";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@workcategoryid", Work_category_id);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Works.Add(new AddWork(dr.GetString(1), dr.GetInt32(0)));
                    }
                }
                this.CloseConnection();
                return Works;
            }

           
         return Works;
        }
        public ArrayList GetWorksCategory()
        {
            ArrayList WorksCategory = new ArrayList();
            if (this.OpenConnection() == true)
            {
                string query = "SELECT WorkCategoryID,WorkCategoryName FROM workcategory";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        WorksCategory.Add(new AddOrderWorkCategory(dr.GetString(1), dr.GetInt32(0)));
                    }
                }
                this.CloseConnection();
                return WorksCategory;
            }
            return WorksCategory;
        }


        public bool InsertWork(int orderid, int workid)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "INSERT INTO orderworks(OrderId,WorkID) VALUES(@orderid,@workid)";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@orderid", orderid);
                        cmd.Parameters.AddWithValue("@workid", workid);
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                this.CloseConnection();
                MessageBox.Show("Ошибка добавления работы!");
                return false;
            }
            return false;
        }


        public bool IsNotExistWork(int orderid, int workid)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "SELECT Count(OrderWorkID) FROM orderworks WHERE OrderID = @orderid AND WorkID = @workid";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@orderid",orderid);
                        cmd.Parameters.AddWithValue("@workid",workid);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0){
                            this.CloseConnection();
                            return true;
                            }
                        this.CloseConnection();
                        return false;

                    }
                }
            }
            catch (Exception)
            {
                this.CloseConnection();
                return false;
            }
            return false;
        }


        public bool DeleteWorkByID(int orderworkid)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "DELETE FROM orderworks WHERE OrderWorkID = @orderworkid";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@orderworkid", orderworkid);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            this.CloseConnection();
                            return true;
                        }
                        this.CloseConnection();
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                this.CloseConnection();
                MessageBox.Show("Ошибка удаления пользователя!");
                return false;
            }
            return false;
        }


        public void UpdateOrderSum(int orderid, decimal ordersum)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "UPDATE orders SET OrderSum = @ordersum WHERE OrderID = @orderid";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@orderid",orderid);
                        cmd.Parameters.AddWithValue("@ordersum",ordersum);
                        cmd.ExecuteNonQuery();
                        
                    }
                }
                this.CloseConnection();
            }
            catch (Exception)
            {
                this.CloseConnection();
                MessageBox.Show("Ошибка обновления суммы заказа!");
            }
        }
    }
}
