using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObligatoriskDatabaseOpg.Model
{
    public class Room
    {
        private float _Price;
        private int _Room_No;
        private int _Hotel_No;
        private string _Type;

        public float Price
        {
            get => _Price;
            set => _Price = value;
        }

        public int Room_No
        {
            get => _Room_No;
            set => _Room_No = value;
        }

        public int Hotel_No
        {
            get => _Hotel_No;
            set => _Hotel_No = value;
        }

        public string Type
        {
            get => _Type;
            set => _Type = value;
        }

        public override string ToString()
        {
            return ($"Hotel Number: {Hotel_No}, Room Number {Room_No}, Room Type: {Type}, Room Price: {Price}");
        }
    }
}
