using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AutoserviceCore
{
    public interface ISearchAuto
    {
        DataTable SelectAutoByNumberAuto(string numberAuto);
        DataTable SelectAutoByLastName(string lastName);
        DataTable SelectAutoByNumberPassport(string numberPassport);
    }
    public class SearchAuto : Dbconnection, ISearchAuto
    {


        public DataTable SelectAutoByNumberAuto(string numberAuto)
        {
            DataTable AutoDt = new DataTable();
            try
            {
                if (this.OpenConnection() == true)
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "SELECT  own.OwnerCarID, CONCAT(mark.MarkName,' ',model.ModelName)AS Auto, own.OwnerNumCar ,own.OwnerCarLolor FROM ownercars AS own JOIN models AS model ON own.ModelID = model.ModelID  JOIN marks AS mark ON  model.MarkID = mark.MarkID WHERE own.OwnerNumCar = @numberAuto";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@numberAuto", numberAuto);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        AutoDt.Load(dr);
                        dr.Close();

                    }
                    this.CloseConnection();
                    return AutoDt;
                }
            }
            catch (Exception)
            {
                this.CloseConnection();
                return AutoDt;
            }
            this.CloseConnection();
            return AutoDt;
        }


        public DataTable SelectAutoByLastName(string lastName)
        {
            DataTable AutoDt = new DataTable();
            try
            {
                if (this.OpenConnection() == true)
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "SELECT  own.OwnerCarID, CONCAT(mark.MarkName,' ',model.ModelName)AS Auto, own.OwnerNumCar ,own.OwnerCarLolor FROM ownercars AS own JOIN models AS model ON own.ModelID = model.ModelID JOIN marks AS mark ON  model.MarkID = mark.MarkID  JOIN owners AS o ON own.OwnerID = o.OwnerID WHERE o.OwnerLn = @lastname";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@lastname", lastName);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        AutoDt.Load(dr);
                        dr.Close();

                    }
                    this.CloseConnection();
                    return AutoDt;
                }
            }
            catch (Exception)
            {
                this.CloseConnection();
                return AutoDt;
            }
            this.CloseConnection();
            return AutoDt;
        }


        public DataTable SelectAutoByNumberPassport(string numberPassport)
        {
            DataTable AutoDt = new DataTable();
            try
            {
                if (this.OpenConnection() == true)
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "SELECT  own.OwnerCarID, CONCAT(mark.MarkName,' ',model.ModelName)AS Auto, own.OwnerNumCar ,own.OwnerCarLolor FROM ownercars AS own JOIN models AS model ON own.ModelID = model.ModelID JOIN marks AS mark ON  model.MarkID = mark.MarkID JOIN owners AS o ON own.OwnerID = o.OwnerID WHERE o.OwnerPassport = @numberPassport";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@numberPassport", numberPassport);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        AutoDt.Load(dr);
                        dr.Close();

                    }
                    this.CloseConnection();
                    return AutoDt;
                }
            }
            catch (Exception)
            {
                this.CloseConnection();
                return AutoDt;
            }
            this.CloseConnection();
            return AutoDt;
        }
    }
}
