using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ReactWebsite.DataAccess;
using ReactWebsite.Services.Domain;

namespace ReactWebsite.Services.Mappings
{
    public class ProductInvoiceResolver : IValueResolver<ReactWebsite.DataAccess.Entities.Invoice, Invoice, IList<Product>>
    {
        private readonly ReactWebsiteContext _reactWebsiteContext;
        private readonly IMapper _mapper;

        public ProductInvoiceResolver(ReactWebsiteContext reactWebsiteContext, IMapper mapper)
        {
            _reactWebsiteContext = reactWebsiteContext;
            _mapper = mapper;
        }

        public IList<Product> Resolve(DataAccess.Entities.Invoice source, Invoice destination, IList<Product> destMember, ResolutionContext context)
        {
            var productInvoiceData = new List<DataAccess.Entities.InvoiceProduct>();
            if (source.InvoiceProducts?.FirstOrDefault()?.Product != null && source.InvoiceProducts.Any())
            {
                productInvoiceData = source.InvoiceProducts.ToList();
            } else
            {
                productInvoiceData = _reactWebsiteContext.InvoiceProducts.AsNoTracking()
                    .Include(o => o.Product)
                    .Where(o => o.InvoiceId == source.InvoiceId).ToList();
            }

            var result = new List<Product>();
            foreach (var productInvoice in productInvoiceData)
            {
                if (productInvoice.Product.Type == "E")
                {
                    var equipment = _mapper.Map<Equipment>(productInvoice.Product);
                    equipment.NumberOfUnits = productInvoice.EquipmentUnits.GetValueOrDefault();

                    result.Add(equipment);
                } else if (productInvoice.Product.Type == "L")
                {
                    var license = _mapper.Map<License>(productInvoice.Product);
                    license.StartDate = productInvoice.StartDate.GetValueOrDefault();
                    license.EndDate = productInvoice.EndDate.GetValueOrDefault();

                    result.Add(license);
                } else if (productInvoice.Product.Type == "C")
                {
                    var consultation = _mapper.Map<Consultation>(productInvoice.Product);
                    consultation.BillableHours = Decimal.ToDouble(productInvoice.BillableHours.GetValueOrDefault());

                    result.Add(consultation);
                }
            }

            return result;
        }
    }
}