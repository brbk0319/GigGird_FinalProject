using System;
using System.Collections.Generic;
using System.Text;

namespace GigGird_FinalProject.Money
{
    public class PricingManager
    {

        /*TODO: display general price/description for each type of project, plus things
             * that add additional fees
             * (display a certain menu for each type of project)
             * Then, ask the price decided for the project
             */


        public Dictionary<string, PriceType> ProjectTypes = new Dictionary<string, PriceType>()
        {
            {"Odd Job",
            new PriceType ("Odd Job", 15.00m, "Anything that doesn't match the available types")},
            {"Cleaning",
            new PriceType ("Cleaning", 30.00m, "General cleaning, repeating contract")},
            {"Deep Cleaning",
            new PriceType("Deep Cleaning", 45.00m, "General deep cleaning, within reasonable limits. dirtier = more expensive")},
            {"Children",
            new PriceType("Children", 15.00m, "Anything to do with kids, babysitting, tutoring, etc")},
            {"Pets",
            new PriceType("Pets", 15.00m, "Pet sitting visits, twice daily, feeding/play. Overnightings is more like a hundred.")},
            {"Moving",
            new PriceType("Moving", 15.00m, "Helping move boxes or preparing to move")},
            {"Errands",
            new PriceType("Errands", 15.00m, "General Errand running around the house/neighborhood")},
            {"Holiday Party Help",
            new PriceType("Holiday or Party Help", 15.00m, "Preparing for a party, setting up, making party favors, etc")},
            {"Virtual Assistant",
            new PriceType("Virtual Assistant", 300.00m, "Inbox zeroing, scheduling, general secretarial work, etc")},
            {"Custom Designs",
            new PriceType("Custom Designs", 35.00m, "Can range from 35 to 100, depends on the scope of the design")},
        };

        public PricingManager() { }

        public void PricingMenu()
        {
            foreach(var type in ProjectTypes)
            {
                Console.WriteLine($"\nType: {type.Key}" + 
                $"\n   Rate: ${type.Value.PriceRate}" + 
                $"\n   {type.Value.Description}\n");
            }

        }

        public PriceType ProjectPriceType()
        {
            PriceType priceType = ProjectTypes["Odd Job"];

            PricingMenu();

            Console.WriteLine("Which type of project is this?");
            //TODO: parse project type, check if rate is good or needs changing, assign Pricetype
            return priceType;
            
        }

        public void AddNewJob(string name, decimal rate, string description)
        {
            ProjectTypes[name] = new PriceType(name, rate, description);
        }
    }
}
