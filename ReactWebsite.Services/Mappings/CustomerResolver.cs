using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ReactWebsite.DataAccess;
using ReactWebsite.Services.Domain;

namespace ReactWebsite.Services.Mappings
{
    public class CustomerResolver : IValueResolver<ReactWebsite.DataAccess.Entities.Invoice, Invoice, Customer>
    {
        private readonly ReactWebsiteContext _reactWebsiteContext;
        private readonly IMapper _mapper;

        public CustomerResolver(ReactWebsiteContext reactWebsiteContext, IMapper mapper)
        {
            _reactWebsiteContext = reactWebsiteContext;
            _mapper = mapper;
        }

        public Customer Resolve(DataAccess.Entities.Invoice source, Invoice destination, Customer destMember, ResolutionContext context)
        {
            if (source.Customer != null) return _mapper.Map<Customer>(source.Customer);

            var customerData = _reactWebsiteContext.Customers.AsNoTracking()
                .Include(o => o.Person)
                .Include(o => o.Address)
                    .ThenInclude(o => o.State)
                .Include(o => o.Address)
                    .ThenInclude(o => o.Country)
                .Where(o => o.CustomerId == source.CustomerId).SingleOrDefault();
            
            return _mapper.Map<Customer>(customerData);
        }
    }
}