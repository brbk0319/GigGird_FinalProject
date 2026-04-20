
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
            ViewClientMenu = 5,
        }
        public static void DisplayMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("CLIENT MENU" + 
                    "\nWhere would you like to go?" +
                    "\n     0. Return to Main Menu" +
                    "\n     1. View Current Clients " +
                    "\n     2. View All Clients " +
                    "\n     3. Add New Client " +
                    "\n     4. Archive Client ");


                ClientMenuEnum menuChoice = GetEnum();

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
                    case ClientMenuEnum.ViewClientMenu:
                        //TODO: add await here
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("You think you're clever, huh? Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static ClientMenuEnum GetEnum()
        {
            ClientMenuEnum menuChoice = ClientMenuEnum.ViewClientMenu;
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out menuChoice)) { }
            else
            {
                Console.WriteLine("Haha, try again.");
            }
            return menuChoice;
        }
    }



}