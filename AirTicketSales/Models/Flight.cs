
using AirTicketSales.Enums;
using AirTicketSales.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicketSales
{
    class Flight:Base
    {
        static int counter = 0;
        public Flight()
        {
            this.Id = ++counter;
            this.FlightTime = new DateTime(); 
        }
        public string Name { get; set; }
        public string Plane { get; set; }
        public DateTime FlightTime { get; set; }
        public int MaxPassengerCount { get; set; }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendLine(
                $"************{Id}************\n" +
                $"------------Uçuşun adı:| {Name} \n" +
                $"------------Təyyarə:   | {Plane} \n" +
                $"------------Uçuşun tarixi:| {FlightTime} \n" +
                $"------------Maksimum sərnişin sayı:| {MaxPassengerCount}"
                );
            return strBuilder.ToString(); 
        }
         public AddPassengerResponse AddPassenger(Passenger passenger)
        {
            if (MaxPassengerCount>=250)
            {
                Console.WriteLine("Yerler Doludur");
            }
            return AddPassengerResponse.Success;
        }


        /*Flight flight = new Flight(..,..,20);
Ticket ticket = flight.AddPassenger(passenger,cityFrom,cityTo,...);

yoxlayiriq burda necəsə ki uçuş üçün ayrılan yerlər dolubmu??
*AcademyTaski xatirlayaq*/
    }
}
