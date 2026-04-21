namespace GigGird_FinalProject.Money
{
    public class PriceType
    {
        public string Name {get; set;}
        public decimal PriceRate {get; set;}
        public string Description {get; set;}

        public PriceType(string name, decimal priceRate, string description)
        {
            Name = name;
            PriceRate = priceRate;
            Description = description;
        }
    }
}