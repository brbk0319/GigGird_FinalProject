using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using GigGird_FinalProject.Clients;
using GigGird_FinalProject.Money;

namespace GigGird_FinalProject.Projects
{
    public class ProjectManager
    {
        //TODO: Singleton? Only one instance of Project Manager

        private readonly GigGridManager _gridManager;
        public ProjectManager(GigGridManager gridManager)
        {
            _gridManager = gridManager;
        }


        List<BaseContract> CurrentProjects = new List<BaseContract>();
        List<BaseContract> PastProjects = new List<BaseContract>();

        public void DisplayCurrentProject()
        {
            Console.WriteLine("\n\nCURRENT PROJECTS\n--------------------");

            var currentByDeadline = CurrentProjects
                .OrderByDescending(p => p.Deadline)
                .ThenBy(p => p.ProjectType.PriceRate)
                .ToList();

            foreach (var proj in CurrentProjects)
            {
                Console.WriteLine($"\n\nProject: {proj.ProjectType.Name}" +
                    $"\n   Client: {proj.Client.Name}" +
                    $"\n   Rate: {proj.ProjectType.PriceRate}");
            }

            Console.ReadKey();
        }


        public void DisplayAllProjects()
        {
            Console.WriteLine("\n\nCURRENT PROJECTS\n--------------------");

            var currentByDeadline = CurrentProjects
                .OrderByDescending(p => p.Deadline)
                .ThenBy(p => p.ProjectType.PriceRate)
                .ToList();

            foreach (var proj in currentByDeadline)
            {
                Console.WriteLine($"\n\nProject: {proj.ProjectType.Name}" +
                    $"\n   Client: {proj.Client.Name}" +
                    $"\n   Rate: {proj.ProjectType.PriceRate}");
            }


            Console.WriteLine("\n\nPAST PROJECTS\n--------------------");

            var pastByDeadline = PastProjects
                .OrderByDescending(p => p.Deadline)
                .ThenBy(p => p.ProjectType.PriceRate)
                .ToList();
            foreach (var proj in pastByDeadline)
            {
                Console.WriteLine($"\n\nProject: {proj.ProjectType.Name}" +
                    $"\n   Client: {proj.Client.Name}" +
                    $"\n   Rate: {proj.ProjectType.PriceRate}" +
                    $"\n   Completed: {proj.Deadline}");
            }

            Console.ReadKey();
        }

        public void CreateNewProject()
        {
            Project project = new Project(GetClient(), CheckProjectType());
        }

        public PriceType CheckProjectType()
        {
            PriceType projectType = _gridManager.PricingManager.ProjectPriceType();
            return projectType;
        }

        public Client GetClient()
        {
            string question = "Is this a re-occuring client? (y/n)";
            string response = ""; 
            Client client = null;
            bool isValid = false;

            if (GigUtils.GetYesNo(question))
            {
                while (!isValid)
                {
                    Console.WriteLine("What's the name of the client? (Enter the exact name)");
                    response = Console.ReadLine();

                    client = _gridManager.ClientManager.AllClients.FirstOrDefault(c => c.Name.Equals(response, StringComparison.OrdinalIgnoreCase));

                    if (client != null)
                    {
                        isValid = true;
                        return client;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, '{response} is not recognized. Please try again.");
                        Console.WriteLine("Known Clients: " + string.Join(", ", _gridManager.ClientManager.AllClients.Select(c => c.Name)));
                    }
                }
            }
            else
            {
                _gridManager.ClientManager.AddNewClient();
            }
            
            return client;
        }

    }
}
