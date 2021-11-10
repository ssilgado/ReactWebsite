namespace ReactWebsite.Services.Domain
{
    public class Equipment : Product
    {
        readonly double TAX_RATE = 0.07;
        public double UnitPrice { get; set; }
        public int NumberOfUnits { get; set; }

        public override double GetFee() => 0;

        public override double GetTax() => NumberOfUnits * UnitPrice * TAX_RATE;
        
        public override double GetPrice() => NumberOfUnits * UnitPrice;
    }
}