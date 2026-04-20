using GigGird_FinalProject.Menus;

namespace GigGird_FinalProject.MainMenus
{
    public class MenuManager
    {

        private readonly GigGridManager _gridManager;

        //TODO: Consider singleton here?

        public MainMenu mainMenu;
        public ProjectMenu projectMenu;
        public ClientMenu clientMenu;
        public IncomeMenu incomeMenu;
        public PricingMenu pricingMenu;

        public MenuManager(GigGridManager gridManager) 
        //recursion? GridManager has a menuManager, and menu manager needs a gridmanager
        {
            _gridManager = gridManager;

            // mainMenu = new MainMenu(_gridManager);
            projectMenu = new ProjectMenu(_gridManager);
            clientMenu = new ClientMenu(_gridManager);
            incomeMenu = new IncomeMenu(_gridManager);
            pricingMenu = new PricingMenu(_gridManager);
    }

}
}