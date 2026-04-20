using GigGird_FinalProject.MainMenus;

namespace GigGird_FinalProject.Menus
{
    public class IncomeMenu : MainMenu
    {
        public enum IncomeMenuEnum
        {
            ViewMainMenu = 0,
            ViewCurrentIncome = 1,
            ViewTotalIncome = 2,
            AddIncome = 3,
            ViewSavings = 4,
            ViewTithing = 5,
            ViewIncomeMenu = 6,
        }
        public static void DisplayMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("WELCOME TO GIGGRID" + 
                    " \nWhere would you like to go?" +
                    "\n     1. Current Projects " +
                    "\n     2. Project Menu " +
                    "\n     3. Client Menu " +
                    "\n     4. Income Menu " +
                    "\n     5. ViewTithing GigGrid");


                IncomeMenuEnum menuChoice = GetEnum();

                switch (menuChoice)
                {
                    case IncomeMenuEnum.ViewMainMenu:
                        DisplayMainMenu();
                        break;
                    case IncomeMenuEnum.ViewCurrentIncome:
                        //TODO: method that shows income expected that week;
                        break;
                    case IncomeMenuEnum.ViewTotalIncome:
                        //TODO: method - menu for total income: monthly, weekly, types, highest paying clients
                        break;
                    case IncomeMenuEnum.AddIncome:
                        //TODO: method to Record outside source of income;
                        break;
                    case IncomeMenuEnum.ViewSavings:
                        //TODO: savings menu, caclulate savings + update paid savings
                        break;
                    case IncomeMenuEnum.ViewTithing:
                        //TODO: Tithing Menu, calculate tithing + update paid tithing
                        break;
                    default:
                        Console.WriteLine("You think you're clever, huh? Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static IncomeMenuEnum GetEnum() //TODO: polymorphism?
        {
            IncomeMenuEnum menuChoice = IncomeMenuEnum.ViewIncomeMenu;
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out menuChoice))
            {
                return menuChoice;
            }
            else
            {
                Console.WriteLine("Haha, try again.");
                return menuChoice;
            }

        }
    }


}