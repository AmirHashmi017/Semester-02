using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Real_
{
    internal class MUserBL
    {
        private string username;
        private string password;
        private string role;
        public MUserBL(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public MUserBL(string name, string password)
        {
            this.username = name;
            this.password = password;
        }
        public string GetUsername()
        {
            return username;
        }
        public string GetPassword()
        {
            return password;
        }
        public string GetRole()
        {
            return role;
        }
        public bool IsAdmin()
        {
            return role == "admin";
        }
    }
}

