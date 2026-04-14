using GigGird_FinalProject.Clients;
using System;
using System.Collections.Generic;
using System.Text;

namespace GigGird_FinalProject.Projects
{
    public class Project : ISaveable //progress and organization
    {
        private decimal PriceRate {  get; set; } //TODO: Dependent on project type. Automate?
        private decimal Hourstotal { get; set; }
        public BaseContract ProjectContract { get; set; }

        private Client ProjectClient { get; set; }
        public string ProjectStatus { get; set; }
        public TypesOfProjects ProjectType { get; set; }

        public List<string> ToDoList { get; set; }
        public List<string> InProgressList { get; set; }
        public List<string> CompletedList { get; set; }

        public Project() { }

        public Project(string clientName)
        {
            ProjectClient = new Client(clientName);

            ContractType();
            CheckProjectType();
        }

        public void ContractType()
        {
            BaseContract contract;
            Console.WriteLine("What kind of contract is this?\n   1) Hourly\n   2) Project");
            int response = int.Parse(Console.ReadLine());

            switch (response)
            {
                case 1: contract = new HourlyContract(ProjectClient.Name, PriceRate); break;
                case 2: contract = new ProjectContract(ProjectClient.Name, PriceRate); break;
                default: Console.WriteLine("Yeah no try again"); contract = null; break;
            }

            ProjectContract = contract;
        }

        public TypesOfProjects CheckProjectType()
        {
            TypesOfProjects projectType = new TypesOfProjects();
            //TODO: Text and user response (CheckProjectType)
            return projectType = ProjectType; 
        }
    }



    public enum TypesOfProjects //TODO: enum/dictionary for job types and their base rates
    {
        OddJob,
        Cleaning,
        DeepCleaning,
        Children,
        Pets,
        Moving,
        Errands,
        HolidayPartyHelp,
        VirtualAssistant,
        CustomDesigns,
    }
}
