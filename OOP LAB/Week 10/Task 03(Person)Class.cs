using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Person
    {
        protected string Name;
        protected string Adress;

        public Person(string name, string adress)
        {
            Name = name;
            Adress = adress;
        }
        public string GetName()
        { return Name; }
        public string GetAdress()
        { return Adress; }
        public void SetAdress(string Adress)
        { this.Adress=Adress; }
        public string To_String()
            {
            return ($" Name: {Name}\t Adress: {Adress}");
        }
    }
}
