
using GigGird_FinalProject.MainMenus;

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
            viewMainMenu = 0,
            viewCurrentProjects = 1,
            viewAllProjects = 2,
            CreateNewProject = 3,
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


            GetEnum(menuQuery, out ProjectMenuEnum menuChoice);

            switch (menuChoice)
            {
                case ProjectMenuEnum.viewMainMenu:
                    DisplayMainMenu();
                    break;
                case ProjectMenuEnum.viewCurrentProjects:
                    //TODO: whatever option in Project Menu that shows current projects;
                    break;
                case ProjectMenuEnum.viewAllProjects:
                    //ProjectMenu.DisplayMenu();
                    break;
                case ProjectMenuEnum.CreateNewProject:
                    //ClientMenu.DisplayMenu();
                    break;
                default:
                    Console.WriteLine("You think you're clever, huh? Try again Hero.'");
                    break;
            }
        }

        public void GetEnum(string question, out ProjectMenuEnum menuChoice)
        {
            menuChoice = ProjectMenuEnum.viewMainMenu;
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