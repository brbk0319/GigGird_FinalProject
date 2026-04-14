using System;
using System.Collections.Generic;
using System.Text;

namespace GigGird_FinalProject.Clients
{
    public class Client : ISaveable
    {
        public string Name { get; set; }
        public string CompletedProjects { get; set; }
        private bool CompletedPayment { get; set; }

        public Client() { }

        public Client(string name) 
        {
            Name = name;
        }
    }
}
