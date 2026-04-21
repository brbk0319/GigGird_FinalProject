using System;
using System.Collections.Generic;
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
            //TODO: search for client name in ClientManager clients list
            return Client client;
        }

    }
}
