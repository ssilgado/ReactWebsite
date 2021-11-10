using System;

namespace ReactWebsite.Services.Domain
{
    public class License : Product
    {
        readonly double TAX_RATE = 0.0425;
        public double ServiceFee { get; set; }
        public double AnnualFee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        private double LicenseLength { get { return (EndDate - StartDate).TotalDays / 365; } }

        private double GetLicenseLengthInYears() => (EndDate - StartDate).TotalDays / 365;

        public override double getFee() => ServiceFee;

        public override double getPrice() => AnnualFee * LicenseLength;

        public override double getTax() => AnnualFee * LicenseLength * TAX_RATE;
    }
}