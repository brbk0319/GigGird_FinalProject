using GigGird_FinalProject.MainMenus;

namespace GigGird_FinalProject.Menus
{
    public class PricingMenu : MainMenu
    {
        public enum PricingMenuEnum
        {
            ViewMainMenu = 0,
            ViewProjectTypes = 1,
            CreateProjectType = 2,
            ViewAdditionalFeeCauses = 3,
            CreateAdditionalFeeCause = 4,
            exit = 5,
        }
        public void DisplayMenu()
        {
            Console.WriteLine("WELCOME TO GIGGRID\n");
            string menuQuery = "Where would you like to go?" +
                "\n     1. Current Projects " +
                "\n     2. Project Menu " +
                "\n     3. Client Menu " +
                "\n     4. Income Menu " +
                "\n     5. Exit GigGrid";


            GetEnum(menuQuery, out PricingMenuEnum menuChoice);

            switch (menuChoice)
            {
                case PricingMenuEnum.ViewMainMenu:
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
                default:
                    Console.WriteLine("You think you're clever, huh? Try again Hero.'");
                    break;
            }
        }

        public void GetEnum(string question, out PricingMenuEnum menuChoice)
        {
            menuChoice = PricingMenuEnum.ViewMainMenu;
            while (true)
            {
                Console.WriteLine(question);
                string input = Console.ReadLine();

                if (Enum.TryParse(input, true, out menuChoice))
                { return; }
                else { Console.WriteLine("Haha, try again."); }
            }
        }
    }

}