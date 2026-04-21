using GigGird_FinalProject.Projects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GigGird_FinalProject.Clients
{
    public class Client : ISaveable
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public string Contact;
        private bool CompletedPayment { get; set; }

        public List<Project> OngoingContracts { get; set; }
        public List<Project> CompletedContracts { get; set; }

        public Client() { }

        public Client(string name, string contact) 
        {
            Name = name;
            Contact = contact;
        }
    }
}
