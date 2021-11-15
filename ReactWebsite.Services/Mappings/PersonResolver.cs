using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ReactWebsite.DataAccess;
using ReactWebsite.Services.Domain;

namespace ReactWebsite.Services.Mappings
{
    public class PersonResolver : IMemberValueResolver<object, object, int, Person>
    {
        private readonly ReactWebsiteContext _reactWebsiteContext;
        private readonly IMapper _mapper;

        public PersonResolver(ReactWebsiteContext reactWebsiteContext, IMapper mapper)
        {
            _reactWebsiteContext = reactWebsiteContext;
            _mapper = mapper;
        }

        public Person Resolve(object source, object destination, int sourceMember, Person destMember, ResolutionContext context)
        {
            if (source is DataAccess.Entities.Invoice)
            {
                var src = (DataAccess.Entities.Invoice)source;
                if (src.Person != null) return _mapper.Map<Person>(src.Person);
            } else if (source is DataAccess.Entities.Customer)
            {
                var src = (DataAccess.Entities.Customer)source;
                if (src.Person != null) return _mapper.Map<Person>(src.Person);
            } else if (source is DataAccess.Entities.Product)
            {
                var src = (DataAccess.Entities.Product)source;
                if (src.Consultant != null) return _mapper.Map<Person>(src.Consultant);
            }

            var personData = _reactWebsiteContext.People.AsNoTracking()
                .Include(o => o.Address)
                    .ThenInclude(o => o.State)
                .Include(o => o.Address)
                    .ThenInclude(o => o.Country)
                .Where(o => o.PersonId == sourceMember).SingleOrDefault();
            
            return _mapper.Map<Person>(personData);
        }
    }
}