using GigGird_FinalProject.Clients;
using GigGird_FinalProject.Menus;
using GigGird_FinalProject.Projects;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GigGird_FinalProject.MainMenus
{
    /*  MainMenus(each thing will need a MainMenu -________-)
         * call main MainMenu(static thing? that calls the other things?)
         * view current projects(shows name of project, client name, price rate and deadline)
         * vew past / all projects(with numbers, just input number)
         * view clients
         * view income
         * exit program
         * static method return to main MainMenu in each mini MainMenu
    */

    //TODO: make enum for each MainMenu? keep in namespace, then just call whatever one is needed?
    //(add _ to the enum names so you can just call the names?)

    public class MainMenu
    {

        private readonly GigGridManager _gridManager;
        private readonly MenuManager _menuManager;
        public MainMenu(GigGridManager gridManager, MenuManager menuManager)
        {
            _gridManager = gridManager;
            _menuManager = menuManager;
        }

        public enum MainMenuEnum
        {
            ViewMainMainMenu = 0,
            ViewCurrentProjects = 1,
            ViewProjectMenu = 2,
            ViewClientMenu = 3,
            ViewIncomeMenu = 4,
            exit = 5,
            developer = 67,
        }

        public void DisplayMainMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("WELCOME TO GIGGRID" +
                    "\n Where would you like to go?" +
                    "\n     1. Current Projects " +
                    "\n     2. Project Menu " +
                    "\n     3. Client Menu " +
                    "\n     4. Income Menu " +
                    "\n     5. Exit GigGrid");


                MainMenuEnum MainMenuChoice = GetEnum();

                switch (MainMenuChoice)
                {
                    case MainMenuEnum.ViewMainMainMenu:
                        Console.WriteLine("");
                        break;
                    case MainMenuEnum.ViewCurrentProjects:
                        _gridManager.projectManager.DisplayCurrentProject();
                        break;
                    case MainMenuEnum.ViewProjectMenu:
                        _menuManager.projectMenu.DisplayMenu();
                        break;
                    case MainMenuEnum.ViewClientMenu:
                        _menuManager.clientMenu.DisplayMenu();
                        break;
                    case MainMenuEnum.ViewIncomeMenu:
                        _menuManager.incomeMenu.DisplayMenu();
                        break;
                    case MainMenuEnum.exit:
                        string exitConfirmation = "Are you CERTAIN you wish to leave?\n     Yes\n     No";

                        GetYesNo(exitConfirmation, out bool choice);
                        if (choice == true)
                        {
                            Console.WriteLine("Farewell Entrepreneuer!");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Cool, off we go.");
                        }
                        break;

                    case MainMenuEnum.developer:
                        Console.WriteLine(":89. Welcome to the developer's side.\nOkay bye");
                        break;
                    default:
                        Console.WriteLine("You think you're clever, huh? Press any key and then try again.'");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public MainMenuEnum GetEnum()
        {
            MainMenuEnum menuChoice = MainMenuEnum.ViewMainMainMenu;
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out menuChoice)) { }
            else { Console.WriteLine("Haha, try again."); }
            return menuChoice;
        }

        public void GetYesNo(string question, out bool choice)
        {
            choice = false;

            Console.WriteLine(question);
            string input = Console.ReadLine().ToLower();
            if (input == "yes" || input == "yeah")
            { choice = true; return; }
            else if (input == "no" || input == "nah")
            { choice = false; return; }
            else
            { Console.WriteLine("Haha, try again."); }

        }
    }

}
