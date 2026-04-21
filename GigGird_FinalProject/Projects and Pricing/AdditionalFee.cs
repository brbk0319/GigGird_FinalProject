using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace GigGird_FinalProject.Projects_and_Pricing
{
    public class AdditionalFee
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Fee { get; set; }
        public decimal Multiplier { get; set; }

        public AdditionalFee(string name, string description, decimal fee, decimal multiplier)
        {
            Name = name;
            Description = description;
            Fee = fee;
            Multiplier = multiplier;
        }
    }
}
