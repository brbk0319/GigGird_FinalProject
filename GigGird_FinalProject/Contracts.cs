using GigGird_FinalProject.Clients;
using GigGird_FinalProject.Money;
using GigGird_FinalProject.Projects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GigGird_FinalProject
{
    public abstract class BaseContract : ISaveable
    { // all about the money
        public Client Client { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime Deadline { get; set; }

        public PriceType ProjectType {get; set; } 
        //TODO: BaseRate = price rate (in project)
        private decimal _additionalFees;
        public decimal AdditionalFees
        {
            get { return _additionalFees; }
            set { _additionalFees = value < 0 ? 0 : value; }
        }


        public BaseContract(Client client)
        {
            Client = client;
            DateCreated = DateTime.Now;
        }

        public BaseContract(Client client, PriceType projectType)
        {
            Client = client;
            ProjectType = projectType;
            DateCreated = DateTime.Now;
        }

        public abstract decimal CalculateInvoiceTotal();

        public abstract void CalculateAdditionalFees();
    }

    public class HourlyContract : BaseContract
    {
        public decimal TotalHours { get; set; }

        public HourlyContract(Client client, PriceType projectType) : base(client, projectType)
        { }
        public override decimal CalculateInvoiceTotal()
        {
            /* TODO:
             * figure out additionalFees
             */

            CalculateAdditionalFees();
            return (TotalHours * ProjectType.PriceRate) + AdditionalFees;
        }

        public override void CalculateAdditionalFees()
        {
            //TODO: Ask user for whatever needs additional fees, check again before calculating total
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
        public ProjectContract(Client client, PriceType projectType) : base(client, projectType)
        {}

        public decimal depositAmount { get; set; }

        public override decimal CalculateInvoiceTotal()
        {
            decimal invoice;
            /* TODO:
             * needs to access type of project to calculate 
             * the price, based off of a menu I create
             */
            CalculateAdditionalFees();

            invoice = ProjectType.PriceRate + AdditionalFees; 
            return invoice;
        }

        public override void CalculateAdditionalFees()
        {
            //TODO: Ask user for whatever needs additional fees, check again before calculating total
        }
    }

    public class ReOccuringContract : BaseContract
    {
        public ReOccuringContract(Client client, PriceType projectType) : base(client, projectType)
        { }

        public decimal depositAmount { get; set; }

        public override decimal CalculateInvoiceTotal()
        {
            decimal invoice;
            /* TODO:
             * needs to access type of project to calculate 
             * the price, based off of a menu I create
             */
            CalculateAdditionalFees();

            invoice = ProjectType.PriceRate + AdditionalFees;
            return invoice;
        }

        //TODO: method to remind to send invoice?

        public override void CalculateAdditionalFees()
        {
            //TODO: ask user for whatever needs additional fees, check again before calculating total
        }
    }
}
