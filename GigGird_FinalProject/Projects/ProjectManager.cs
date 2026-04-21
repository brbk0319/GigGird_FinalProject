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

        // public PricingManager PriceManager {get;} = new PricingManager();

        // private readonly GigGridManager _gridManager;

        // public ProjectManager(GigGridManager gridManager)
        // {
        //     _gridManager = gridManager;
        // }


        List<BaseContract> CurrentProjects = new List<BaseContract>();
        List<BaseContract> PastProjects = new List<BaseContract>();

        public void DisplayCurrentProject()
        {
            //TODO: show all projects with a completion date in the future
            // or marked as uncompleted, organized by deadline date
        }

        public void DisplayAllProjects()
        {
            //TODO: Show all projects, client names, and completed or incomplete
            //organized by deadline date in those two categories
        }

        public void CreateNewProject()
        {
            Project project = new Project(GetClient(), CheckProjectType());
        }

        public PriceType CheckProjectType()
        {
            PriceType projectType = PricingManager.PricingMenu();
            return projectType;
        }

        public Client GetClient()
        {
            return Client client;
        }
        
    }
}
