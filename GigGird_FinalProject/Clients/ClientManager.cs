using System;
using System.Collections.Generic;
using System.Text;

namespace GigGird_FinalProject.Clients
{
    public class ClientManager
    {

        public List<Client> CurrentClients;
        public List<Client> PastClients;
        public List<Client> AllClients;

        public void DisplayCurrentClients()
        {
            foreach (var client in CurrentClients)
            {
                Console.WriteLine($"{client.Name}\n--------------------");
                Console.WriteLine("  ONGOING PROJECTS");

                var currentByDeadline = client.OngoingProjects
                    .OrderByDescending(p => p.ProjectContract.Deadline)
                    .ThenBy(p => p.ProjectType.PriceRate)
                    .ToList();

                foreach (var project in currentByDeadline)
                {
                    Console.WriteLine($"   Project Type - {project.ProjectType.Name}" +
                        $"\n     Project Rate - ${project.ProjectType.PriceRate}");
                }

                var completeByDeadline = client.CompletedProjects
                    .OrderByDescending(p => p.ProjectContract.Deadline)
                    .ThenBy(p => p.ProjectType.PriceRate)
                    .ToList();

                Console.WriteLine("  COMPLETED PROJECTS");
                foreach (var project in completeByDeadline)
                {
                    Console.WriteLine($"   Project Type - {project.ProjectType.Name}" +
                        $"\n     Project Rate - ${project.ProjectType.PriceRate}");
                }
            }
        }
        public void DisplayAllClients()
        {
            foreach (var client in AllClients)
            {
                Console.WriteLine($"{client.Name}");
                Console.WriteLine("  Ongoing Projects:");
                foreach (var project in client.OngoingProjects)
                {
                    Console.WriteLine("   " + project.ProjectType.Name);
                }
                Console.WriteLine("  Completed Projects:");
                foreach (var project in client.CompletedProjects)
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
