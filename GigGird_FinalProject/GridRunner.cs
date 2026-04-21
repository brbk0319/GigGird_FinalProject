//TODO: has the acutally stuf for the programusing System;
using System.Collections.Generic;
using System.Text;
using GigGird_FinalProject.Clients;
using GigGird_FinalProject.Money;
using GigGird_FinalProject.Projects;

namespace GigGird_FinalProject
{
    public class GridRunner
    {

        public readonly GigGridManager _gManager;
        public GridRunner( )
        {
            _gManager = new GigGridManager();

        }

        public void Run()
        {
            Menu gridMenu = new Menu(_gManager);
            gridMenu.DisplayMainMenu();
            //Debug thing won't run????? idk.
        }

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
         * Income manager - records the money I make (subscriber to event?)
         *      method to calculate total money made (default: timespan = current year, but optional other dates, also all time)
         *      method to caculate tithing (done every time I get paid) (records totals and for each project)
         *      method called by projects to add to records/calculate tithing
         *      creates a new file for each project of money made?
         */

    }
}
