using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using static GigGird_FinalProject.Menus;

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

        public static bool GetYesNo(string question)
        {
            while (true)
            {
                Console.WriteLine(question);
                string input = Console.ReadLine().ToLower();
                if (input == "yes" || input == "yeah" || input == "y")
                { return true; }
                else if (input == "no" || input == "nah" || input == "n")
                { return false; }
                else
                { Console.WriteLine("Haha, try again."); }
            }

        }

        public static string FormatToJSON<T>() where T : struct, Object
        {

        }
    }
}
