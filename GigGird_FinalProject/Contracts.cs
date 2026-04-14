using GigGird_FinalProject.Projects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GigGird_FinalProject
{
    public abstract class BaseContract : ISaveable
    { // all about the money
        public string ClientName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime Deadline { get; set; }

        private decimal _baseRate; //TODO: BaseRate = price rate (in project)
        public decimal BaseRate
        {
            get { return _baseRate; }
            set { _baseRate = value < 0 ? 0 : value ; }
        }
        private decimal _additionalFees;
        public decimal AdditionalFees
        {
            get { return _additionalFees; }
            set { _additionalFees = value < 0 ? 0 : value; }
        }


        public BaseContract(string clientName)
        {
            ClientName = clientName;
            DateCreated = DateTime.Now;
        }

        public abstract decimal CalculateInvoiceTotal();

        
    }

    public class HourlyContract : BaseContract
    {
        public decimal TotalHours { get; set; }

        public HourlyContract(string clientName, decimal hourlyRate) : base(clientName)
        {  BaseRate = hourlyRate; }
        public override decimal CalculateInvoiceTotal()
        {
            /* TODO
             * needs to access project type to calculate the price, based off of a menu
             */
            return (TotalHours * BaseRate) + AdditionalFees;
        }
    }

    public class ProjectContract : BaseContract
    {
        public ProjectContract(string clientName, decimal projectRate) : base(clientName)
        { BaseRate = projectRate; }

        public decimal depositAmount { get; set; }

        public override decimal CalculateInvoiceTotal()
        {
            decimal invoice;
            /* TODO
             * needs to access type of project to calculate 
             * the price, based off of a menu I create
             */

            invoice = BaseRate + AdditionalFees; 
            return invoice;
        }
    }

}
