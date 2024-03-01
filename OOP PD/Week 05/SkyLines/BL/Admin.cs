using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLines
{
    internal class Admin
    {
        public string AdminName;
        public string AdminPassword;
        public string Role;

        public Admin(string name, string password, string role)
        {
            this.AdminName = name;
            this.AdminPassword = password;
            this.Role = role;
        }
    }
}
