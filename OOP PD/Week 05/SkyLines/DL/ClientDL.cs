using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLines
{
    internal class ClientDL
    {
        public static List<Client> Clients = new List<Client>();

        public static void AddClient(Client client)
        {
            Clients.Add(client);
        }
        public static bool IsClientExist(string name, string password)
        {
            for (int i = 0; i < Clients.Count; i++)
            {
                if (Clients[i].ClientName == name && Clients[i].ClientPassword == password)
                {
                    return true;
                }
            }
            return false;
        }
        public static int FindClient(string name, string password)
        {
            int ClientNo = 10000;
            for (int i = 0; i < Clients.Count; i++)
            {
                if (Clients[i].ClientName == name && Clients[i].ClientPassword == password)
                {
                    ClientNo = i;
                    return ClientNo;
                }
            }
            return ClientNo;
        }
        public static bool CheckValidClientName(string name)
        {
            for (int i = 0; i < Clients.Count; i++)
            {
                if (Clients[i].ClientName == name)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
