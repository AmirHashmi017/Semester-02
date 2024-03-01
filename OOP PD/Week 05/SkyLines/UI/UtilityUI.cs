using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLines
{
    internal class UtilityUI
    {

        public static bool CheckNumber(string enter)
        {
            for (int i = 0; i < enter.Length; i++)
            {
                if (i == 0 && enter[i] != '1' && enter[i] != '2' && enter[i] != '3' && enter[i] != '4' && enter[i] != '5' && enter[i] != '6' && enter[i] != '7' && enter[i] != '8' && enter[i] != '9')
                    return false;
                else if (i != 0 && enter[i] != '0' && enter[i] != '1' && enter[i] != '2' && enter[i] != '3' && enter[i] != '4' && enter[i] != '5' && enter[i] != '6' && enter[i] != '7' && enter[i] != '8' && enter[i] != '9')
                    return false;
            }
            return true;
        }
        public static int FrontScreen()
        {
            string enter;
            int option;
            while (true)
            {
                Console.WriteLine(" 1. Login");
                Console.WriteLine(" 2. Sign Up");
                Console.WriteLine(" 3. Exit");
                Console.Write(" Enter Option Number: ");
                enter = Console.ReadLine();
                if (enter != "1" && enter != "2" && enter != "3")
                {
                    Console.WriteLine(" \n\nInvalid Input..");
                    Console.WriteLine(" Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                option = int.Parse(enter);
                Console.Clear();
                return option;
            }
        }
        public static int AdminMenu()
        {
            string enter;
            int option;
            while (true)
            {
                Console.WriteLine(" \t\t\t\tAdmin's Menu\n\n");
                Console.WriteLine(" 1. Add Flight");
                Console.WriteLine(" 2. Remove Flight");
                Console.WriteLine(" 3. Edit Flight Schedule");
                Console.WriteLine(" 4. View Flights");
                Console.WriteLine(" 5. Hire Staff");
                Console.WriteLine(" 6. Expel Staff");
                Console.WriteLine(" 7. Update Staff's Information");
                Console.WriteLine(" 8. View AirLine Staff");
                Console.WriteLine(" 9. View FeedBack");
                Console.WriteLine(" 10. Log Out");
                Console.Write(" Enter Option Number: ");
                enter = Console.ReadLine();
                if (enter != "1" && enter != "2" && enter != "3" && enter != "4" && enter != "5" && enter != "6" && enter != "7" && enter != "8" && enter != "9"&&enter!="10")
                {
                    Console.WriteLine(" \n\nInvalid Input..");
                    Console.WriteLine(" Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                option = int.Parse(enter);
                Console.Clear();
                return option;
            }
        }
        public static int ClientMenu()
        {
            string enter;
            int option;
            while (true)
            {
                Console.WriteLine(" \t\t\t\tClient's Menu\n\n");
                Console.WriteLine(" 1. Search Flights");
                Console.WriteLine(" 2. Book Flight");
                Console.WriteLine(" 3. Cancel Reserve Seat");
                Console.WriteLine(" 4. View Reserved Flights");
                Console.WriteLine(" 5. Submit FeedBack");
                Console.WriteLine(" 6. Log Out");
                Console.Write(" Enter Option Number: ");
                enter = Console.ReadLine();
                if (enter != "1" && enter != "2" && enter != "3" && enter != "4" && enter != "5" && enter != "6" && enter != "7" && enter != "8" && enter != "9")
                {
                    Console.WriteLine(" \n\nInvalid Input..");
                    Console.WriteLine(" Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                option = int.Parse(enter);
                Console.Clear();
                return option;
            }
        }
        public static void SignUp()
        {
            Console.WriteLine("\t\t\t Sign Up\n\n");
            string name, password, role;
            while (true)
            {
                Console.Write(" Enter UserName: ");
                name = Console.ReadLine();
                if (!(ClientDL.CheckValidClientName(name) && AdminDL.CheckValidAdminName(name)))
                {
                    Console.WriteLine(" \n\nSorry! This UserName is Already Taken..");
                    Console.WriteLine(" Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                Console.Write(" Enter Password: ");
                password = Console.ReadLine();
                Console.Write(" Enter Role (Admin/Client): ");
                role = Console.ReadLine();
                if (role != "Client" && role != "client" && role != "Admin" && role !="admin")
                {
                    Console.WriteLine(" Invalid Input..Please Enter Valid Role!!");
                    Console.WriteLine(" Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                break;
            }
            if (role == "Client" || role == "client")
            {
                Client c = new Client(name, password, role);
                ClientDL.AddClient(c);
            }
            else if (role == "Admin" || role == "admin")
            {
                Admin a = new Admin(name, password, role);
                AdminDL.AddAdmin(a);
            }
            Console.WriteLine($"\n\n {name}! You are sucessfully Signed Up as a {role}");
            Console.WriteLine(" Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        public static string Login()
        {
            int number;
            string result = " ";
            Console.WriteLine("\t\t\t Login\n\n");
            string name, password;
            Console.Write(" Enter UserName: ");
            name = Console.ReadLine();
            Console.Write(" Enter Password: ");
            password = Console.ReadLine();
            if (ClientDL.IsClientExist(name, password))
            {
                number = ClientDL.FindClient(name, password);
                result = number.ToString();
            }
            else if (AdminDL.IsAdminExist(name, password))
            {
                result = "Admin";
            }
            if (result != " ")
            {
                Console.WriteLine($"\n\n {name}! You are sucessfully Signed in.");
            }
            else
            {
                Console.WriteLine(" \n\n No such Person Exist!!");
            }
            Console.WriteLine(" Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            return result;
        }
    }
}
