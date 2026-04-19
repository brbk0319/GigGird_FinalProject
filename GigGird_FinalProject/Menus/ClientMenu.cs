
using GigGird_FinalProject.MainMenus;

namespace GigGird_FinalProject.Menus
{
    public class ClientMenu : MainMenu
    {
        /* each client:
                name, projects, average hourly/project price rate
                location
                current projects
                project history
                rating?
        */
        public enum ClientMenuEnum
        {
            ViewMainMenu = 0,
            ViewCurrentClients = 1,
            ViewAllClients = 2,
            AddNewClient = 3,
            ArchiveClient = 4,
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


            GetEnum(menuQuery, out ClientMenuEnum menuChoice);

            switch (menuChoice)
            {
                case ClientMenuEnum.ViewMainMenu:
                    DisplayMainMenu();
                    break;
                case ClientMenuEnum.ViewCurrentClients:
                    //TODO: method to show clients with current/ongoing contracts
                    break;
                case ClientMenuEnum.ViewAllClients:
                    //TODO: method to display all clients, with option to edit clients
                    break;
                case ClientMenuEnum.AddNewClient:
                    //TODO: method to create new client
                    break;
                case ClientMenuEnum.ArchiveClient:
                    //method to archive clients (separate section in all clients)
                    break;

                default:
                    Console.WriteLine("You think you're clever, huh? Try again.'");
                    break;
            }
        }

        public void GetEnum(string question, out ClientMenuEnum menuChoice)
        {
            menuChoice = ClientMenuEnum.ViewMainMenu;
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