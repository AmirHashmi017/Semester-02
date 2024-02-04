using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class login
    {

        public string name;
        public int password;
        public string role;
        public int balance;
        public login(string signupname, int signuppassword, string rol, int balance)
        {
            this.name = signupname;
            this.password = signuppassword;
            this.role = rol;
            this.balance = balance;
        }
        //This function will sign up the user.
        public login signup(string signupname, int signuppassword, string rol)
        {
            login u1 = new login(signupname, signuppassword, rol, 0);
            return u1;
        }
        //This function will show client his account details.
        public void viewrecord()
        {
            Console.WriteLine(" NAME\t\tCurrent Balance");
            Console.WriteLine($" {name}\t\t{balance}");
        }
        //Client will use this function to deposit money.
        public bool depositmoney()
        {
            int depositamount;
            string enter;
            while (true)
            {
                Console.Write(" Enter the amount you want to deposit: ");
                enter = Console.ReadLine();
                if (checkvalidation(enter))
                {
                    depositamount = int.Parse(enter);
                    break;
                }
                else
                {
                    Console.Write(" Invalid Input");
                    Console.Write(" \n\nPress any key to continue.");
                    Console.ReadKey();
                    Console.Write("\n\n\n");
                }
            }
            if (depositamount > 0)
            {
                balance += depositamount;
                return true;
            }
            else
                return false;
        }
        //Client will use this function to withdraw money.
        public bool withdrawmoney()
        {
            int withdrawamount;
            string enter;
            while (true)
            {
                Console.Write(" Enter the amount you want to withdraw: ");
                enter = Console.ReadLine(); ;
                if (checkvalidation(enter))
                {
                    withdrawamount = int.Parse(enter);
                    break;
                }
                else
                {
                    Console.Write(" Invalid Input");
                    Console.Write(" \n\nPress any key to continue.");
                    Console.ReadKey();
                    Console.Write("\n\n\n");
                }
            }
            if (balance >= withdrawamount)
            {
                balance -= withdrawamount;
                return true;
            }
            else
                return false;
        }
        public bool transfermoney()
        {
            int transferamount;
            string enter;
            while (true)
            {
                Console.Write(" Enter the amount of donations you want to transfer: ");
                enter = Console.ReadLine();
                if (checkvalidation(enter))
                {
                    transferamount = int.Parse(enter);
                    break;
                }
                else
                {
                    Console.Write(" Invalid Input");
                    Console.Write(" \n\nPress any key to continue.");
                    Console.ReadKey();
                    Console.Write("\n\n\n");
                }
            }
            Console.Write(" Enter the welfare to which yo want to transfer donations: ");
            string welfare = Console.ReadLine();
            if (balance >= transferamount)
            {
                balance -= transferamount;
                return true;
            }
            else
                return false;
        }
        public bool checkvalidation(string enter)
        {
            for (int p = 0; p < enter.Length; p++)
            {
                if (enter[p] != '1' && enter[p] != '2' && enter[p] != '3' && enter[p] != '4' && enter[p] != '5' && enter[p] != '6' && enter[p] != '7' && enter[p] != '8' && enter[p] != '9')
                    return false;
                break;
            }
            return true;
        }
    }
}

