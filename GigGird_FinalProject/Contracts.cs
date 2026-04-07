using System;
using System.Collections.Generic;
using System.Text;

namespace GigGird_FinalProject
{
    abstract class BaseContract : ISaveable
    {
        public string ClientName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateCompleted { get; set; }

        protected double BaseRate { get; set; }
        protected double AdditionalFees { get; set; }


        protected BaseContract(string clientName)
        {
            ClientName = clientName;
            DateCreated = DateTime.Now;
        }

        public abstract double CalculateInvoiceTotal();

        
    }

    class HourlyContract : BaseContract
    {
        public double TotalHours { get; set; }

        public HourlyContract(string clientName, double hourlyRate) : base(clientName)
        {  BaseRate = hourlyRate; }
        public override double CalculateInvoiceTotal()
        {
            /* TODO
             * needs to access total hours and type of project
             * to calculate the price, based off of a menu I create
             */
            return (TotalHours * BaseRate) + AdditionalFees;
        }
    }

    class ProjectContract : BaseContract
    {
        public ProjectContract(string clientName, double projectRate) : base(clientName)
        { BaseRate = projectRate; }

        public override double CalculateInvoiceTotal()
        {
            double invoice;
            /* TODO
             * needs to access type of project to calculate 
             * the price, based off of a menu I create
             */

            invoice = BaseRate + AdditionalFees; 
            return invoice;
        }
    }

}
