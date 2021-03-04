using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AirTicketSales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\n**************************WELCOME TO AZERBAIJAN AIRLINES************************");
            Thread.Sleep(1500);
            Console.WriteLine("You can select the country you want to travel from the list below:");
            Thread.Sleep(1000);
            var countries = new List<string>();
            countries.Add("Turkey");
            countries.Add("Moskow");
            countries.Add("Georgia");
            countries.Add("Germany");
            countries.Add("Iran");
            countries.Add("China");
            countries.Add("Italy");
            countries.Add("America");
            countries.Add("Egypt");
            countries.Add("Greece");

            for (int i = 0; i < countries.Count; i++)
            {
                Console.WriteLine($"{i}.{countries[i]}");
              
            }
            
        l1:
            Console.WriteLine("Enter the name of the country you are traveling to:");
            string chooseCountry = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(chooseCountry) || chooseCountry.Replace(" ", "").Length < 3)
            {
                Console.WriteLine("Enter the country name correctly");
                goto l1;
            }
        l2:
            Console.WriteLine("Enter the name of the city you will be traveling to:");
            string chooseCity = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(chooseCity) || chooseCity.Replace(" ", "").Length < 3)
            {
                Console.WriteLine("Enter the city name correctly");
                goto l2;
            }
        l3:
            Console.WriteLine("Enter the flight date  (yyyy.MM.dd):");
            string strFDate = Console.ReadLine();
            if ((DateTime.TryParse(strFDate, out DateTime FlightTime) && (FlightTime >= DateTime.Now))== false)
            {
                Console.Beep();
                Console.WriteLine("The flight date cannot be smaller than today's date!");
                Thread.Sleep(1000);
                goto l3;
            }
            Console.WriteLine("Enter information about yourself:");
        l4:
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name) || name.Replace(" ", "").Length < 3)
            {
                Console.Beep();
                Thread.Sleep(1000);
                goto l4;
            }
        l5:
            Console.WriteLine("Surname:");
            string surname = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(surname) || surname.Replace(" ", "").Length < 3)
            {
                Console.Beep();
                Thread.Sleep(1000);
                goto l5;
            }
        l6:
            Console.WriteLine("Father Name:");
            string fatherName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(fatherName) || fatherName.Replace(" ", "").Length < 3)
            {
                Console.Beep();
                Thread.Sleep(1000);
                goto l6;
            }
        l7:
            Console.Write("Enter your birth date (yyyy.MM.dd): ");
            string strBirthDay = Console.ReadLine();
            if (DateTime.TryParse(strBirthDay, out DateTime dateofbirth) == false)
            {
                Console.Beep();
                Console.WriteLine("Enter your birth date in the correct format!");
                Thread.Sleep(1000);
                goto l7;
            }

            Console.Write("Sex: \n 1-Man \n 2-Woman \n");
        l8:
            string strGender = Console.ReadLine();
            var gender = new List<int>();
            gender.Add(1);
            gender.Add(2);

            if (int.TryParse(strGender, out int number) || number > 2)
            {
                if (number==1)
                {
                    Console.WriteLine("Man");
                   
                }
                else  if (number == 2)
                {
                    Console.WriteLine("Woman");
                   
                }
                else {
                    Console.Beep();
                    Console.WriteLine("You can choose 1 or 2");
                    Thread.Sleep(1000);
                }
                goto l8;
            }
            Console.WriteLine("If you want to continue, press any button to reverse <ESC>");
           
            ConsoleKeyInfo key = Console.ReadKey();
             if (key.Key == ConsoleKey.Escape)
            {
                Thread.Sleep(1000);
                Environment.Exit(0);
            }

            Console.WriteLine("\n================LIST OF PASSENGERS========================");
            var passenger = new List<Passenger>();
            #region AddPassengers
            passenger.AddRange(
                   new[]
                   {
                    //new Passenger()
                    //{
                    //    Name=name,
                    //    Surname=surname,
                    //    FatherName=fatherName,
                    //    BirthOfDate=dateofbirth,
                    //    Gender=Gender.Kishi
                    //},
                    new Passenger()
                    {
                        Name=name,
                        Surname=surname,
                        FatherName=fatherName,
                        BirthOfDate=dateofbirth,
                        Gender=Gender.Qadin
                    },

                   });
            foreach (var item in passenger)
            {
                Console.WriteLine(item);
            } 
            #endregion


            Console.WriteLine("\n================FLIGHT LIST========================");
            var flight = new List<Flight>();
            #region Flight AddRange()

            flight.AddRange(
                new[]
                {
                    new Flight()
                    {
                       Name="Ganja-Moskva",
                       Plane="Azal Airbus A340-500",
                       FlightTime=new DateTime(2021,02,28),
                       MaxPassengerCount=340
                    },
                     new Flight()
                    {
                       Name="Baku-Izmir",
                       Plane="Turkish Airles B787-9 Dreamliner",
                       FlightTime=DateTime.Now,
                       MaxPassengerCount=251
                    },
                      new Flight()
                    {
                       Name="Baku-Istanbul",
                       Plane="Turkish Airles A350-900",
                       FlightTime=new DateTime(2021,03,01),
                       MaxPassengerCount=350
                    },
                       new Flight()
                    {
                       Name="Baku-Berlin",
                       Plane="Azal Airbus A319-100",
                       FlightTime=new DateTime(2021,02,13),
                       MaxPassengerCount=319
                    }
                });
            foreach (var item in flight)
            {
                Console.WriteLine(item);
            }
            //if (MaxPassengerCount >= 250)
            //{

            //}
            #endregion

            Console.WriteLine("\n================LIST OF TICKETS========================");
            var ticket=new List<Ticket>();
            #region Ticket.AddRange()
            ticket.AddRange(
                new[]
                {
                    new Ticket()
                    {
                        FromCity=FromCity.Baki,
                        ToCity=ToCity.Berlin,
                        Flight=flight[0],
                        Passenger=passenger[0],
                        Seat=5,
                        Gate="A1"
                    },
                    new Ticket()
                    {
                        FromCity=FromCity.Baki,
                        ToCity=ToCity.Izmir,
                        Flight=flight[0],
                        Passenger=passenger[0],
                        Seat=15,
                        Gate="B11" }
                    , 
                        new Ticket()
                    {
                        FromCity=FromCity.Nakhchivan,
                        ToCity=ToCity.Istanbul,
                        Flight=flight[1],
                        Passenger=passenger[0],
                        Seat=15,
                        Gate="C12"
                    },
                     new Ticket()
                    {
                        FromCity=FromCity.Ganja,
                        ToCity=ToCity.Moskva,
                        Flight=flight[0],
                        Passenger=passenger[0],
                        Seat=15,
                        Gate="C12"
                    }
                });

            foreach (var item in ticket)
            {
                Console.WriteLine(item);
            }

            //ticket.RemoveAt(2); 
            #endregion

            Console.WriteLine("Thank you for choosing us");
            Thread.Sleep(300);
            Console.WriteLine("Good Luck!");
            Console.ReadKey(); ;
        }

    }
}
