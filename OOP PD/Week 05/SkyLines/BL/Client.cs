using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLines
{
    internal class Client
    {
        public string ClientName;
        public string ClientPassword;
        public string Role;
        public string FeedBack;
        public List<Flight> BookedFlights;

        public Client(string name, string password, string role)
        {
            this.ClientName = name;
            this.ClientPassword = password;
            this.Role = role;
            BookedFlights = new List<Flight>();
        }
        public void SubmitFeedBack()
        {
            string feedback = ClientUI.GetFeedBack();


            this.FeedBack = feedback;
            ClientUI.FeedBackResult();
        }
        public string ViewFeedBack()
        {
            return ($" FeedBack By {ClientName}:  {FeedBack}");
        }
        public void BookFlight()
        {
            if (ClientUI.SearchFlight())
            {
                Flight f = ClientUI.BookingInput();
                BookedFlights.Add(f);
                f.Seats = f.Seats - 1;
            }
        }
        public bool ViewBookedFlights()
        {
            Console.WriteLine("\t\t\t View Reserved Flights\n\n");
            if (BookedFlights.Count > 0)
            {
                Console.WriteLine("Flight ID\t\t\t Flight Name\t\t\t Depature Airport\t\t Arrival Airport\t\t Departure Date\t\t Departure Time \t\t Landing Time\t\t Price\t\t Seats\n");
                foreach (Flight f in BookedFlights)
                {
                    Console.WriteLine($" {f.FlightID}\t\t\t {f.FlightName}\t\t\t {f.Source}\t\t\t {f.Destination}\t\t\t {f.TravelDate}\t\t\t {f.TakeoffTime}\t\t\t {f.LandingTime}\t\t\t {f.Price}\t\t\t {f.Seats}");
                }
                return true;
            }
            Console.WriteLine(" No Booked Flights...");

            return false;
        }
        public bool CancelFlight()
        {
            if (ViewBookedFlights())
            {
                string ID = ClientUI.CancelFlightInput();
                for (int i = 0; i < BookedFlights.Count; i++)
                {
                    if (BookedFlights[i].FlightID == ID)
                    {
                        BookedFlights[i].Seats = BookedFlights[i].Seats - 1;
                        BookedFlights.RemoveAt(i);
                        return true;
                    }
                }
                return false;
            }
            return false;
        }
    }
}
