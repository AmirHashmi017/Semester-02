using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLines
{
    internal class FlightDL
    {
        public static List<Flight> Flights = new List<Flight>();

        public static void AddFlight(Flight f)
        {
            Flights.Add(f);
        }
        public static bool RemoveFlight(string name, string flightID)
        {
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].FlightName == name && Flights[i].FlightID == flightID)
                {
                    Flights.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public static void EditFlight(string name, string flightID, string source, string destination, string date, string takeoff, string landing, double price, double seats)
        {
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].FlightName == name && Flights[i].FlightID == flightID)
                {
                    Flights[i].Source = source;
                    Flights[i].Destination = destination;
                    Flights[i].TravelDate = date;
                    Flights[i].TakeoffTime = takeoff;
                    Flights[i].LandingTime = landing;
                    Flights[i].Price = price;
                    Flights[i].Seats = seats;
                    break;
                }
            }
        }
        public static bool CheckValidFlightID(string ID)
        {
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].FlightID == ID)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsFlightExist(string ID)
        {
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].FlightID == ID)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckValidDate(string date)
        {
            string dateFormat = "dd-MM-yyyy";
            if (DateTime.TryParseExact(date, dateFormat, null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckValidTime(string time)
        {
            string timeFormat = "hh:mm tt";
            if (DateTime.TryParseExact(time, timeFormat, null, System.Globalization.DateTimeStyles.None, out DateTime parsedTime))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
