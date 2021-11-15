using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ReactWebsite.DataAccess;
using ReactWebsite.Services.Domain;

public class EmailResolver : IValueResolver<ReactWebsite.DataAccess.Entities.Person, Person, IList<string>>
{
    private readonly ReactWebsiteContext _reactWebsiteContext;

    public EmailResolver(ReactWebsiteContext reactWebsiteContext)
    {
        _reactWebsiteContext = reactWebsiteContext;
    }

    public IList<string> Resolve(ReactWebsite.DataAccess.Entities.Person source, Person destination, IList<string> destMember, ResolutionContext context)
    {
        return source.Emails != null && source.Emails.Any() ? source.Emails.Select(o => o.EmailAddress).ToList()
            : _reactWebsiteContext.Emails.Where(o => o.PersonId == source.PersonId).Select(o => o.EmailAddress).ToList();
    }
}