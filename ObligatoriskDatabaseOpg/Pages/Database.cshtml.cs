using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ObligatoriskDatabaseOpg.Model;

namespace ObligatoriskDatabaseOpg.Pages
{
    public class DatabaseModel : PageModel
    {
        private HotelDatabase _Data;
        private IRoomPrice _AVGPrice;


        public DatabaseModel(HotelDatabase data, IRoomPrice price)
        {
            _Data = data;
            _AVGPrice = price;
        }

        public List<Hotel> HotelList;
        public double avgprice;

        public IActionResult OnGet()
        {
            avgprice = _AVGPrice.GetAvgPrice();
            HotelList = _Data.GetAllHotels();
            return Page();
        }
    }
}
