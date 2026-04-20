using GigGird_FinalProject.MainMenus;

namespace GigGird_FinalProject.Menus
{
    public class PricingMenu : MainMenu
    {

                private readonly GigGridManager _gridManager;
        public PricingMenu(GigGridManager gridManager) : base (gridManager)
        {
            _gridManager = gridManager;
        }

        public enum PricingMenuEnum
        {
            ViewMainMenu = 0,
            ViewProjectTypes = 1,
            CreateProjectType = 2,
            ViewAdditionalFeeCauses = 3,
            CreateAdditionalFeeCause = 4,
            ViewPricingMenu = 5,
        }
        public void DisplayMenu(MenuManager menuManager)
        {
            bool isRunning = true;
            while (isRunning)
            {
            Console.WriteLine("WELCOME TO GIGGRID" +
                "\n Where would you like to go?" +
                "\n     1. View Project Types & Descriptions " +
                "\n     2. Create Project Type " +
                "\n     3. View Additional Fee Causes " +
                "\n     4. Create Additional Fee Cause " +
                "\n     5. Exit GigGrid");


            PricingMenuEnum menuChoice = GetEnum();

            switch (menuChoice)
            {
                case PricingMenuEnum.ViewMainMenu:
                    isRunning = false;
                    DisplayMainMenu();
                    break;
                case PricingMenuEnum.ViewProjectTypes:
                    //TODO: method to display all project types + rates, option to edit one?
                    break;
                case PricingMenuEnum.CreateProjectType:
                    //TODO: method to create/record new project type + rate
                    break;
                case PricingMenuEnum.ViewAdditionalFeeCauses:
                    //TODO: method to view additional fee causes
                    break;
                case PricingMenuEnum.CreateAdditionalFeeCause:
                    //TODO: Method to create additional fee cause
                    break;
                case PricingMenuEnum.ViewPricingMenu:
                    //TODO: await, then continue
                    break;
                    default:
                        Console.WriteLine("You think you're clever, huh? Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public PricingMenuEnum GetEnum()
        {
            PricingMenuEnum menuChoice = PricingMenuEnum.ViewPricingMenu;
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out menuChoice)) { }
            else { Console.WriteLine("Haha, try again."); }

            return menuChoice;
        }
    }

}