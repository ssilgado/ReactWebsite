using System.Collections.Generic;

namespace ReactWebsite.Services.Domain
{
    public class Person : Entity
    {
        public IList<string> Emails { get; set; }
    }
}