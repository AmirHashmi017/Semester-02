using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SkyLines
{
    internal class ClientUI
    {
        public static string GetFeedBack()
        {
            Console.WriteLine("\t\t\t Submit FeedBack\n\n");
            Console.Write(" Enter Your FeedBack: ");
            string feedback = Console.ReadLine();
            return feedback;
        }
        public static void FeedBackResult()
        {
            Console.WriteLine(" Your FeedBack is sucessfully Submitted.");
    
        Console.WriteLine("\n\n Press any key to Continue..");
            Console.ReadKey();
            Console.Clear();
        }
        public static void ViewAllFeedBack()
        {
            Console.WriteLine("\t\t\t View FeedBack\n\n");
            for (int i = 0; i < ClientDL.Clients.Count; i++)
            {
                if (ClientDL.Clients[i].FeedBack != null)
                {
                    Console.WriteLine(ClientDL.Clients[i].ViewFeedBack());
                }
            }
            Console.WriteLine("\n\n Press any key to Continue..");
            Console.ReadKey();
            Console.Clear();
        }
        public static bool SearchFlight()
        {
            int count = 0;
            Console.WriteLine("\t\t\t Search Flights\n\n");
            Console.Write(" Enter Departure Airport: ");
            string source = Console.ReadLine();
            Console.Write(" Enter Arrival Airport: ");
            string destination = Console.ReadLine();
            Console.WriteLine("Flight ID\t\t\t Flight Name\t\t\t Depature Airport\t\t Arrival Airport\t\t Departure Date\t\t Departure Time \t\t Landing Time\t\t Price\t\t Seats\n");
            for (int i = 0; i < FlightDL.Flights.Count; i++)
            {
                if (FlightDL.Flights[i].Source == source && FlightDL.Flights[i].Destination == destination && FlightDL.Flights[i].Seats > 0)
                {
                    Console.WriteLine(FlightDL.Flights[i].ViewFlight());
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine(" No such Flights Available.");
                Console.WriteLine("\n\n Press any key to Continue..");
                Console.ReadKey();
                Console.Clear();
                return false;
            }

            return true;
        }
        public static Flight BookingInput()
        {
            Console.WriteLine("\n\n\n\t\t\t Book Flight\n\n");
            Console.Write(" Enter Flight Name: ");
            string name = Console.ReadLine();
            Console.Write(" Enter Flight ID: ");
            string ID = Console.ReadLine();
            Console.Write(" Enter Your Bank Account Pin: ");
            string pin = Console.ReadLine();
            foreach (Flight f in FlightDL.Flights)
            {
                if (f.FlightName == name && f.FlightID == ID&&f.Seats>0)
                {
                    Console.WriteLine(" \n\nThe Flight is Sucessfully Booked.");
                    Console.WriteLine("\n\n Press any key to Continue..");
                    Console.ReadKey();
                    Console.Clear();
                    return f;
                }
            }
            Console.WriteLine(" No Such Flight Available.");
            Console.WriteLine("\n\n Press any key to Continue..");
            Console.ReadKey();
            Console.Clear();
            return null;
        }
        public static string CancelFlightInput()
        {
            Console.WriteLine("\n\n\n\t\t\t Cancel Reserved Seat\n\n");
            Console.Write(" Enter Flight ID: ");
            string ID = Console.ReadLine();
            Thread.Sleep(300);
            return ID;
        }
    }
}
