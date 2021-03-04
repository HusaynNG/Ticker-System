using AirTicketSales.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicketSales
{
    class Ticket : Base
    {
        static int counter = 0;
        public Ticket()
        {
            this.Id = ++counter;
            this.TicketNumber = Guid.NewGuid().ToString("n").Substring(0, 8);
        }
       
        public string TicketNumber { get; set; }
        public  FromCity FromCity { get; set; }
        public  ToCity ToCity { get; set; }
        public  Passenger Passenger { get; set; }
        public  Flight Flight { get; set; }
        public  int Seat { get; set; }
        public  string Gate { get; set; }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendLine(
                $"************{Id}************\n" +
                $"------------Ticket No:| {TicketNumber} \n" +
                $"------------From: | {FromCity} \n" +
                $"------------From to:  |  {ToCity} \n" +
                $"------------Passenger:| {Passenger}\n" +
                $"------------Flight:    | {Flight.Name}\n" +
                $"------------Seat:| {Seat}\n" +
                $"------------Enter:   | {Gate}"
                );
            return strBuilder.ToString();
        }
    }
}
