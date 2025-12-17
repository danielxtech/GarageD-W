using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageD_W
{
    public static class DatabaseHelper
    {
        private static string connectionString =
           "Data Source=(localdb)\\ProjectModels;Initial Catalog=GarageDB;Integrated Security=True";

        public static void InsertVehicle(Vehicle v)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Vehicle 
                                (PlateNumber, Brand, Year, FuelType, OwnerName, OwnerPhone, RegistrationDate)
                                 VALUES (@Plate, @Type, @Model, @Fuel, @Owner, @Phone, @Date)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Plate", v.PlateNumber);
                cmd.Parameters.AddWithValue("@Type", v.Brand);
                cmd.Parameters.AddWithValue("@Model", v.Year);
                cmd.Parameters.AddWithValue("@Fuel", v.FuelType);
                cmd.Parameters.AddWithValue("@Owner", v.OwnerName);
                cmd.Parameters.AddWithValue("@Phone", v.OwnerPhone);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void AddVehicle(string plate, string brand, string year,
                                       string fuel, string owner, string phone)
                                      
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Vehicle
                                (PlateNumber, Brand, Year, FuelType, OwnerName, OwnerPhone, RegistrationDate)
                                 VALUES
                                (@Plate, @Brand, @Year, @Fuel, @Owner, @Phone,@Date)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Plate", plate);
                cmd.Parameters.AddWithValue("@Brand", brand);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Fuel", fuel);
                cmd.Parameters.AddWithValue("@Owner", owner);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
       public static DataTable GetAllVehicles()
       {
           using (SqlConnection con = new SqlConnection(connectionString))
           {
               string query = @"SELECT 
                                    VehicleID, PlateNumber, Brand, Year, FuelType,
                                    OwnerName, OwnerPhone, RegistrationDate
                                 FROM Vehicle";

               SqlDataAdapter da = new SqlDataAdapter(query, con);
               DataTable dt = new DataTable();
               da.Fill(dt);
               return dt;
           }
       }
        public static void UpdateVehicle(int id, string plate, string brand, string year,
                                          string fuel, string owner, string phone)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Vehicle SET
                                    PlateNumber=@Plate,
                                    Brand=@Brand,
                                    Year=@Year,
                                    FuelType=@Fuel,
                                    OwnerName=@Owner,
                                    OwnerPhone=@Phone,
                                 WHERE VehicleID=@ID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Plate", plate);
                cmd.Parameters.AddWithValue("@Brand", brand);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Fuel", fuel);
                cmd.Parameters.AddWithValue("@Owner", owner);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static void DeleteVehicle(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"DELETE FROM Vehicle WHERE VehicleID=@ID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
