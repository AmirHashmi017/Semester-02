using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01__Lab_06_
{
    internal class Author
    {
        private string Name;
        private string Email;

        public Author(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetEmail()
        {
            return Email;
        }
    }
}

