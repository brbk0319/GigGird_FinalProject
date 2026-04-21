using GigGird_FinalProject.Clients;
using GigGird_FinalProject.Money;
using GigGird_FinalProject.Projects;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GigGird_FinalProject
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

    public class Menu
    {

        private readonly GigGridManager _gridManager;
        public Menu(GigGridManager gridManager)
        {
            _gridManager = gridManager;
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
                    "\n     3. Pricing Menu " +
                    "\n     4. Client Menu " +
                    "\n     5. Income Menu " +
                    "\n     6. Exit GigGrid");


                MainMenuEnum MainMenuChoice = GigUtils.GetEnum<MainMenuEnum>();

                switch (MainMenuChoice)
                {
                    case MainMenuEnum.ViewMainMainMenu:
                        Console.WriteLine("");
                        break;
                    case MainMenuEnum.ViewCurrentProjects:
                        _gridManager.ProjectManager.DisplayCurrentProject();
                        break;
                    case MainMenuEnum.ViewProjectMenu:
                       DisplayProjectMenu();
                        break;
                    case MainMenuEnum.ViewPricingMenu:
                        DisplayPricingMenu();
                        break;
                    case MainMenuEnum.ViewClientMenu:
                        DisplayClientMenu();
                        break;
                    case MainMenuEnum.ViewIncomeMenu:
                        DisplayIncomeMenu();
                        break;
                    case MainMenuEnum.exit:
                        string exitConfirmation = "Are you CERTAIN you wish to leave?\n     Yes\n     No";

                        bool choice = GigUtils.GetYesNo(exitConfirmation);
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

        public void DisplayProjectMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("\nPROJECTS" +
                    "\nWhere would you like to go?" +
                    "\n     1. Current Projects " +
                    "\n     2. View All Projects " +
                    "\n     3. Create New Project " +
                    "\n     4. Return to Main Menu");


                ProjectMenuEnum menuChoice = GigUtils.GetEnum<ProjectMenuEnum>();

                switch (menuChoice)
                {
                    case ProjectMenuEnum.ViewProjectMenu:
                        Console.WriteLine();
                        break;
                    case ProjectMenuEnum.ViewCurrentProjects:
                        _gridManager.ProjectManager.DisplayCurrentProject();
                        break;
                    case ProjectMenuEnum.ViewAllProjects:
                        _gridManager.ProjectManager.DisplayAllProjects();
                        break;
                    case ProjectMenuEnum.CreateNewProject:
                        _gridManager.ProjectManager.CreateNewProject();
                        break;
                    case ProjectMenuEnum.ViewMainMenu:
                        isRunning = false;
                        return;
                    default:
                        Console.WriteLine("You think you're clever, huh? Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void DisplayPricingMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("\nPRICING MENU" +
                    "\n Where would you like to go?" +
                    "\n     1. View Project Types & Descriptions " +
                    "\n     2. Create Project Type " +
                    "\n     3. View Additional Fee Causes " +
                    "\n     4. Create Additional Fee Cause");


                PricingMenuEnum menuChoice = GigUtils.GetEnum<PricingMenuEnum>();

                switch (menuChoice)
                {
                    case PricingMenuEnum.ViewPricingMenu:
                        //TODO: await, then continue
                        Console.WriteLine();
                        break;
                    case PricingMenuEnum.ViewProjectTypes:
                        _gridManager.PricingManager.DisplayAllPriceDescriptions();
                        //TODO: add option to edit rates?
                        break;
                    case PricingMenuEnum.CreateProjectType:
                        _gridManager.PricingManager.CreateNewProjectType();
                        //TODO: method to create/record new project type + rate
                        break;
                    case PricingMenuEnum.ViewAdditionalFeeCauses:
                        //TODO: method to view additional fee causes
                        break;
                    case PricingMenuEnum.CreateAdditionalFeeCause:
                        //TODO: Method to create additional fee cause
                        break;
                    case PricingMenuEnum.ViewMainMenu:
                        isRunning = false;
                        return;
                    default:
                        Console.WriteLine("You think you're clever, huh? Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void DisplayClientMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("CLIENT MENU" +
                    "\nWhere would you like to go?" +
                    "\n     1. View Current Clients " +
                    "\n     2. View All Clients " +
                    "\n     3. Add New Client " +
                    "\n     4. Return to Main Menu");


                ClientMenuEnum menuChoice = GigUtils.GetEnum<ClientMenuEnum>();

                switch (menuChoice)
                {
                    case ClientMenuEnum.ViewClientMenu:
                        //TODO: add await here
                        Console.WriteLine();
                        break;
                    case ClientMenuEnum.ViewCurrentClients:
                        _gridManager.ClientManager.DisplayCurrentClients();
                        break;
                    case ClientMenuEnum.ViewAllClients:
                        _gridManager.ClientManager.DisplayAllClients();
                        //TODO: add option to edit clients after all are displayed?
                        break;
                    case ClientMenuEnum.AddNewClient:
                        _gridManager.ClientManager.AddNewClient();
                        break;
                    case ClientMenuEnum.ViewMainMenu:
                        isRunning = false;
                        return;
                    default:
                        Console.WriteLine("You think you're clever, huh? Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void DisplayIncomeMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("INCOME" +
                    " \nWhere would you like to go?" +
                    "\n     1. Current Income " +
                    "\n     2. Total Income " +
                    "\n     3. Add Income " +
                    "\n     4. View Savings " +
                    "\n     5. View Tithing" +
                    "\n     6. Return to Main Menu");


                IncomeMenuEnum menuChoice = GigUtils.GetEnum<IncomeMenuEnum>();

                switch (menuChoice)
                {
                    case IncomeMenuEnum.ViewIncomeMenu:
                        Console.WriteLine();
                        break;
                    case IncomeMenuEnum.ViewCurrentIncome:
                        _gridManager.IncomeManager.ViewCurrentIncome();
                        break;
                    case IncomeMenuEnum.ViewTotalIncome:
                        _gridManager.IncomeManager.ViewTotalIncome();
                        break;
                    case IncomeMenuEnum.AddIncome:
                        _gridManager.IncomeManager.AddIncome();
                        break;
                    case IncomeMenuEnum.ViewSavings:
                        _gridManager.IncomeManager.ViewSavings();
                        break;
                    case IncomeMenuEnum.ViewTithing:
                        _gridManager.IncomeManager.ViewTithing();
                        break;
                    case IncomeMenuEnum.ViewMainMenu:
                        isRunning = false;
                        return;
                    default:
                        Console.WriteLine("You think you're clever, huh? Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public enum MainMenuEnum
        {
            ViewMainMainMenu = 0,
            ViewCurrentProjects = 1,
            ViewProjectMenu = 2,
            ViewPricingMenu = 3,
            ViewClientMenu = 4,
            ViewIncomeMenu = 5,
            exit = 6,
            developer = 67,
        }

        public enum ProjectMenuEnum
        {
            ViewProjectMenu = 0,
            ViewCurrentProjects = 1,
            ViewAllProjects = 2,
            CreateNewProject = 3,
            ViewMainMenu = 4,
        }

        public enum ClientMenuEnum
        {
            ViewClientMenu = 0,
            ViewCurrentClients = 1,
            ViewAllClients = 2,
            AddNewClient = 3,
            ViewMainMenu = 4,
        }

        public enum IncomeMenuEnum
        {
            ViewIncomeMenu = 0,
            ViewCurrentIncome = 1,
            ViewTotalIncome = 2,
            AddIncome = 3,
            ViewSavings = 4,
            ViewTithing = 5,
            ViewMainMenu = 6,
        }

        public enum PricingMenuEnum
        {
            ViewPricingMenu = 0,
            ViewProjectTypes = 1,
            CreateProjectType = 2,
            ViewAdditionalFeeCauses = 3,
            CreateAdditionalFeeCause = 4,
            ViewMainMenu = 5,
        }
    }
}
