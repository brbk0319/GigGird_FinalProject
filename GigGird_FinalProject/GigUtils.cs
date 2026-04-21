using System;
using System.Collections.Generic;
using System.Text;
using static GigGird_FinalProject.MainMenus.MainMenu;

namespace GigGird_FinalProject
{
    public class GigUtils
    {

        public static TimeSpan CalculateDaysUntilDeadline(DateTime deadline)
        {
            return deadline - DateTime.Now;
        }

        /* TODO:
         * Formatting methods, project progress methods, project quote(?)
         */


        public static T GetEnum<T>() where T : struct, Enum
        {
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out T result)) 
            { 
                return result;
            }
            else 
            { 
                Console.WriteLine("Haha, try again."); 
                return default;
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
}
