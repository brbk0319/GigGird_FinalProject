
using System.Net;
using GigGird_FinalProject.MainMenus;
using GigGird_FinalProject.Projects;

namespace GigGird_FinalProject.Menus
{
    public class ProjectMenu : MainMenu
    {
        public enum ProjectMenuEnum
        /* each project:
                name, client, contract type, price rate
                creation date, deadlines(days left)
                options: edit project/contract, static return to main menu
        */
        {
            ViewMainMenu = 0,
            ViewCurrentProjects = 1,
            ViewAllProjects = 2,
            CreateNewProject = 3,
            ViewProjectMenu = 4,
        }
        public static void DisplayMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("WELCOME TO GIGGRID" +
                    "\nWhere would you like to go?" +
                    "\n     1. Current Projects " +
                    "\n     2. View All Projects " +
                    "\n     3. Create New Project ");


                ProjectMenuEnum menuChoice = GetEnum();

                switch (menuChoice)
                {
                    case ProjectMenuEnum.ViewMainMenu:
                        DisplayMainMenu();
                        break;
                    case ProjectMenuEnum.ViewCurrentProjects:
                        //TODO: whatever option in Project Menu that shows current projects;
                        break;
                    case ProjectMenuEnum.ViewAllProjects:
                        //ProjectMenu.DisplayMenu();
                        break;
                    case ProjectMenuEnum.CreateNewProject:
                        //ClientMenu.DisplayMenu();
                        break;
                    case ProjectMenuEnum.ViewProjectMenu:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("You think you're clever, huh? Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static ProjectMenuEnum GetEnum()
        {
            ProjectMenuEnum menuChoice = ProjectMenuEnum.ViewMainMenu;
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out menuChoice))
            { return menuChoice; }
            else
            {
                Console.WriteLine("Haha, try again.");
                return ProjectMenuEnum.ViewProjectMenu;
            }
        }
    }
}