using System;
using System.Collections.Generic;
using System.Text;

namespace GigGird_FinalProject
{
    public class GigGridManager
    {


        public GigGridManager() { }

        /* TODO: 
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
         *          edit/archive client
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
         */

    }
}
