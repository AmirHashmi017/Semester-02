using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            int s = 0;
            int[] balance = new int[10];
            int i = 0;
            int c = 0;
            string resc;
            string resm;
            string[] welfare = new string[10];
            string option;
            List<login> Logins = new List<login>();
            StreamWriter file = new StreamWriter("bankrecords.txt");
            loadrecords(Logins, balance, ref s, ref i, ref c);
            //This loop will continuously display user their respective menu and take input from user until the user press exit.
            while (true)
            {
                Console.Clear();
                header();
                Console.Write("\n\n\n");
                while (true)
                {
                    Console.WriteLine("1. SIGN IN");
                    Console.WriteLine("2. SIGN UP");
                    Console.WriteLine("3. EXIT");
                    Console.Write("\n");
                    Console.Write("Enter Option: ");
                    option = (Console.ReadLine());
                    if (option == "1" || option == "2" || option == "3")
                        break;
                    else
                    {
                        Console.Write(" Invalid Input.");
                        Console.Write(" \n\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                Console.Clear();
                if (option == "1")
                {
                    if (signinhead(Logins, option, ref s, ref i, ref c))
                    {
                        Console.Write(" Congratulations! {0} You are signed in successfully.", Logins[c].name);
                        if (Logins[c].role == "Client" || Logins[c].role == "client")
                        {
                            //This if statement will take user to Client menu.

                            while (true)
                            {
                                resc = client();
                                if (resc == "1")
                                {
                                    Console.Clear();

                                    Console.Write("\n\n\n");
                                    viewrecord(Logins, balance, ref s, ref i, ref c);
                                }
                                if (resc == "2")
                                {
                                    Console.Clear();

                                    Console.Write("\n\n\n");
                                    if (depositmoney(Logins, balance, ref s, ref i, ref c))
                                        Console.Write(" Your Amount is successfully deposited.Now your Current Balance is: {0}", balance[c]);
                                }
                                if (resc == "3")
                                {
                                    Console.Clear();
                                    Console.Clear();

                                    Console.Write("\n\n\n");
                                    if (withdrawmoney(Logins, balance, ref s, ref i, ref c))
                                        Console.Write(" Your Amount is successfully withdraw.Now your Current Balance is: {0}", balance[c]);
                                    else
                                        Console.Write(" Sorry! You don't have enough balance.");
                                }
                                if (resc == "4")
                                {
                                    Console.Clear();

                                    Console.Write("\n\n\n");
                                    if (transfermoney(Logins, balance, ref s, ref i, ref c))
                                        Console.Write(" Your donations is successfully transfered. Now your Current Balance is: {0}", balance[c]);
                                    else
                                        Console.Write(" Sorry! You don't have enough balance.");
                                }
                                if (resc == "5")
                                {
                                    exit();
                                    break;
                                }
                                Console.Write(" \n\n Press any key to continue: ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else if (Logins[c].role == "Manager" || Logins[c].role == "manager")
                        {
                            //This if statement will take user to Manager menu.
                            Console.Clear();
                            while (true)
                            {
                                resm = manager();
                                if (resm == "1")
                                {
                                    Console.Clear();


                                    Console.Write("\n\n");
                                    if (viewaccounts(Logins, balance, ref s, ref i, ref c))
                                        Console.Write(" No Clients available.");
                                }
                                if (resm == "2")
                                {
                                    Console.Clear();

                                    Console.Write("\n\n");
                                    if (openaccount(Logins, ref s, ref i, ref c))
                                    {
                                        Console.Write(" Account of Client is  successfully Opened. ");
                                    }
                                }
                                if (resm == "3")
                                {
                                    Console.Clear();


                                    Console.Write("\n\n");
                                    if (deleteaccount(Logins, balance, ref s, ref i, ref c))
                                        Console.Write(" Sorry! The client you want to delete does not exist.");
                                }
                                if (resm == "4")
                                {
                                    Console.Clear();
                                    viewtotal(Logins, balance, ref s, ref i, ref c);
                                }
                                if (resm == "5")
                                {
                                    Console.Clear();
                                    Console.Write("\n\n");
                                    if (updateaccount(Logins))
                                        Console.Write(" The client is successfully updated.");
                                    else
                                        Console.Write(" Sorry! The client you want to update does not exist.");
                                }
                                if (resm == "6")
                                {
                                    if (exit())
                                        break;
                                }
                                Console.WriteLine(" \n\n Press any key to continue: ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                    }
                    else
                    {
                        Console.Write("You don't have an account.Please sign up.");
                        Thread.Sleep(1500);
                        Console.Clear();
                    }
                }

                else if (option == "2")
                {
                    //This if statement will take user to sign up menu.
                    signuphead(Logins, ref option, ref s, ref i, ref c);
                }
                else if (option == "3")
                {
                    //This if statement will terminate the program.
                    Console.Clear();
                    saverecordstofile(Logins, balance, s, i, c);
                    break;
                }
            }
        }
        //This function will store records of my bank in file.

        static void saverecordstofile(List<login> Logins, int[] balance, int s, int i, int c)
        {
            string filepath = "C:\\Users\\Student\\Documents\\R\\R-3.3.2\\bankrecords.txt";
            StreamWriter file = new StreamWriter(filepath, false);
                for (int x = 0; x < i; x++)
                {
                    if (Logins[x].name != " ")
                    {
                        file.Write(Logins[x].name);
                        file.Write(',');
                        file.Write(Logins[x].password);
                        file.Write(',');
                        file.Write(Logins[x].role);

                        if ((Logins[x].role == "Manager" || Logins[x].role == "Manager") && x != i - 1)
                            file.Write('\n');

                        if (Logins[x].role == "Client" || Logins[x].role == "client")
                        {
                            file.Write(',');
                            file.Write(balance[x]);

                            if (x != i - 1)
                                file.Write('\n');
                        }
                    }
                file.Flush();
                }
            file.Close();
            }
        //This function will load the records stored in file to the arrays of program. 
        static void loadrecords(List<login> Logins, int[] balance, ref int s, ref int i, ref int c)
        {
            i = 0;
            string record = "";
            string filepath = "C:\\Users\\Student\\Documents\\R\\R-3.3.2\\bankrecords.txt";
            if (File.Exists(filepath))
            {
                using (StreamReader file = new StreamReader(filepath)) { 
                    while ((record = file.ReadLine()) != null)
                    {
                        login u1 = new login("amir", 1234, "Client");
                        Logins.Add(u1);
                        Logins[i].name = getField(record, 1);
                        Logins[i].password = int.Parse(getField(record, 2));
                        Logins[i].role = getField(record, 3);
                        if (Logins[i].role == "Client" || Logins[i].role == "client")
                        {
                            balance[i] = int.Parse(getField(record, 4));
                        }
                        i = i + 1;
                    }}
            }

        }
        //This function will sense the comma by which data is separated in file and helps loadrecords() function to load data in arrays.
        static string getField(string record, int field)
        {
            int comma = 1;
            string result = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma = comma + 1;
                }
                else if (comma == field)
                {
                    result = result + record[x];
                }
            }
            return result;
        }
        //This function will print header.
        static void header()
        {
            Console.Write("\t\t\tHEAVEN'S BANK\n\n");
        }
        //This function will take username and password from user and passes it to sign in function.
        static bool signinhead(List<login> Logins, string option, ref int s, ref int i, ref int c)
        {
            int signinpassword;
            string signinname;
            string enter;
            while (true)
            {
                Console.Write(" Enter UserName: ");
                signinname = Console.ReadLine();
                Console.Write(" Enter Password (Only Numbers): ");
                enter = Console.ReadLine();
                if (checkvpass(enter))
                {
                    signinpassword = int.Parse(enter);
                    break;
                }
                else
                {
                    Console.Write(" Invalid Input");
                    Console.Write(" \n\nPress any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            if (signin(Logins, ref s, ref i, ref c, signinname, signinpassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //This function will sign in the user.
        static bool signin(List<login> Logins, ref int s, ref int i, ref int c, string signinname, int signinpassword)
        {

            int x = 0;
            for (int n = 0; n < Logins.Count; n++)
            {
                if (Logins[n].name == signinname && Logins[n].password == signinpassword)
                {
                    c = n;
                    return true;
                    x = 1;
                    break;
                }
            }
            if (x == 0)
            {
                return false;
            }
            return true;
        }
        //This function will take username and password from user and passes it to sign in function.
        static void signuphead(List<login> Logins, ref string option, ref int s, ref int i, ref int c)
        {
            int count = 1;
            string na;
            string signupname;
            int signuppassword;
            string enter;
            while (true)
            {
                Console.Write("\n\n");
                Console.Write(" Enter UserName: ");
                na = Console.ReadLine();
                Console.Write(" Enter Password (Only Numbers)(At least 4 numbers): ");
                enter = Console.ReadLine();
                if (checkvpass(enter) && checkvalid(na) && enter.Length >= 4)
                {
                    signupname = na;
                    signuppassword = int.Parse(enter);
                    break;
                }
                else
                {
                    Console.Write(" Invalid Input");
                    Console.Write(" \n\nPress any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            for (int l = 0; l<Logins.Count; l++)
            {
                if (Logins[l].name == signupname)
                {
                    Console.Write(" Sorry this account already exist.");
                    Console.Write(" \n\nPress any key to continue.");
                    Console.ReadKey();
                    count = 0;
                    break;
                }
            }
            string rol;
            if (count == 1)
            {
                while (true)
                {
                    Console.Write(" Enter your role (Manager/Client): ");
                    rol = Console.ReadLine();
                    if (rol != "Manager" && rol != "Client")
                    {
                        Console.Write("Invalid Input.");
                        Console.Write(" \n\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Write("\n\n\n");
                    }
                    else
                    {
                        break;
                    }
                }
                signup(Logins, ref s, ref i, ref c, signupname, signuppassword, rol);
                Console.Write(" Congratulations !{0}  You are sucessfully signed up.", Logins[i].name);
                Console.Write(" \n\nPress any key to continue.");
                Console.ReadKey();
                Console.Write("\n");
                i = i + 1;
            }
        }
        //This function will sign in the user.
        static void signup(List<login> Logins, ref int s, ref int i, ref int c, string signupname, int signuppassword, string rol)
        {
            login u1 = new login(signupname, signuppassword, rol);
            Logins.Add(u1);
        }
        //This function will check validation of comma.
        static bool checkvalid(string na)
        {
            for (int i = 0; i < na.Length; i++)
            {
                if (na[i] == ',')
                    return false;
            }
            return true;
        }
        //This function will display tasks that manager can perform,takes input from manager and returns it to main function.
        static string manager()
        {
            string choose;
            while (true)
            {
                Console.Write("\n\n\n");
                Console.Write(" Select one of the following Option Number..\n");
                Console.WriteLine(" Option 1: View Records of Clients");
                Console.WriteLine(" Option 2: Open Account");
                Console.WriteLine(" Option 3: Delete Account");
                Console.WriteLine(" Option 4: View Total balance");
                Console.WriteLine(" Option 5: Update Account");
                Console.WriteLine(" Option 6:Log Out");
                Console.Write(" Enter option number:");
                choose = Console.ReadLine();
                if (choose != "1" && choose != "2" && choose != "3" && choose != "4" && choose != "5" && choose != "6")
                {
                    Console.Write(" Invalid Input.");
                    Console.Write(" \n\nPress any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                    break;
            }
            return choose;

        }
        //This function will display tasks that client can perform,takes input from client and returns it to main function.
        static string client()
        {
            Console.Clear();
            string choice;
            while (true)
            {
                Console.Write("\n\n\n");
                Console.Write(" Select one of the following Option Number..\n");
                Console.WriteLine(" Option 1: View Account Status");
                Console.WriteLine(" Option 2: Deposit Money");
                Console.WriteLine(" Option 3: Withdraw Money");
                Console.WriteLine(" Option 4: Transfer Donations");
                Console.WriteLine(" Option 5:Log Out");
                Console.Write(" Enter option number:");
                choice = Console.ReadLine();
                if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5")
                {
                    Console.Write(" Invalid Input.");
                    Console.Write(" \n\nPress any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                    break;
            }
            return choice;
        }
        //This function will check that the user input is valid on not.
        static bool checkvalidation(string enter)
        {
            for (int p = 0; p < enter.Length; p++)
            {
                if (enter[p] != '1' && enter[p] != '2' && enter[p] != '3' && enter[p] != '4' && enter[p] != '5' && enter[p] != '6' && enter[p] != '7' && enter[p] != '8' && enter[p] != '9')
                    return false;
                break;
            }
            return true;
        }
        //This function will check validation of password.
        static bool checkvpass(string enter)
        {
            for (int i = 0; i < enter.Length; i++)
            {
                if (enter[i] != '0' && enter[i] != '1' && enter[i] != '2' && enter[i] != '3' && enter[i] != '4' && enter[i] != '5' && enter[i] != '6' && enter[i] != '7' && enter[i] != '8' && enter[i] != '9')
                    return false;
            }
            return true;
        }
        //This function will show the accounts details of all clients in bank to manager.
        static bool viewaccounts(List<login> Logins, int[] balance, ref int s, ref int i, ref int c)
        {
            int count = 0;
            for (int x = 0; x < Logins.Count; x++)
            {
                if ((Logins[x].role == "Client" || Logins[x].role == "client") && Logins[x].name != " ")
                    count++;
            }
            if (count != 0)
            {
                Console.WriteLine(" NAME\t\tCurrent Balance");
                for (int p = 0; p < Logins.Count; p++)
                {
                    if ((Logins[p].role == "Client" || Logins[p].role == "client") && Logins[p].name != " ")
                        Console.WriteLine($" {Logins[p].name}\t\t{balance[p]}");
                }
                return false;
            }
            else
                return true;
        }
        //This function will show client his account details.
        static void viewrecord(List<login> Logins, int[] balance, ref int s, ref int i, ref int c)
        {
            Console.WriteLine(" NAME\t\tCurrent Balance");
            Console.WriteLine($" {Logins[c].name}\t\t{balance[c]}");
        }
        //Client will use this function to deposit money.
        static bool depositmoney(List<login> Logins, int[] balance, ref int s, ref int i, ref int c)
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
                balance[c] += depositamount;
                return true;
            }
            else
                return false;
        }
        //Client will use this function to withdraw money.
        static bool withdrawmoney(List<login> Logins, int[] balance, ref int s, ref int i, ref int c)
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
            if (balance[c] >= withdrawamount)
            {
                balance[c] -= withdrawamount;
                return true;
            }
            else
                return false;
        }
        static bool transfermoney(List<login> Logins, int[] balance, ref int s, ref int i, ref int c)
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
            if (balance[c] >= transferamount)
            {
                balance[c] -= transferamount;
                return true;
            }
            else
                return false;
        }

        //This function will display the total balance of clients and loan taken bt clients to manager.
        static void viewtotal(List<login> Logins, int[] balance, ref int s, ref int i, ref int c)
        {
            int totalb = 0;
            for (int n = 0; n < Logins.Count; n++)
            {
                totalb = totalb + balance[n];
            }
            Console.Write(" \nTotal Clients Balance in Bank is: {0} ", totalb);
        }

        //Manager can open account of client with the help of this function.
        static bool openaccount(List<login> Logins, ref int s, ref int i, ref int c)
        {
            string signupname = "";
            int signuppassword = 0;
            string enter;
            int x = 0;
            while (true)
            {
                if (x == Logins.Count - 5)
                {
                    c = x;
                    break;
                }
                x++;
            }
            while (true)
            {
                Console.Write(" Enter Client Name: ");
                signupname = Console.ReadLine();
                Console.Write(" Enter Client Password (only Numbers): ");
                enter = Console.ReadLine();
                if (checkvpass(enter))
                {
                    signuppassword = int.Parse(enter);
                    break;
                }
                else
                {
                    Console.Write(" Invalid Input");
                    Console.Write(" \n\nPress any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            string rol = "Client";
            login u1 = new login(signupname, signuppassword, rol);
            Logins.Add(u1);
            c++;
            i++;
            return true;
        }
        //Manager can delete account of client with the help of this function.
        static bool deleteaccount(List<login> Logins, int[] balance, ref int s, ref int i, ref int c)
        {
            int p = -1;
            string namen;
            string enter;
            int passwordn;
            while (true)
            {
                Console.Write(" Enter Client Name: ");
                namen = Console.ReadLine();
                Console.Write(" Enter Client Password (only Numbers): ");
                enter = Console.ReadLine();
                if (checkvpass(enter))
                {
                    passwordn = int.Parse(enter);
                    break;
                }
                else
                {
                    Console.Write(" Invalid Input");
                    Console.Write(" \n\nPress any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            for (int x = 0; x < Logins.Count; x++)
            {
                if (Logins[x].name == namen)
                {
                    p = x;
                    break;
                }
            }
            if (p != -1)
            {
                Console.Write(" Account of Client {0} is  deleted. ", Logins[p].name);
                Logins.RemoveAt(p);
                return false;
            }
            else
            {
                return true;
            }
        }
        //This function will exit manager and client from their menus and place them in sign in or sign up options.
        static bool exit()
        {
            Console.Clear();
            return true;
        }
        static bool updateaccount(List<login> Logins)
        {
            Console.Write("Enter name of client you want to update:  ");
            string na = Console.ReadLine();
            Console.Write("Enter password of client you want to update:  ");
            int pass = int.Parse(Console.ReadLine());
            int p = 0;
            int count = 0;
            for(int i=0;i<Logins.Count;i++)
            {
                if (na == Logins[i].name && pass == Logins[i].password)
                {
                    p = i;
                    count++;
                }
            }
            if (p != 0)
            {
                Console.Write("Enter updated name:  ");
                Logins[p].name = Console.ReadLine();
                Console.Write("Enter updated Password:  ");
                Logins[p].password = int.Parse(Console.ReadLine());
            }
            if (count == 0)
                return false;
                return true;
        }
       

    }
}

