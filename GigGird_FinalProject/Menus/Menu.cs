using GigGird_FinalProject.Clients;
using GigGird_FinalProject.Projects;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GigGird_FinalProject.Menus
{
    /*  MENUs(each thing will need a menu -________-)
         * call main menu(static thing? that calls the other things?)
         * view current projects(shows name of project, client name, price rate and deadline)
         * vew past / all projects(with numbers, just input number)
         * view clients
         * view income
         * exit program
         * static method return to main menu in each mini menu
    */

    //TODO: make enum for each menu? keep in namespace, then just call whatever one is needed?
    //(add _ to the enum names so you can just call the names?)

    public class Menu
    {
        public Menu() { }

        public enum EnumMenu
        {
            viewMainMenu = 0,
            viewCurrentProjects = 1,
            viewProjectMenu = 2,
            viewClientMenu = 3,
            viewIncomeMenu = 4,
            exit = 5,
            developer = 67,
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


            GetEnum(menuQuery, out EnumMenu menuChoice);

            switch (menuChoice)
            {
                case EnumMenu.viewMainMenu:
                    //MainMenu.DisplayMenu();
                    break;
                case EnumMenu.viewCurrentProjects:
                    //TODO: whatever option in Project Menu that shows current projects;
                    break;
                case EnumMenu.viewProjectMenu:
                    //ProjectMenu.DisplayMenu();
                    break;
                case EnumMenu.viewClientMenu:
                    //ClientMenu.DisplayMenu();
                    break;
                case EnumMenu.viewIncomeMenu:
                    //IncomeMenu.DisplayMenu();
                    break;
                case EnumMenu.exit:
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

                case EnumMenu.developer:
                    Console.WriteLine(":89. Welcome to the developer's side.\nOkay bye");
                    break;
                default:
                    Console.WriteLine("You think you're clever, huh? Try again Hero.'");
                    break;



            }
        }

        public static void GetEnum(string question, out EnumMenu menuChoice)
        {
            menuChoice = EnumMenu.viewMainMenu;
            while (true)
            {
                Console.WriteLine(question);
                string input = Console.ReadLine();

                if (Enum.TryParse(input, true, out menuChoice))
                { return; }
                else { Console.WriteLine("Haha, try again."); }
            }
        }
        public static void GetYesNo(string question, out bool choice)
        {
            choice = false;
            while (true)
            {
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
    public class MainMenu : Menu { }

    public class ProjectMenu : Menu { }
    /* each project:
            name, client, contract type, price rate
            creation date, deadlines(days left)
            options: edit project/contract, static return to main menu
    */

    public class ClientMenu : Menu { }
    /* each client:
            name, projects, average hourly/project price rate
            location
            current projects
            project history
            rating?
    */

    public class PricingMenu : Menu { }
    public class IncomeMenu : Menu { }
    /* income
        *view total income
            *monthly income
            * weekly income
            * income types(dad should teach me a spreadsheet)
            * highest paying client
        *add income(not from projects)
        * savings?
            * calculate savings based on percentage?
            * update paid savings?
        * view tithing(including upaid tithing)
            * update paid tithing, calculate new total
            */
}
