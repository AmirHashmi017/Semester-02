using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLines
{
    internal class FlightUI
    {
        public static void AddNewFlight()
        {
            Console.WriteLine("\t\t\t Add Flight\n\n");
            string name; string ID; string source; string destination; string date; string takeoff; string landing; double price; double seats;
            string checkprice, checkseats;
            while (true)
            {
                Console.Write(" Enter Flight ID: ");
                ID = Console.ReadLine();
                Console.Write(" Enter Flight Name: ");
                name = Console.ReadLine();
                if (!(FlightDL.CheckValidFlightID(ID)))
                {
                    Console.WriteLine(" This FlightID Already Exist.Kindly Enter any other ID.");
                    Console.WriteLine(" Press any key to continue!!!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                Console.Write(" Enter Departure Airport: ");
                source = Console.ReadLine();
                Console.Write(" Enter Arrival Airport: ");
                destination = Console.ReadLine();
                Console.Write(" Enter Departure Date (DD-MM-YYYY): ");
                date = Console.ReadLine();
                if (!(FlightDL.CheckValidDate(date)))
                {
                    Console.WriteLine(" Invalid Date!!!");
                    Console.WriteLine(" Press any key to continue!!!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                Console.Write(" Enter Departure Time i.e (12AM,5PM): ");
                takeoff = Console.ReadLine();
                if (!(FlightDL.CheckValidTime(takeoff)))
                {
                    Console.WriteLine(" Invalid Departure Time!!!");
                    Console.WriteLine(" Press any key to continue!!!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                Console.Write(" Enter Landing Time i.e (12:00 AM,05:30 PM): ");
                landing = Console.ReadLine();
                if (!(FlightDL.CheckValidTime(landing)))
                {
                    Console.WriteLine(" Invalid Landing Time!!!");
                    Console.WriteLine(" Press any key to continue!!!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                Console.Write(" Enter Ticket Price: ");
                checkprice = Console.ReadLine();
                if (!(UtilityUI.CheckNumber(checkprice)))
                {
                    Console.WriteLine(" Invalid Price!!!");
                    Console.WriteLine(" Press any key to continue!!!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                price = double.Parse(checkprice);
                Console.Write(" Enter Number of Seats: ");
                checkseats = Console.ReadLine();
                if (!(UtilityUI.CheckNumber(checkseats)))
                {
                    Console.WriteLine(" Invalid Input!!!");
                    Console.WriteLine(" Press any key to continue!!!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                seats = double.Parse(checkseats);
                Flight f = new Flight(ID,name, source, destination, date, takeoff, landing, price, seats);
                FlightDL.AddFlight(f);
                break;
            }
            Console.WriteLine(" \nThe Desired Flight is Sucessfully Added.");
            Console.WriteLine(" \n\nPress any key to continue!!!");
            Console.ReadKey();
        }
        public static void DeleteFlight()
        {
            Console.WriteLine("\t\t\t Remove Flight\n\n");
            Console.Write(" Enter Flight Name: ");
            string name = Console.ReadLine();
            Console.Write(" Enter Flight ID: ");
            string ID = Console.ReadLine();
            if (FlightDL.RemoveFlight(name, ID))
            {
                Console.WriteLine(" \nThe Desired Flight is removed.");
            }
            else
            {
                Console.WriteLine(" \nNo Such flight Found.");
            }
            Console.WriteLine(" Press any key to continue!!!");
            Console.ReadKey();
        }
        public static void UpdateFlight()
        {
            Console.WriteLine("\t\t\t Edit Flight Schedule\n\n");
            string name; string ID; string source; string destination; string date; string takeoff; string landing; double price; double seats;
            string checkprice, checkseats;
            Console.Write(" Enter Flight Name: ");
            name = Console.ReadLine();
            Console.Write(" Enter Flight ID: ");
            ID = Console.ReadLine();
            if (FlightDL.IsFlightExist(ID))
            {
                while (true)
                {
                    Console.Write(" Enter Departure Airport: ");
                    source = Console.ReadLine();
                    Console.Write(" Enter Arrival Airport: ");
                    destination = Console.ReadLine();
                    Console.Write(" Enter Departure Date (DD-MM-YYYY): ");
                    date = Console.ReadLine();
                    if (!(FlightDL.CheckValidDate(date)))
                    {
                        Console.WriteLine(" Invalid Date!!!");
                        Console.WriteLine(" Press any key to continue!!!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Write(" Enter Departure Time i.e (12:00 AM,05:30 PM): ");
                    takeoff = Console.ReadLine();
                    if (!(FlightDL.CheckValidTime(takeoff)))
                    {
                        Console.WriteLine(" Invalid Departure Time!!!");
                        Console.WriteLine(" Press any key to continue!!!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Write(" Enter Landing Time i.e (12AM,5PM): ");
                    landing = Console.ReadLine();
                    if (!(FlightDL.CheckValidTime(landing)))
                    {
                        Console.WriteLine(" Invalid Landing Time!!!");
                        Console.WriteLine(" Press any key to continue!!!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Write(" Enter Ticket Price: ");
                    checkprice = Console.ReadLine();
                    if (!(UtilityUI.CheckNumber(checkprice)))
                    {
                        Console.WriteLine(" Invalid Price!!!");
                        Console.WriteLine(" Press any key to continue!!!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    price = double.Parse(checkprice);
                    Console.Write(" Enter Number of Seats: ");
                    checkseats = Console.ReadLine();
                    if (!(UtilityUI.CheckNumber(checkseats)))
                    {
                        Console.WriteLine(" Invalid Input!!!");
                        Console.WriteLine(" Press any key to continue!!!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    seats = double.Parse(checkseats);
                    break;
                }
                FlightDL.EditFlight(name, ID, source, destination, date, takeoff, landing, price, seats);
                Console.WriteLine(" \nThe Desired Flight's schedule is sucessfully updated.");
            }
            else
            {
                Console.WriteLine(" \nNo Such Flight Found.");
            }
            Console.WriteLine(" \n\nPress any key to continue!!!");
            Console.ReadKey();
        }
        public static void ViewAllFlights()
        {
            Console.WriteLine("\t\t\t View Flights\n\n");
            Console.WriteLine("Flight ID\t\t\t Flight Name\t\t\t Depature Airport\t\t Arrival Airport\t\t Departure Date\t\t Departure Time \t\t Landing Time\t\t Price\t\t Seats\n");
            for (int i = 0; i < FlightDL.Flights.Count; i++)
            {
                Console.WriteLine(FlightDL.Flights[i].ViewFlight());
            }
            Console.WriteLine("\n\n\n Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
