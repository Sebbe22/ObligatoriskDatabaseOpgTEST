using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ObligatoriskDatabaseOpg.Model
{
    public interface IRoomPrice
    {
        double GetAvgPrice();

    }
}
