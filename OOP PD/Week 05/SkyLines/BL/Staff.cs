using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLines
{
    internal class Staff
    {
        public string StaffName;
        public string StaffID;
        public string StaffDesignation;
        public double StaffSalary;

        public Staff(string name, string ID, string designation, double salary)
        {
            this.StaffName = name;
            this.StaffID = ID;
            this.StaffDesignation = designation;
            this.StaffSalary = salary;
        }
        public string ViewStaff()
        {
            return ($" {StaffID}\t\t\t \t{StaffName}\t\t\t\t {StaffDesignation}\t\t\t\t{StaffSalary}");
        }
    }
}
