using GigGird_FinalProject.Clients;
using GigGird_FinalProject.Money;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
        public PriceType ProjectType { get; set; }

        public List<string> ToDoList { get; set; }
        public List<string> InProgressList { get; set; }
        public List<string> CompletedList { get; set; }

        public Project(Client client, PriceType projectType)
        {
            ProjectClient = client;
            ProjectType = projectType;
            ProjectContract = ContractType();
        }

        public BaseContract ContractType()
        {
            BaseContract contract;
            Console.WriteLine("What kind of contract is this?\n   1) Hourly\n   2) Project\n   3) Re-Occuring");
            int response = int.Parse(Console.ReadLine());

            switch (response)
            {
                case 1: contract = new HourlyContract(ProjectClient, ProjectType); break;
                case 2: contract = new ProjectContract(ProjectClient, ProjectType); break;
                case 3: contract = new ReOccuringContract(ProjectClient, ProjectType); break;
                default: Console.WriteLine("Yeah no try again"); contract = null; break;
            }

            return contract;
        }

    }
}
