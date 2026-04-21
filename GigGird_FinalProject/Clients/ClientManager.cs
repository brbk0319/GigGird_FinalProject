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

        public void DisplayCurrentClients()
        {
            foreach (var client in CurrentClients)
            {
                Console.WriteLine($"{client.Name}");
                Console.WriteLine("  Ongoing Projects:");
                foreach (var project in client.OngoingContracts)
                {
                    Console.WriteLine("   " + project.ProjectType.Name);
                }
                Console.WriteLine("  Completed Projects:");
                foreach (var project in client.CompletedContracts)
                {
                    Console.WriteLine("   " + project.ProjectType.Name);
                }
            }
        }
        public void DisplayAllClients()
        {
            foreach (var client in AllClients)
            {
                Console.WriteLine($"{client.Name}");
                Console.WriteLine("  Ongoing Projects:");
                foreach (var project in client.OngoingContracts)
                {
                    Console.WriteLine("   " + project.ProjectType.Name);
                }
                Console.WriteLine("  Completed Projects:");
                foreach (var project in client.CompletedContracts)
                {
                    Console.WriteLine("   " + project.ProjectType.Name);
                }
            }
        }
        public void AddNewClient()
        {
            Console.Write("Client's Name: ");
            string name = Console.ReadLine();

            Console.Write("\nClient's Contact: ");
            string contact = Console.ReadLine();
            Client client = new Client(name, contact);
        }

    }
}
