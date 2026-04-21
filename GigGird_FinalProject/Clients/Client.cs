using GigGird_FinalProject.Projects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GigGird_FinalProject.Clients
{
    public class Client : ISaveable
    {
        public string Name { get; set; }
        public Guid SaveID { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public bool CompletedPayment { get; set; }


        public List<Project> OngoingProjects { get; set; }
        public List<Project> CompletedProjects { get; set; }

        public Client() { }

        public Client(string name, string contact)
        {
            Name = name;
            Contact = contact;
        }

        public object SaveData()
        {
            return new //TODO: how??? something
            {
                Name = Name,
                Contact = Contact,
                CompletedPayment = CompletedPayment,
                Location = Location,
                SaveID = SaveID,
                OngoingProjects = new List<Project>(OngoingProjects),
                CompletedProjects = new List<Project>(CompletedProjects)
            };
        }
        public void LoadData(object data)
        { }
    }
}
