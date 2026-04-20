using System;
using System.Collections.Generic;
using System.Text;
using GigGird_FinalProject.Clients;
using GigGird_FinalProject.Money;
using GigGird_FinalProject.Projects;
using GigGird_FinalProject.Menus;
using GigGird_FinalProject.MainMenus;

namespace GigGird_FinalProject
{
    public class GigGridManager
    {

        public ProjectManager projectManager { get; } = new ProjectManager();
        public IncomeManager incomeManager { get; } = new IncomeManager();
        public ClientManager clientManager { get; } = new ClientManager();
        public PricingManager pricingManager { get; } = new PricingManager();
        public MenuManager menuManager { get; } = new MenuManager();

        public GigGridManager()
        {
            
        }
    }
}
