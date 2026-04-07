using System;
using System.Collections.Generic;
using System.Text;

namespace GigGird_FinalProject.Clients
{
    internal class Client : ISaveable
    {
        public string Name { get; set; }
        public string CompletedProjects { get; set; }
        private bool CompletedPayment { get; set; }
    }
}
