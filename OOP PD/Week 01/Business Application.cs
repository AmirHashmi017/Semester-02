using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Business_Application
{
	class Program
	{
		static void Main(string[] args)
		{
			int s = 0;
			string[] name = new string[10];
			int i = 0;
			int c = 0;
			string resc;
			string resm;
			string[] welfare = new string[10];
			string option;
			int[] password = new int[10];
			string[] role = new string[10];
			int[] balance = new int[10];
			loadrecords(name, password, role, balance, ref s, ref i, ref c);
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
					if (signinhead(name, password, role, option, ref s, ref i, ref c))
					{
						Console.Write(" Congratulations! {0} You are signed in successfully.", name[c]);
						if (role[c] == "Client" || role[c] == "client")
						{
							//This if statement will take user to Client menu.

							while (true)
							{
								resc = client();
								if (resc == "1")
								{
									Console.Clear();

									Console.Write("\n\n\n");
									viewrecord(name, password, role, balance, ref s, ref i, ref c);
								}
								if (resc == "2")
								{
									Console.Clear();

									Console.Write("\n\n\n");
									if (depositmoney(name, password, role, balance, ref s, ref i, ref c))
										Console.Write(" Your Amount is successfully deposited.Now your Current Balance is: {0}", balance[c]);
								}
								if (resc == "3")
								{
									Console.Clear();
									Console.Clear();

									Console.Write("\n\n\n");
									if (withdrawmoney(name, password, role, balance, ref s, ref i, ref c))
										Console.Write(" Your Amount is successfully withdraw.Now your Current Balance is: {0}", balance[c]);
									else
										Console.Write(" Sorry! You don't have enough balance.");
								}
								if (resc == "4")
								{
									Console.Clear();

									Console.Write("\n\n\n");
									if (transfermoney(name, password, role, balance, ref s, ref i, ref c))
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
						else if (role[c] == "Manager" || role[c] == "manager")
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
									if (viewaccounts(name, password, role, balance, ref s, ref i, ref c))
										Console.Write(" No Clients available.");
								}
								if (resm == "2")
								{
									Console.Clear();

									Console.Write("\n\n");
									if (openaccount(name, password, role, ref s, ref i, ref c))
									{
										Console.Write(" Account of Client is  successfully Opened. ");
									}
								}
								if (resm == "3")
								{
									Console.Clear();


									Console.Write("\n\n");
									if (deleteaccount(name, password, role, balance, ref s, ref i, ref c))
										Console.Write(" Sorry! The client you want to delete does not exist.");
								}
								if (resm == "4")
								{
									Console.Clear();
									viewtotal(name, password, role, balance, ref s, ref i, ref c);
								}
								if (resm == "5")
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
						signuphead(name, password, role, ref option, ref s, ref i, ref c);
					}
					else if (option == "3")
					{
						//This if statement will terminate the program.
						Console.Clear();
						saverecordstofile(name, password, role, balance, s, i, c);
						break;
					}
				}
		}		
//This function will store records of my bank in file.

static void saverecordstofile(string[] name, int[] password, string[] role, int[] balance, int s, int i, int c)
    {
        using (StreamWriter file = new StreamWriter("bankrecords.txt"))
        {
            for (int x = 0; x < i; x++)
            {
                if (name[x] != " ")
                {
                    file.Write(name[x]);
                    file.Write(',');
                    file.Write(password[x]);
                    file.Write(',');
                    file.Write(role[x]);

                    if ((role[x] == "Manager" || role[x] == "Manager") && x != i - 1)
                        file.Write('\n');

                    if (role[x] == "Client" || role[x] == "client")
                    {
                        file.Write(',');
                        file.Write(balance[x]);

                        if (x != i - 1)
                            file.Write('\n');
                    }
                }
                   
                }
        }
        }
//This function will load the records stored in file to the arrays of program. 
static void loadrecords(string[] name,int[] password,string[] role,int[] balance,ref int s,ref int i,ref int c)
{
	i=0;
	string record = "";
				using(StreamReader file = new StreamReader("bankrecords.txt")){
				while ((record = file.ReadLine()) != null)
				{
					name[i] = getField(record, 1);
					password[i] = int.Parse(getField(record, 2));
					role[i] = getField(record, 3);
					if (role[i] == "Client" || role[i] == "client")
					{
						balance[i] = int.Parse(getField(record, 4));
					}
					i = i + 1;
				}
			}
	
}
//This function will sense the comma by which data is separated in file and helps loadrecords() function to load data in arrays.
static string getField(string record, int field)
{
	int comma=1;
	string result="";
	for (int x = 0; x < record.Length; x++)
	{
	if (record[x]==',')
	{
	comma=comma+1;
	}
	else if(comma==field)
	{
	result=result+record[x];
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
static bool signinhead(string[] name,int[] password,string[] role,string option,ref int s,ref int i,ref int c)
{
	int signinpassword;
	string signinname;
	string enter;
	while(true){
	Console.Write(" Enter UserName: ");
				signinname = Console.ReadLine();
	Console.Write(" Enter Password (Only Numbers): ");
	enter=Console.ReadLine();
	if(checkvpass(enter))
	{
		signinpassword=int.Parse(enter);
		break;
	}
	else{
	Console.Write(" Invalid Input");
		Console.Write(" \n\nPress any key to continue.");
					Console.ReadKey();
					Console.Clear();
}}
	if(signin(name,password,role,ref s,ref i,ref c,signinname,signinpassword)){
	return true;}
	else{
	return false;}
}
//This function will sign in the user.
static bool signin(string[] name,int[] password,string[] role,ref int s,ref int i,ref int c,string signinname,int signinpassword)
{

	int x=0;
	for(int n=0;n<10;n++)
	{
	if(name[n]==signinname&&password[n]==signinpassword)
	{
	c=n;
	return true;
	x=1;
	break;
	}
	}
	if(x==0)
	{
	return false;
	}
			return true;
	}
//This function will take username and password from user and passes it to sign in function.
static void signuphead(string[] name,int[] password,string[] role,ref string option,ref int s,ref int i,ref int c)
{
	int count=1;
	string na;
	string signupname;
	int signuppassword;
	string enter;
	while(true){
		Console.Write("\n\n");
	Console.Write(" Enter UserName: ");
				na = Console.ReadLine();
	Console.Write(" Enter Password (Only Numbers)(At least 4 numbers): ");
	enter=Console.ReadLine();
	if(checkvpass(enter)&&checkvalid(na)&&enter.Length>=4)
	{
		signupname=na;
		signuppassword=int.Parse(enter);
		break;
	}
	else{
	Console.Write(" Invalid Input");
		Console.Write(" \n\nPress any key to continue.");
					Console.ReadKey();
					Console.Clear();
}}
	for(int l=0;l<10;l++)
	{
	if(name[l]==signupname)
	{
	Console.Write(" Sorry this account already exist.");
	Console.Write(" \n\nPress any key to continue.");
					Console.ReadKey();
	count=0;
	break;
	}
	}
	string rol;
	if(count==1)
	{
	while(true){
	Console.Write(" Enter your role (Manager/Client): ");
	rol=Console.ReadLine();
	if(rol!="Manager"&&rol!="Client"){
		Console.Write("Invalid Input.");
		Console.Write(" \n\nPress any key to continue.");
	Console.ReadKey();
	Console.Write("\n\n\n");
	}
	else{
	role[i]=rol;
	break;}
}
	signup(name,password,role,ref s,ref i,ref c,signupname,signuppassword);
	Console.Write(" Congratulations !{0}  You are sucessfully signed up.", name[i]);
	Console.Write(" \n\nPress any key to continue.");
	Console.ReadKey();
	Console.Write("\n");
	i=i+1;
	}
	}
//This function will sign in the user.
static void signup(string[] name,int[] password,string[] role,ref int s,ref int i,ref int c,string signupname,int signuppassword)
{
	name[i]=signupname;
	password[i]=signuppassword;
}
//This function will check validation of comma.
static bool checkvalid(string na)
{
	for(int i=0;i<na.Length;i++)
	{
		if(na[i]==',')
		return false;
	}
	return true;
}
//This function will display tasks that manager can perform,takes input from manager and returns it to main function.
static string manager()
{
	string choose;
	while(true){
	Console.Write("\n\n\n");
	Console.Write(" Select one of the following Option Number..\n");
	Console.WriteLine(" Option 1: View Records of Clients"); 
	Console.WriteLine(" Option 2: Open Account");
	Console.WriteLine(" Option 3: Delete Account");
	Console.WriteLine(" Option 4: View Total balance");
	Console.WriteLine(" Option 5:Log Out");
	Console.Write(" Enter option number:");
	choose=Console.ReadLine();
	if(choose!="1"&&choose!="2"&&choose!="3"&&choose!="4"&&choose!="5")
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
	while(true){	
	Console.Write("\n\n\n");
	Console.Write(" Select one of the following Option Number..\n");
	Console.WriteLine(" Option 1: View Account Status"); 
	Console.WriteLine(" Option 2: Deposit Money");
	Console.WriteLine(" Option 3: Withdraw Money");
	Console.WriteLine(" Option 4: Transfer Donations");
	Console.WriteLine(" Option 5:Log Out");
	Console.Write(" Enter option number:");
	choice=Console.ReadLine();
	if(choice!="1"&&choice!="2"&&choice!="3"&&choice!="4"&&choice!="5")
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
	for(int p=0;p<enter.Length;p++)
	{
		if(enter[p]!='1'&&enter[p]!='2'&&enter[p]!='3'&&enter[p]!='4'&&enter[p]!='5'&&enter[p]!='6'&&enter[p]!='7'&&enter[p]!='8'&&enter[p]!='9')
		return false;
		break;
	}
	return true;
}
//This function will check validation of password.
static bool checkvpass(string enter)
{
	for(int i=0;i<enter.Length;i++)
	{
		if(enter[i]!='0'&&enter[i]!='1'&&enter[i]!='2'&&enter[i]!='3'&&enter[i]!='4'&&enter[i]!='5'&&enter[i]!='6'&&enter[i]!='7'&&enter[i]!='8'&&enter[i]!='9')
		return false;
	}
	return true;
}
//This function will show the accounts details of all clients in bank to manager.
static bool viewaccounts(string[] name,int[] password,string[] role,int[] balance,ref int s,ref int i,ref int c)
{
	int count=0;
    for(int x=0;x<name.Length;x++)
	{
    if((role[x]=="Client"||role[x]=="client")&&name[x]!=" ")
    count++;
	}
	if(count!=0)
	{
				Console.WriteLine(" NAME\t\tCurrent Balance");
    for(int p=0;p<name.Length;p++)
	{
					if ((role[p] == "Client" || role[p] == "client") && name[p] != " ")
						Console.WriteLine($" {name[p]}\t\t{balance[p]}");
	}
				return false;
	}
	else
	return true;
}
//This function will show client his account details.
static void viewrecord(string[] name,int[] password,string[] role,int[] balance,ref int s,ref int i,ref int c)
{
			Console.WriteLine(" NAME\t\tCurrent Balance");
	Console.WriteLine($" {name[c]}\t\t{balance[c]}");
}
//Client will use this function to deposit money.
static bool depositmoney(string[] name,int[] password,string[] role,int[] balance,ref int s,ref int i,ref int c)
{
	int depositamount;
	string enter;
	while(true){
	Console.Write(" Enter the amount you want to deposit: ");
	enter=Console.ReadLine();
	if(checkvalidation(enter))
	{
		depositamount=int.Parse(enter);
		break;
	}
	else{
	Console.Write(" Invalid Input");
		Console.Write(" \n\nPress any key to continue.");
					Console.ReadKey();
	Console.Write("\n\n\n");}
}
	if(depositamount>0){
	balance[c]+=depositamount;
	return true;}
	else
	return false;
}
//Client will use this function to withdraw money.
static bool withdrawmoney(string[] name,int[] password,string[] role,int[] balance,ref int s,ref int i,ref int c)
	{
	int withdrawamount;
	string enter;
	while(true){
	Console.Write(" Enter the amount you want to withdraw: ");
				enter = Console.ReadLine(); ;
	if(checkvalidation(enter))
	{
		withdrawamount=int.Parse(enter);
		break;
	}
	else{
	Console.Write(" Invalid Input");
		Console.Write(" \n\nPress any key to continue.");
					Console.ReadKey();
	Console.Write("\n\n\n");
}
}
	if(balance[c]>=withdrawamount)
	{
	balance[c]-=withdrawamount;
	return true;
	}
	else
	return false;
	}
		static bool transfermoney(string[] name, int[] password, string[] role, int[] balance, ref int s, ref int i, ref int c)
		{
	int transferamount;
	string enter;
	while(true){
	Console.Write(" Enter the amount of donations you want to transfer: ");
	enter=Console.ReadLine();
	if(checkvalidation(enter))
	{
		transferamount=int.Parse(enter);
		break;
	}
	else{
	Console.Write(" Invalid Input");
		Console.Write(" \n\nPress any key to continue.");
					Console.ReadKey();
	Console.Write("\n\n\n");
	}
}
	Console.Write(" Enter the welfare to which yo want to transfer donations: ");
	string welfare=Console.ReadLine();
	if(balance[c]>=transferamount)
	{
	balance[c]-=transferamount;
	return true;
	}
	else
	return false;
}

		//This function will display the total balance of clients and loan taken bt clients to manager.
		static void viewtotal(string[] name, int[] password, string[] role, int[] balance, ref int s, ref int i, ref int c)
		{
			int totalb = 0;
			for (int n = 0; n < name.Length; n++) {
				totalb = totalb + balance[n];
 }
			Console.Write(" \nTotal Clients Balance in Bank is: {0} ",totalb );
		}

//Manager can open account of client with the help of this function.
static bool openaccount(string[] name,int[] password,string[] role,ref int s,ref int i,ref int c)
{
	string enter;
	int x=0;
	while(true)
	{
	if(x==name.Length-5)
	{
	c=x;
	break;
	}
	x++;
	}
	while(true){
	Console.Write(" Enter Client Name: ");
	name[c]=Console.ReadLine();
	Console.Write(" Enter Client Password (only Numbers): ");
	enter=Console.ReadLine();
	if(checkvpass(enter))
	{
		password[c]=int.Parse(enter);
		break;
	}
	else{
	Console.Write(" Invalid Input");
		Console.Write(" \n\nPress any key to continue.");
					Console.ReadKey();
					Console.Clear();
				}}
	role[c]="Client";	
	c++;
	i++;
	return true;	
}
//Manager can delete account of client with the help of this function.
static bool deleteaccount(string[] name,int[] password,string[] role,int[] balance,ref int s,ref int i,ref int c)
{
	int p=-1;
	string namen;
	string enter;
	int passwordn;
	while(true){
	Console.Write(" Enter Client Name: ");
	namen=Console.ReadLine();
	Console.Write(" Enter Client Password (only Numbers): ");
	enter=Console.ReadLine();
	if(checkvpass(enter))
	{
		passwordn=int.Parse(enter);
		break;
	}
	else{
	Console.Write(" Invalid Input");
		Console.Write(" \n\nPress any key to continue.");
					Console.ReadKey();
					Console.Clear();
				}}
	for(int x=0;x < name.Length;x++)
	{
	if(name[x]==namen)
	{
	p=x;
	break;
	}
	}
	if(p!=-1)
	{
	Console.Write(" Account of Client {0} is  deleted. ", name[p]);
	name[p]=" ";
	balance[p]=0;
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


        }
    }
