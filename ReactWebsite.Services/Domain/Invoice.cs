using System;
using System.Collections.Generic;
using ReactWebsite.Services.Domain.Contracts;

namespace ReactWebsite.Services.Domain
{
    public class Invoice : ICodeable
    {
        public string Code { get; set; }
        public Customer Customer { get; set; }
        public Person Person { get; set; }
        public double ComplianceFee { get; set; }
        public IList<Product> InvoiceItems { get; set; }

        public double getTotalTax() {
            double totalTax = 0;
            if (Customer.Type == 'C')
            {
                foreach (var item in InvoiceItems)
                {
                    totalTax += item.GetTax();
                }
            }
            return totalTax;
        }

        public double getTotalFee() {
            double totalFee = 0;
            foreach (var item in InvoiceItems)
            {
                totalFee += item.GetFee();
            }
            return Math.Round(totalFee, 2, MidpointRounding.AwayFromZero);
        }

        public double getTotalPrice() {
            double totalPrice = 0;
            foreach (var item in InvoiceItems)
            {
                totalPrice += item.GetPrice();
            }
            return Math.Round(totalPrice, 2, MidpointRounding.AwayFromZero);
        }

        public double getInvoiceTotal() {
            double total = 0;
            total += ComplianceFee;
            total += getTotalFee();
            total += getTotalTax();
            total += getTotalPrice();
            return total;
        }
    }
}
