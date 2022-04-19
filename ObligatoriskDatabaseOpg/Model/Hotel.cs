using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObligatoriskDatabaseOpg.Model
{
    public class Hotel
    {
        private int _Hotel_No;
        private string _Name;
        private string _Address;

        public int Hotel_No
        {
            get => _Hotel_No;
            set => _Hotel_No = value;
        }

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public string Address
        {
            get => _Address;
            set => _Address = value;
        }

        public override string ToString()
        {
            return ($"Hotel number: {Hotel_No}, Hotel Name: {Name}, Hotel Address {Address}");
        }
    }
}
