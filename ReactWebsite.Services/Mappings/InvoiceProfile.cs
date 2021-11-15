using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ReactWebsite.Services.Domain;

namespace ReactWebsite.Services.Mappings
{
    public class InvoiceProfile : Profile
    {
        public InvoiceProfile()
        {
            CreateMap<DataAccess.Entities.Invoice, Invoice>()
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.InvoiceCode))
                .ForMember(dest => dest.Customer, opt => opt.MapFrom<CustomerResolver>())
                .ForMember(dest => dest.SalesPerson, opt => opt.MapFrom<PersonResolver, int>(src => src.PersonId.GetValueOrDefault()))
                .ForMember(dest => dest.InvoiceItems, opt => opt.MapFrom<ProductInvoiceResolver>())
                .AfterMap((src, dest) => dest.ComplianceFee = dest.Customer.Type == 'G' ? 125.00 : 0.00);
        }
    }
}