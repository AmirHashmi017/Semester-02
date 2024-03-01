using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string LoginCheck; int clientnumber;
            int loginoption, option;
            while (true)
            {
                Console.WriteLine("\t\t\t SKYLINES \n\n");
                loginoption = UtilityUI.FrontScreen();
                if (loginoption == 1)
                {
                    LoginCheck = UtilityUI.Login();
                    if (LoginCheck == " ")
                    {
                        continue;
                    }
                    else if (LoginCheck != "Admin")
                    {
                        clientnumber = int.Parse(LoginCheck);
                        while (true)
                        {
                            Console.Clear();
                            option = UtilityUI.ClientMenu();
                            if (option == 1)
                            {
                                ClientUI.SearchFlight();
                                Console.WriteLine("\n\n Press any key to Continue..");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (option == 2)
                            {
                                ClientDL.Clients[clientnumber].BookFlight();
                            }
                            else if (option == 3)
                            {
                                if (ClientDL.Clients[clientnumber].CancelFlight())
                                    Console.WriteLine("The Reserve Seat is Cancelled.");
                                else
                                    Console.WriteLine(" No such Flight Found");
                                Console.WriteLine("\n\n Press any key to Continue..");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (option == 4)
                            {
                                ClientDL.Clients[clientnumber].ViewBookedFlights();
                                Console.WriteLine("\n\n Press any key to Continue..");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (option == 5)
                            {
                                ClientDL.Clients[clientnumber].SubmitFeedBack();
                            }
                            else if (option == 6)
                            {
                                Console.Clear();
                                break;
                            }
                        }
                    }
                    else if (LoginCheck == "Admin")
                    {
                        while (true)
                        {
                            Console.Clear();
                            option = UtilityUI.AdminMenu();
                            if (option == 1)
                            {
                                FlightUI.AddNewFlight();
                            }
                            else if (option == 2)
                            {
                                FlightUI.DeleteFlight();
                            }
                            else if (option == 3)
                            {
                                FlightUI.UpdateFlight();
                            }
                            else if (option == 4)
                            {
                                FlightUI.ViewAllFlights();
                            }
                            else if (option == 5)
                            {
                                StaffUI.HireStaff();
                            }
                            else if (option == 6)
                            {
                                StaffUI.ExpellStaff();
                            }
                            else if (option == 7)
                            {
                                StaffUI.UpdateStaff();
                            }
                            else if (option == 8)
                            {
                                StaffUI.ViewAllStaff();
                            }
                            else if (option == 9)
                            {
                                ClientUI.ViewAllFeedBack();
                            }
                            else if (option == 10)
                            {
                                Console.Clear();
                                break;
                            }
                        }
                    }
                }
                else if (loginoption == 2)
                {
                    UtilityUI.SignUp();
                }
                else if (loginoption == 3)
                {
                    Console.Clear();
                    break;
                }
            }

        }
    }
}
