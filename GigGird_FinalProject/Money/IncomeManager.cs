using System;
using System.Collections.Generic;
using System.Text;

namespace GigGird_FinalProject.Money
{
    public class IncomeManager : ISaveable
    {
        
        public decimal TotalIncomeEver { get; set; }
        public List<decimal> MonthlyIncomes { get; set; }
        public decimal WeeklyIncome { get; set; }
        public decimal TithingToPay { get; set; }
        public decimal TotalYearTithing { get; set; }
        
        public decimal SpendingMoney { get; set; }
        
        
        
        /*TODO: 
         * record all income, the project it came from, date, client, etc
         * 
         *  tithing calculator
         *  savings calculator
         *  highest paying clientel/projects
         *  save dates, keep accurate records
         */

        /*TODO: Income subscribes to projectmanager/giggridmanager and watches
         *      for when money comes in (required to go in and manually enter)
         *      
         */

        public void ViewCurrentIncome()
        {

        }

        public void ViewTotalIncome()
        {
            
        }

        public void AddIncome()
        {
            
        }

        public void ViewSavings()
        {
            
        }

        public void ViewTithing()
        {
            
        }

    }
}
