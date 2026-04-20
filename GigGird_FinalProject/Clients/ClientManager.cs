using System;
using System.Collections.Generic;
using System.Text;

namespace GigGird_FinalProject.Clients
{
    public class ClientManager
    {
        //TODO: Group clients by project?
        //TODO: Figure out what this actually needs
        /*                 Console.WriteLine("CLIENT MENU" +
                    "\nWhere would you like to go?" +
                    "\n     0. Return to Main Menu" +
                    "\n     1. View Current Clients " +
                    "\n     2. View All Clients " +
                    "\n     3. Add New Client " +
                    "\n     4. Archive Client ");
                    */
        public List<Client> CurrentClients;
        public List<Client> PastClients;
        public List<Client> AllClients;

        public void DisplayCurrentClients() {}
        public void DisplayAllClients() {}
        public void AddNewClient() {}
        public void ArchiveClient() {}
        public void UnArchiveClient() {}
    }
}
