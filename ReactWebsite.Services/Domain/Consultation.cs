namespace ReactWebsite.Services.Domain
{
    public class Consultation : Product
    {
        readonly double TAX_RATE = 0.0425;
        readonly double SERVICE_FEE = 150.0;
        public Person Consultant { get; set; }
        public double HourlyFee { get; set; }
        public double BillableHours { get; set; }

        public override double GetFee() => SERVICE_FEE;

        public override double GetPrice() => BillableHours * HourlyFee;

        public override double GetTax() => BillableHours * HourlyFee * TAX_RATE;
    }
}