using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using MySql.Data.MySqlClient;using System.Data;using System.Collections;using System.Windows.Forms;/* Класс для общения БД с Главной формой*/namespace AutoserviceCore{   public interface IMainInterface{
    bool CompleteOrder(int orderid, string datadime);

    int CountUncompleteOrders();
    bool DeleteOrder(int orderid);

    DataTable GetAllCompleteOrders();

    DataTable GetAllOrders();

    DataTable GetAllOrdersByCarNumber(string carnumber);

    DataTable GetAllOrdersByMarkAuto(string markauto);

    DataTable GetAllOrdersByOwner(string lastname);

    DataTable GetAllOrdersByWorker(string workername);

    DataTable GetAllUnCompleteOrders();

    bool InsertOrder(int workerid, int ownercarid);

    ArrayList WorkersList();    }public class AddWorker{
    private string Worker_FIO;
    private int Worker_ID;    public AddWorker(string worker_fio, int worker_id){        Worker_ID = worker_id;        Worker_FIO = worker_fio;    }
    public string Worker_fio
    {
        get { return Worker_FIO; }
    }

    public int Worker_id    {        get { return Worker_ID; }    }}    public class Main:Dbconnection,IMainInterface    {          /* Обновление счетчика невыполненных заказов*/
        public bool CompleteOrder(int orderid, string datatime)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "UPDATE orders SET DateComplete = @datatime WHERE OrderID = @orderid";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@datatime", datatime);
                        cmd.Parameters.AddWithValue("@orderid", orderid);
                        int affectedRows = cmd.ExecuteNonQuery();
                        if (affectedRows > 0) MessageBox.Show("Заказ успешно обновлен!");
                        this.CloseConnection();
                        return true;
                    }
                }
                this.CloseConnection();
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка обновления заказа!");
                this.CloseConnection();
                return false;
            }
        }

        public int CountUncompleteOrders()        {            if (this.OpenConnection() == true)            {                using (MySqlCommand cmd = new MySqlCommand())                {                    cmd.Connection = connection;                    cmd.CommandText = "SELECT COUNT(OrderID) AS count FROM orders WHERE DateComplete is NULL";                    int count = Convert.ToInt32(cmd.ExecuteScalar());                    this.CloseConnection();                    return count;                }            }            return 0;        }        /* Запрос на извлечение рабочих*/
        public bool DeleteOrder(int orderid)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "DELETE FROM orders WHERE OrderID = @orderid";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@orderid", orderid);
                        int affectedRows = cmd.ExecuteNonQuery();
                        if (affectedRows > 0) MessageBox.Show("Заказ успешно удален!");
                        this.CloseConnection();
                        return true;
                    }
                }
                this.CloseConnection();
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка удаления заказа!");
                this.CloseConnection();
                return false;
            }
        }

        public DataTable GetAllCompleteOrders()
        {
            DataTable OrdersDt = new DataTable();
            if (this.OpenConnection() == true)
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT o.OrderID,CONCAT(worker.WorkerFn,' ',SUBSTRING(worker.WorkerLn,1,1),'.',SUBSTRING(worker.WorkerPn,1,1)) AS Worker,CONCAT(mark.MarkName,' ',model.ModelName) AS Auto,CONCAT(own.OwnerLn,' ',SUBSTRING(own.OwnerFn,1,1),'.',SUBSTRING(own.OwnerPn,1,1)) AS Owner,ocars.OwnerNumCar,CONCAT(o.OrderSum,' руб')AS OrderSum,o.DateCreate,o.DateComplete FROM orders AS o JOIN workers AS worker ON o.WorkerID = worker.WorkerID JOIN ownercars AS ocars ON o.OwnerCarID = ocars.OwnerCarID JOIN models AS model ON model.ModelID = ocars.ModelID JOIN marks AS mark ON mark.MarkID = model.MarkID JOIN owners AS own ON own.OwnerID = ocars.OwnerID where o.DateComplete is not null";
                    MySqlDataReader dt = cmd.ExecuteReader();
                    OrdersDt.Load(dt);
                    dt.Close();

                }
                this.CloseConnection();
                return OrdersDt;
            }
            this.CloseConnection();
            return OrdersDt;
        }

        public DataTable GetAllOrders()
        {
            DataTable OrdersDt = new DataTable();
            if (this.OpenConnection() == true)
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT o.OrderID,CONCAT(worker.WorkerFn,' ',SUBSTRING(worker.WorkerLn,1,1),'.',SUBSTRING(worker.WorkerPn,1,1)) AS Worker,CONCAT(mark.MarkName,' ',model.ModelName) AS Auto,CONCAT(own.OwnerLn,' ',SUBSTRING(own.OwnerFn,1,1),'.',SUBSTRING(own.OwnerPn,1,1)) AS Owner,ocars.OwnerNumCar,CONCAT(o.OrderSum,' руб')AS OrderSum,o.DateCreate,o.DateComplete FROM orders AS o JOIN workers AS worker ON o.WorkerID = worker.WorkerID JOIN ownercars AS ocars ON o.OwnerCarID = ocars.OwnerCarID JOIN models AS model ON model.ModelID = ocars.ModelID JOIN marks AS mark ON mark.MarkID = model.MarkID JOIN owners AS own ON own.OwnerID = ocars.OwnerID";
                    MySqlDataReader dt = cmd.ExecuteReader();
                    OrdersDt.Load(dt);
                    dt.Close();

                }
                this.CloseConnection();
                return OrdersDt;
            }
            this.CloseConnection();
            return OrdersDt;
        }

        public DataTable GetAllOrdersByCarNumber(string carnumber)
        {
            DataTable OrdersDt = new DataTable();
            if (this.OpenConnection() == true)
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT o.OrderID,CONCAT(worker.WorkerFn,' ',SUBSTRING(worker.WorkerLn,1,1),'.',SUBSTRING(worker.WorkerPn,1,1)) AS Worker,CONCAT(mark.MarkName,' ',model.ModelName) AS Auto,CONCAT(own.OwnerLn,' ',SUBSTRING(own.OwnerFn,1,1),'.',SUBSTRING(own.OwnerPn,1,1)) AS Owner,ocars.OwnerNumCar,CONCAT(o.OrderSum,' руб')AS OrderSum,o.DateCreate,o.DateComplete FROM orders AS o JOIN workers AS worker ON o.WorkerID = worker.WorkerID JOIN ownercars AS ocars ON o.OwnerCarID = ocars.OwnerCarID JOIN models AS model ON model.ModelID = ocars.ModelID JOIN marks AS mark ON mark.MarkID = model.MarkID JOIN owners AS own ON own.OwnerID = ocars.OwnerID where ocars.OwnerNumCar = @carnumber";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@carnumber", carnumber);

                    MySqlDataReader dt = cmd.ExecuteReader();
                    OrdersDt.Load(dt);
                    dt.Close();

                }
                this.CloseConnection();
                return OrdersDt;
            }
            this.CloseConnection();
            return OrdersDt;
        }

        public DataTable GetAllOrdersByMarkAuto(string markauto)
        {
            DataTable OrdersDt = new DataTable();
            if (this.OpenConnection() == true)
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT o.OrderID,CONCAT(worker.WorkerFn,' ',SUBSTRING(worker.WorkerLn,1,1),'.',SUBSTRING(worker.WorkerPn,1,1)) AS Worker,CONCAT(mark.MarkName,' ',model.ModelName) AS Auto,CONCAT(own.OwnerLn,' ',SUBSTRING(own.OwnerFn,1,1),'.',SUBSTRING(own.OwnerPn,1,1)) AS Owner,ocars.OwnerNumCar,CONCAT(o.OrderSum,' руб')AS OrderSum,o.DateCreate,o.DateComplete FROM orders AS o JOIN workers AS worker ON o.WorkerID = worker.WorkerID JOIN ownercars AS ocars ON o.OwnerCarID = ocars.OwnerCarID JOIN models AS model ON model.ModelID = ocars.ModelID JOIN marks AS mark ON mark.MarkID = model.MarkID JOIN owners AS own ON own.OwnerID = ocars.OwnerID where mark.MarkName = @markName";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@markName", markauto);

                    MySqlDataReader dt = cmd.ExecuteReader();
                    OrdersDt.Load(dt);
                    dt.Close();

                }
                this.CloseConnection();
                return OrdersDt;
            }
            this.CloseConnection();
            return OrdersDt;
        }

        public DataTable GetAllOrdersByOwner(string lastname)
        {
            DataTable OrdersDt = new DataTable();
            if (this.OpenConnection() == true)
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT o.OrderID,CONCAT(worker.WorkerFn,' ',SUBSTRING(worker.WorkerLn,1,1),'.',SUBSTRING(worker.WorkerPn,1,1)) AS Worker,CONCAT(mark.MarkName,' ',model.ModelName) AS Auto,CONCAT(own.OwnerLn,' ',SUBSTRING(own.OwnerFn,1,1),'.',SUBSTRING(own.OwnerPn,1,1)) AS Owner,ocars.OwnerNumCar,CONCAT(o.OrderSum,' руб')AS OrderSum,o.DateCreate,o.DateComplete FROM orders AS o JOIN workers AS worker ON o.WorkerID = worker.WorkerID JOIN ownercars AS ocars ON o.OwnerCarID = ocars.OwnerCarID JOIN models AS model ON model.ModelID = ocars.ModelID JOIN marks AS mark ON mark.MarkID = model.MarkID JOIN owners AS own ON own.OwnerID = ocars.OwnerID where own.OwnerLn = @lastname";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@lastname", lastname);

                    MySqlDataReader dt = cmd.ExecuteReader();
                    OrdersDt.Load(dt);
                    dt.Close();

                }
                this.CloseConnection();
                return OrdersDt;
            }
            this.CloseConnection();
            return OrdersDt;
        }

        public DataTable GetAllOrdersByWorker(string workername)
        {
            DataTable OrdersDt = new DataTable();
            if (this.OpenConnection() == true)
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT o.OrderID,CONCAT(worker.WorkerFn,' ',SUBSTRING(worker.WorkerLn,1,1),'.',SUBSTRING(worker.WorkerPn,1,1)) AS Worker,CONCAT(mark.MarkName,' ',model.ModelName) AS Auto,CONCAT(own.OwnerLn,' ',SUBSTRING(own.OwnerFn,1,1),'.',SUBSTRING(own.OwnerPn,1,1)) AS Owner,ocars.OwnerNumCar,CONCAT(o.OrderSum,' руб')AS OrderSum,o.DateCreate,o.DateComplete FROM orders AS o JOIN workers AS worker ON o.WorkerID = worker.WorkerID JOIN ownercars AS ocars ON o.OwnerCarID = ocars.OwnerCarID JOIN models AS model ON model.ModelID = ocars.ModelID JOIN marks AS mark ON mark.MarkID = model.MarkID JOIN owners AS own ON own.OwnerID = ocars.OwnerID where worker.WorkerFn = @workerlastname";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@workerlastname", workername);

                    MySqlDataReader dt = cmd.ExecuteReader();
                    OrdersDt.Load(dt);
                    dt.Close();

                }
                this.CloseConnection();
                return OrdersDt;
            }
            this.CloseConnection();
            return OrdersDt;
        }

        public DataTable GetAllUnCompleteOrders()
        {
            DataTable OrdersDt = new DataTable();
            if (this.OpenConnection() == true)
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT o.OrderID,CONCAT(worker.WorkerFn,' ',SUBSTRING(worker.WorkerLn,1,1),'.',SUBSTRING(worker.WorkerPn,1,1)) AS Worker,CONCAT(mark.MarkName,' ',model.ModelName) AS Auto,CONCAT(own.OwnerLn,' ',SUBSTRING(own.OwnerFn,1,1),'.',SUBSTRING(own.OwnerPn,1,1)) AS Owner,ocars.OwnerNumCar,CONCAT(o.OrderSum,' руб')AS OrderSum,o.DateCreate,o.DateComplete FROM orders AS o JOIN workers AS worker ON o.WorkerID = worker.WorkerID JOIN ownercars AS ocars ON o.OwnerCarID = ocars.OwnerCarID JOIN models AS model ON model.ModelID = ocars.ModelID JOIN marks AS mark ON mark.MarkID = model.MarkID JOIN owners AS own ON own.OwnerID = ocars.OwnerID where o.DateComplete is null";
                    MySqlDataReader dt = cmd.ExecuteReader();
                    OrdersDt.Load(dt);
                    dt.Close();

                }
                this.CloseConnection();
                return OrdersDt;
            }
            this.CloseConnection();
            return OrdersDt;
        }

        public bool InsertOrder(int workerid, int ownercarid)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "INSERT INTO orders(WorkerID,OwnerCarID) VALUES (@workerid,@ownercarid)";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@workerid", workerid);
                        cmd.Parameters.AddWithValue("@ownercarid", ownercarid);
                        int affectedRows = cmd.ExecuteNonQuery();
                        if (affectedRows > 0) MessageBox.Show("Заказ успешно добавлен!");
                        this.CloseConnection();
                        return true;
                    }
                }
                this.CloseConnection();
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка добавления заказа!");
                this.CloseConnection();
                return false;
            }
        }

        public ArrayList WorkersList()        {            ArrayList Workers = new ArrayList();            if (this.OpenConnection() == true)            {                using (MySqlCommand cmd = new MySqlCommand())                {                    cmd.Connection = connection;                    cmd.CommandText = "SELECT WorkerID, CONCAT(WorkerFn,' ',SUBSTRING(WorkerLn,1,1),'.',SUBSTRING(WorkerPn,1,1)) AS WorkerFIO FROM workers;";                    MySqlDataReader dr = cmd.ExecuteReader();                    while (dr.Read())                    {                        Workers.Add(new AddWorker(dr.GetString(1),dr.GetInt32(0)));                    }                }                this.CloseConnection();                return Workers;            }               return Workers;        }    }}
