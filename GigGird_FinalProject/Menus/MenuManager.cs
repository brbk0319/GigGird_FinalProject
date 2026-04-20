using GigGird_FinalProject.Menus;

namespace GigGird_FinalProject.MainMenus
{
    public class MenuManager
    {

            //TODO: now they all need a GridManager, fetch.
            //singleton here?
            public MainMenu mainMenu {get;} = new MainMenu();
            public ProjectMenu projectMenu {get;} = new ProjectMenu();
            public ClientMenu clientMenu {get;} = new ClientMenu();
            public IncomeMenu incomeMenu {get;} = new IncomeMenu();
            public PricingMenu pricingMenu {get;} = new PricingMenu();

        public MenuManager()
        {
        }
    }
}