using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLines
{
    internal class StaffUI
    {
        public static void HireStaff()
        {
            Console.WriteLine("\t\t\t Hire Staff\n\n");
            string name; string ID; string designation; double salary;
            while (true)
            {
                Console.Write(" Enter Staff Name: ");
                name = Console.ReadLine();
                Console.Write(" Enter Staff ID: ");
                ID = Console.ReadLine();
                if (!(StaffDL.CheckValidStaffID(ID)))
                {
                    Console.WriteLine(" This StaffID Already Exist.Kindly Enter any other ID.");
                    Console.WriteLine(" Press any key to continue!!!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                Console.Write(" Enter Staff Designation: ");
                designation = Console.ReadLine();
                Console.Write(" Enter Staff Salary: ");
                salary = double.Parse(Console.ReadLine());
                Staff s = new Staff(name, ID, designation, salary);
                StaffDL.AddStaff(s);
                break;
            }
            Console.WriteLine(" \nThe Desired Staff is Sucessfully Hired.");
            Console.WriteLine(" \n\nPress any key to continue!!!");
            Console.ReadKey();
        }
        public static void ExpellStaff()
        {
            Console.WriteLine("\t\t\t Expel Staff\n\n");
            Console.Write(" Enter Staff Name: ");
            string name = Console.ReadLine();
            Console.Write(" Enter Staff ID: ");
            string ID = Console.ReadLine();
            if (StaffDL.RemoveStaff(name, ID))
            {
                Console.WriteLine(" \nThe Desired Staff is Expelled.");
            }
            else
            {
                Console.WriteLine(" \nNo Such Staff Found.");
            }
            Console.WriteLine(" Press any key to continue!!!");
            Console.ReadKey();
        }
        public static void UpdateStaff()
        {
            Console.WriteLine("\t\t\t Update Staff Information\n\n");
            Console.Write(" Enter Staff Name: ");
            string name = Console.ReadLine();
            Console.Write(" Enter Staff ID: ");
            string ID = Console.ReadLine();
            if (StaffDL.IsStaffExist(ID))
            {
                Console.Write(" Enter Edited Staff Name: ");
                string newname = Console.ReadLine();
                Console.Write(" Enter Edited Staff Designation: ");
                string newdesignation = Console.ReadLine();
                Console.Write(" Enter Edited Staff Salary: ");
                double newsalary = double.Parse(Console.ReadLine());
                StaffDL.EditStaff(name, ID, newname, newdesignation, newsalary);
                Console.WriteLine(" \nThe Desired Staff's Information is sucessfully updated.");
            }
            else
            {
                Console.WriteLine(" \nNo Such Staff Found.");
            }
            Console.WriteLine(" \n\nPress any key to continue!!!");
            Console.ReadKey();
        }
        public static void ViewAllStaff()
        {
            Console.WriteLine("\t\t\t View AirLine Staff\n\n");
            Console.WriteLine("Staff ID\t\t\t Staff Name\t\t\t Designation\t\t\t Salary\n");
            for (int i = 0; i < StaffDL.AirlineStaff.Count; i++)
            {
                Console.WriteLine(StaffDL.AirlineStaff[i].ViewStaff());
            }
            Console.WriteLine("\n\n Press any key to Continue..");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
