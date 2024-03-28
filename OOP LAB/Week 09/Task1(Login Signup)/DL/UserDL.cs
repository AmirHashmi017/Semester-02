using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task1_Real_
{
    internal class MUserDL
    {
        private static List<MUserBL> users = new List<MUserBL>();
        public static void AddUser(MUserBL user)
        {
            users.Add(user);
        }
        public static MUserBL SignIn(MUserBL user)
        {
            foreach (MUserBL storedUser in users)
            {
                if (storedUser.GetUsername() == user.GetUsername() && storedUser.GetPassword() == user.GetPassword())
                {
                    return storedUser;
                }
            }
            return null;
        }
        public static string ParseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    comma++;
                    continue;
                }
                if (comma == field)
                {
                    item += record[i];
                }
            }
            return item;
        }
        public static bool ReadDataFromFile()
        {
            string path= "G:\\Task1(Login Signup)\\UserRecord.txt";
            if (File.Exists(path))
            {
                StreamReader reader = new StreamReader(path);
                string record;
                while ((record = reader.ReadLine()) != null)
                {
                    string username = ParseData(record, 1);
                    string password = ParseData(record, 2);
                    string role = ParseData(record, 3);
                    MUserBL user = new MUserBL(username, password, role);
                    AddUser(user);
                }
                reader.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void StoreUserInFile(MUserBL user)
        {
            string path= "G:\\Task1(Login Signup)\\UserRecord.txt";
            StreamWriter writer = new StreamWriter(path, true);
            writer.Write(user.GetUsername() + "," +user.GetPassword() + "," + user.GetRole());
            writer.Flush();
            writer.Close();

        }

    }
}

