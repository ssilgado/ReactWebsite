using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ReactWebsite.DataAccess;
using ReactWebsite.Services.Domain;

namespace ReactWebsite.Services.Mappings
{
    public class AddressResolver : IMemberValueResolver<object, object, int, Address>
    {
        private readonly ReactWebsiteContext _reactWebsiteContext;
        private readonly IMapper _mapper;

        public AddressResolver(ReactWebsiteContext reactWebsiteContext, IMapper mapper)
        {
            _reactWebsiteContext = reactWebsiteContext;
            _mapper = mapper;
        }

        public Address Resolve(object source, object destination, int sourceMember, Address destMember, ResolutionContext context)
        {
            if (source is DataAccess.Entities.Person)
            {
                var src = (DataAccess.Entities.Person)source;
                if (src.Address != null) return _mapper.Map<Address>(src.Address);
            } else if (source is DataAccess.Entities.Customer)
            {
                var src = (DataAccess.Entities.Customer)source;
                if (src.Address != null) return _mapper.Map<Address>(src.Address);
            }

            var addressData = _reactWebsiteContext.Addresses.AsNoTracking()
                .Include(o => o.State)
                .Include(o => o.Country)
                .Where(o => o.AddressId == sourceMember)
                .SingleOrDefault();
            
            return _mapper.Map<Address>(addressData);
        }
    }
}