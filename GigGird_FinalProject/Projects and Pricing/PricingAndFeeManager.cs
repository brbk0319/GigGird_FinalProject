using GigGird_FinalProject.Projects_and_Pricing;
using System;
using System.Collections.Generic;
using System.Text;

namespace GigGird_FinalProject.Money
{
    public class PricingAndFeeManager
    {

        public Dictionary<string, AdditionalFee> AdditionalFees = new Dictionary<string, AdditionalFee>()
        {
            {"Rush", new AdditionalFee( "Rush",
                "25-100% of the project total, ie a 24 hour turnaround for something that takes a week",
                0m, 1.50m) }, 
            //TODO: Add trigger if the creation date is closer than 48 hours to the Deadline, automatic multiplier
            {"Revise", new AdditionalFee("Revise",
                "Anything more than 2 rounds of revisions", 25m, 1m) },
            //TODO: Project revision field that tracks revision rounds, automatically adds when count > 2
            {"Rights", new AdditionalFee("Rights",
                "You own the work till you sell the rights. Full buyout = higher price, espcially " +
                "if it's for something bigger vs smaller (national ad campaign vs small newsletter",
                200m, 4m) },
            {"Emails", new AdditionalFee("Emails",
                "If I am spending too much time answering emails to finish your project sooner, or" +
                " any non-billable hours (project management, research, travel, etc",
                0m, 1.15m) },
            {"Special", new AdditionalFee("Special",
                "If the project requires me buying specialized software/a product I don't already have," +
                " or for a subscription I don't normally use. Anything out of pocket basically. " +
                "(Check with client before purchasing and adding to the invoice) Add whatever expensese" +
                " you had to cover.", 25m, 1m) },
            {"Late", new AdditionalFee("Late", "basically, pay on time. If you pay way late it's extra.",
                0m, 1.05m) },
            //TODO: Add payment date to contract, when Date > due date, apply percentage monthly
        };

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

        public PricingAndFeeManager() { }

        public void DisplayAllPriceDescriptions()
        {
            foreach (var type in ProjectTypes)
            {
                Console.WriteLine($"\nType: {type.Key}" +
                $"\n   Rate: ${type.Value.PriceRate}" +
                $"\n   {type.Value.Description}\n");
            }

        }

        public PriceType ProjectPriceType()
        {
            PriceType priceType = ProjectTypes["Odd Job"];
            bool isValid = false;
            string response = "";

            DisplayAllPriceDescriptions();

            while (!isValid)
            {
                Console.WriteLine("Which type of project is this? (Enter the exact name)");
                response = Console.ReadLine();
                if (ProjectTypes.ContainsKey(response))
                {
                    isValid = true;
                    priceType = ProjectTypes[response].Clone(); ;
                }
                else
                {
                    Console.WriteLine($"Sorry, '{response} is not recognized. Please try again.");
                    Console.WriteLine("Project types: " + string.Join(", ", ProjectTypes));
                }
            }

            Console.WriteLine($"The standard rate for {response} is {priceType.PriceRate}.");
            string question = "Would you like to change the rate for this specific project? (y/n)";
            bool choice = GigUtils.GetYesNo(question);

            if (choice)
            {
                Console.Write("Enter new rate: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal newRate))
                {
                    priceType.PriceRate = newRate;
                }
            }

            Console.WriteLine("Project type finalized!");

            return priceType;
        }

        public void CreateNewProjectType()
        {
            Console.WriteLine("What's the name of this project type?");
            string name = Console.ReadLine();

            Console.WriteLine("What's the going rate for this project type?");
            decimal rate = decimal.Parse(Console.ReadLine());

            Console.WriteLine("What's the description for this project type?");
            string description = Console.ReadLine();

            InitializeProjectType(name, rate, description);
        }

        public void InitializeProjectType(string name, decimal rate, string description)
        {
            ProjectTypes[name] = new PriceType(name, rate, description);
        }
    }
}
