using System;
using System.Collections.Generic;
using System.Text;

namespace GigGird_FinalProject
{
    public class GigGridManager
    {


        public GigGridManager() { }

        /* actually do: 
         * 
         * projects/clients
         *      create new project
         *          edit project
         *          assign/edit contract
         *          display project info
         *      project deadlines 
         *          method to display deadlines 
         *          method to confirm if tasks are finished when looking at a project
         *          method to alert the user that a task was unfinished
         *      create client
         *          edit client
         *          display client info
         *          
         * Price manager - mainly just to keep track of general prices/charges for types of project
         *      project > contract creation > calls price manager, displays all info
         *          caculator method asks for what I'm charging, extra fees applicable, gives an estimate based on the contract I picked
         *          
         * Income manager - records the money I make (subscriber to event?)
         *      method to calculate total money made (default: timespan = current year, but optional other dates, also all time)
         *      method to caculate tithing (done every time I get paid) (records totals and for each project)
         *      method called by projects to add to records/calculate tithing
         *      creates a new file for each project of money made?
         *      
         * MENUs (each thing will need a menu -________-)
         *      call main menu (static thing? that calls the other things?)
         *          view current projects (shows name of project, client name, price rate and deadline)
         *          vew past/all projects (with numbers, just input number)
         *          view clients
         *          view income
         *          exit program
         *      static method return to main menu in each mini menu
         *      
         *      each project:
         *          name, client, contract type, price rate
         *          creation date, deadlines (days left)
         *          options: edit project/contract, static return to main menu
         *          
         *      each client:
         *          name, projects, average hourly/project price rate
         *          location
         *          current projects
         *          project history
         *          rating?
         *          
         *      income
         *          view total income
         *              monthly income
         *              weekly income
         *              income types (dad should teach me a spreadsheet)
         *              highest paying client
         *          add income (not from projects)
         *          savings?
         *              calculate savings based on percentage?
         *              update paid savings?
         *          view tithing (including upaid tithing)
         *              update paid tithing, calculate new total
         *          
         */


            /*TODO: Make project
            Project Name: GigGrid
            Features: 
            - client manager 
            - project/task/deadline manager 
            - job type/pricing manager 
            - income manager

            Core OOP: 
            - Encapsulation: All money stuff fields 
                (hourly/project rate, money earned, invoice totals) 
                will be private or protected w/public properties + validation 
                to stop negative money/invalid anything 
            - Abstraction: abstract BaseContract class for structure of 
                general work agreement. ISaveable for data being saved to another file
            - Inheritance: HourlyContract and ProjectContract inherit from BaseContract.
            - Polymorphism: Both child classes will have a CalculateInvoiceTotal() method. 
                The Hourly version by hourly rate, and the project version for end of project
                paymentsor pre/post project payments.
            - Instances/objects: Each Client and Project object.
            - Static: Formatting methods, project progress methods, deadline calculator, 
                project quote?

            Bonus features:
            - analytics stuff (what makes the most, what I'm getting to most requests for)
            - automatic invoices? Like sending emails
            - I saw something that said I could save it to a spreadsheet, I wanna see 
                if I can figure it out
            */
    }
}
