
using GigGird_FinalProject.MainMenus;

namespace GigGird_FinalProject.Menus
{
        /* each client:
                name, projects, average hourly/project price rate
                location
                current projects
                project history
                rating?
        */
    public class ClientMenu : MainMenu
    {
        private readonly GigGridManager _gridManager;
        public ClientMenu(GigGridManager gridManager) : base (gridManager)
        {
            _gridManager = gridManager;
        }

        public enum ClientMenuEnum
        {
            ViewMainMenu = 0,
            ViewCurrentClients = 1,
            ViewAllClients = 2,
            AddNewClient = 3,
            ArchiveClient = 4,
            ViewClientMenu = 5,
        }
        public void DisplayMenu()
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
                        _gridManager.menuManager.mainMenu.DisplayMainMenu();
                        break;
                    case ClientMenuEnum.ViewCurrentClients:
                        // _gridManager.clientManager.DisplayCurrentClients();
                        //TODO: method to show clients with current/ongoing contracts
                        break;
                    case ClientMenuEnum.ViewAllClients:
                        // _gridManager.clientManager.DisplayAllClients();
                        //TODO: method to display all clients, with option to edit clients
                        break;
                    case ClientMenuEnum.AddNewClient:
                        // _gridManager.clientManager.AddNewClient();
                        //TODO: method to create new client
                        break;
                    case ClientMenuEnum.ArchiveClient:
                        // _gridManager.clientManager.ArchiveClient();
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

        public ClientMenuEnum GetEnum()
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