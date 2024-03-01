using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLines
{
    internal class Flight
    {
        public string FlightID;
        public string FlightName;
        public string Source;
        public string Destination;
        public string TravelDate;
        public string TakeoffTime;
        public string LandingTime;
        public double Price;
        public double Seats;

        public Flight(string FlightID, string FlightName, string Source, string Destination, string TravelDate, string TakeoffTime, string LandingTime, double Price, double Seats)
        {
            this.FlightID = FlightID;
            this.FlightName = FlightName;
            this.Source = Source;
            this.Destination = Destination;
            this.TravelDate = TravelDate;
            this.TakeoffTime = TakeoffTime;
            this.LandingTime = LandingTime;
            this.Price = Price;
            this.Seats = Seats;
        }
        public string ViewFlight()
        {
            return ($" {FlightID}\t\t\t\t {FlightName}\t\t\t {Source}\t\t\t\t {Destination}\t\t\t\t {TravelDate}\t\t\t {TakeoffTime}\t\t\t {LandingTime}\t\t {Price}\t\t{Seats}");
        }
    }
}
