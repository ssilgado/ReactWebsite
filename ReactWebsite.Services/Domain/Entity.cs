using ReactWebsite.Services.Domain.Contracts;

namespace ReactWebsite.Services.Domain
{
    public class Entity : ICodeable
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}