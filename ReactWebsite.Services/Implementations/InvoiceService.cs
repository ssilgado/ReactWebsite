using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ReactWebsite.DataAccess;
using ReactWebsite.Services.Contracts;
using ReactWebsite.Services.Domain;

namespace ReactWebsite.Services.Implementations
{
    public class InvoiceService : IInvoiceService
    {
        private readonly ReactWebsiteContext _reactWebsiteContext;
        private readonly IMapper _mapper;

        public InvoiceService(ReactWebsiteContext reactWebsiteContext, IMapper mapper)
        {
            _reactWebsiteContext = reactWebsiteContext;
            _mapper = mapper;
        }

        public Invoice GetInvoiceWithDetails(string code)
        {
            var invoiceData = _reactWebsiteContext.Invoices.AsNoTracking()
                .Where(o => o.InvoiceCode == code).SingleOrDefault();
            
            return _mapper.Map<Invoice>(invoiceData);

        }
    }
}