using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLines
{
    internal class AdminDL
    {
        public static List<Admin> Admins = new List<Admin>();

        public static void AddAdmin(Admin admin)
        {
            Admins.Add(admin);
        }
        public static bool IsAdminExist(string name, string password)
        {
            for (int i = 0; i < Admins.Count; i++)
            {
                if (Admins[i].AdminName == name && Admins[i].AdminPassword == password)
                {
                    return true;
                }
            }
            return false;
        }
        public static int FindAdmin(string name, string password)
        {
            int AdminNo = 1000;
            for (int i = 0; i < Admins.Count; i++)
            {
                if (Admins[i].AdminName == name && Admins[i].AdminPassword == password)
                {
                    AdminNo = i;
                    return AdminNo;
                }
            }
            return AdminNo;
        }
        public static bool CheckValidAdminName(string name)
        {
            for (int i = 0; i < Admins.Count; i++)
            {
                if (Admins[i].AdminName == name)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
