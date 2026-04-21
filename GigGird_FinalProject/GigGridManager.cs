using System;
using System.Collections.Generic;
using System.Text;
using GigGird_FinalProject.Clients;
using GigGird_FinalProject.Money;
using GigGird_FinalProject.Projects;

namespace GigGird_FinalProject
{
    public class GigGridManager
    {

        public IncomeManager IncomeManager { get; } = new IncomeManager();
        public ClientManager ClientManager { get; } = new ClientManager();
        public PricingAndFeeManager PricingManager { get; } 
        public ProjectManager ProjectManager { get; } 

        public GigGridManager()
        {
            ClientManager = new ClientManager();
            PricingManager = new PricingAndFeeManager();
            ProjectManager = new ProjectManager(this);
            IncomeManager = new IncomeManager();
        }
    }
}
