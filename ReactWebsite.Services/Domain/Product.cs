using ReactWebsite.Services.Domain.Contracts;

namespace ReactWebsite.Services.Domain
{
    public abstract class Product : ICodeable
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public abstract double GetFee();
        public abstract double GetPrice();
        public abstract double GetTax();
    }
}