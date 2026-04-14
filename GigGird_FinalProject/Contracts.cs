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

        public abstract void CalculateAdditionalFees();
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

            CalculateAdditionalFees();
            return (TotalHours * BaseRate) + AdditionalFees;
        }

        public override void CalculateAdditionalFees()
        {
            //Ask user for whatever needs additional fees, check again before calculating total
        }

        public void UpdateHours()
        {
            //TODO: ask user for dates/times worked
            decimal newHours = 0;
            TotalHours += newHours;
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
            CalculateAdditionalFees();

            invoice = BaseRate + AdditionalFees; 
            return invoice;
        }

        public override void CalculateAdditionalFees()
        {
            //Ask user for whatever needs additional fees, check again before calculating total
        }
    }

    public class ReOccuringContract : BaseContract
    {
        public ReOccuringContract(string clientName, decimal projectRate) : base(clientName)
        { BaseRate = projectRate; }

        public decimal depositAmount { get; set; }

        public override decimal CalculateInvoiceTotal()
        {
            decimal invoice;
            /* TODO
             * needs to access type of project to calculate 
             * the price, based off of a menu I create
             */
            CalculateAdditionalFees();

            invoice = BaseRate + AdditionalFees;
            return invoice;
        }

        //TODO: method to remind to send invoice?

        public override void CalculateAdditionalFees()
        {
            //Ask user for whatever needs additional fees, check again before calculating total
        }
    }
}
