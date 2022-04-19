using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ObligatoriskDatabaseOpg.Model
{
    public interface IHotelDatabase
    {
        List<Hotel> GetAllHotels();

        Hotel ReadHotel(SqlDataReader reader);
   
    }
}
