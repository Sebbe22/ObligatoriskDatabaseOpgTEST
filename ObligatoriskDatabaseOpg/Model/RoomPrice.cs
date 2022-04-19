using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ObligatoriskDatabaseOpg.Model
{
    public class RoomPrice : IRoomPrice
    {
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public double GetAvgPrice()
        {
            string sql = "SELECT AVG(Price) Price FROM Room";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(sql, connection);

                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                return reader.GetDouble(0);
            } 
        }
        
    }
}
