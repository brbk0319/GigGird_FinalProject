using System.Runtime.InteropServices;
using GigGird_FinalProject.MainMenus;

namespace GigGird_FinalProject.Menus
{
    public class IncomeMenu
    {

        private readonly GigGridManager _gridManager;
        public IncomeMenu(GigGridManager gridManager)
        {
            _gridManager = gridManager;
        }

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
        public void DisplayMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("INCOME" +
                    " \nWhere would you like to go?" +
                    "\n     1. Current Income " +
                    "\n     2. Total Income " +
                    "\n     3. Add Income " +
                    "\n     4. View Savings " +
                    "\n     5. View Tithing");


                IncomeMenuEnum menuChoice = GetEnum();

                switch (menuChoice)
                {
                    case IncomeMenuEnum.ViewMainMenu:
                        return;
                    case IncomeMenuEnum.ViewCurrentIncome:
                        _gridManager.incomeManager.ViewCurrentIncome();
                        //TODO: method that shows income expected that week;
                        break;
                    case IncomeMenuEnum.ViewTotalIncome:
                        _gridManager.incomeManager.ViewTotalIncome();
                        //TODO: method - menu for total income: monthly, weekly, types, highest paying clients
                        break;
                    case IncomeMenuEnum.AddIncome:
                        _gridManager.incomeManager.AddIncome();
                        //TODO: method to Record outside source of income;
                        break;
                    case IncomeMenuEnum.ViewSavings:
                        _gridManager.incomeManager.ViewSavings();
                        //TODO: savings menu, caclulate savings + update paid savings
                        break;
                    case IncomeMenuEnum.ViewTithing:
                        _gridManager.incomeManager.ViewTithing();
                        //TODO: Tithing Menu, calculate tithing + update paid tithing
                        break;
                    default:
                        Console.WriteLine("You think you're clever, huh? Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public IncomeMenuEnum GetEnum() //TODO: polymorphism?
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