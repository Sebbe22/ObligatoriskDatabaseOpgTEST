using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ObligatoriskDatabaseOpg.Model
{
    public class HotelDatabase : IHotelDatabase
    {
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<Hotel> GetAllHotels()
        {
            List<Hotel> liste = new List<Hotel>();
            string sql = "SELECT * FROM Hotel";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(sql, connection);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Hotel hotel = ReadHotel(reader);
                    liste.Add(hotel);
                }
            }


            return liste;
        }

        public Hotel ReadHotel(SqlDataReader reader)
        {
            Hotel hotel = new Hotel();

            hotel.Name = reader.GetString(1);
            hotel.Address = reader.GetString(2);
            hotel.Hotel_No = reader.GetInt32(0);

            return hotel;
        }
    }
}
