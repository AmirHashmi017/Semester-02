using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLines
{
    internal class StaffDL
    {
        public static List<Staff> AirlineStaff = new List<Staff>();

        public static void AddStaff(Staff s)
        {
            AirlineStaff.Add(s);
        }
        public static bool RemoveStaff(string name, string staffID)
        {
            for (int i = 0; i < AirlineStaff.Count; i++)
            {
                if (AirlineStaff[i].StaffName == name && AirlineStaff[i].StaffID == staffID)
                {
                    AirlineStaff.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public static void EditStaff(string name, string staffID, string newname, string newdesignation, double newsalary)
        {
            for (int i = 0; i < AirlineStaff.Count; i++)
            {
                if (AirlineStaff[i].StaffName == name && AirlineStaff[i].StaffID == staffID)
                {
                    AirlineStaff[i].StaffName = newname;
                    AirlineStaff[i].StaffDesignation = newdesignation;
                    AirlineStaff[i].StaffSalary = newsalary;
                    break;
                }
            }
        }
        public static bool CheckValidStaffID(string ID)
        {
            for (int i = 0; i < AirlineStaff.Count; i++)
            {
                if (AirlineStaff[i].StaffID == ID)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsStaffExist(string ID)
        {
            for (int i = 0; i < AirlineStaff.Count; i++)
            {
                if (AirlineStaff[i].StaffID == ID)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
