
using AirTicketSales.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicketSales
{
    class City:Base
    {
        static int counter = 0;
        public City()
        {
            this.Id = ++counter;
        }

        public string CityName { get; set; }
        public Country CountryName { get; set; }
    }
}
