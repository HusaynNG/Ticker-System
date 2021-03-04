
using AirTicketSales.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicketSales
{
    class Passenger : Base
    {
        static int counter = 0;
        public Passenger()
        {
            this.Id = ++counter;
            
        }
        //public Passenger(DateTime birthOfdate, Gender gender, string name, string surname, string fathername)
        //    :this(name,surname,fathername)
        //{

        //}
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public DateTime BirthOfDate { get; set; }
        public Gender Gender { get; set; }

        public override string ToString()
        {
            
            return FullNamePassenger();
        }

        public string FullNamePassenger()
        {
            return $"Passenger Name: {this.Name}| Surname:{this.Surname}| Father Name:{this.FatherName}| Birth Date:{this.BirthOfDate.ToShortDateString()}| Sex:{Gender}";
            //return 
        }
    }
}
