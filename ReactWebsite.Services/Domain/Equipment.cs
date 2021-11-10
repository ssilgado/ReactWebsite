namespace ReactWebsite.Services.Domain
{
    public class Equipment : Product
    {
        readonly double TAX_RATE = 0.07;
        public double UnitPrice { get; set; }
        public int NumberOfUnits { get; set; }

        public override double getFee() => 0;

        public override double getTax() => NumberOfUnits * UnitPrice * TAX_RATE;
        
        public override double getPrice() => NumberOfUnits * UnitPrice;
    }
}