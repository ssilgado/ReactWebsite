using AutoMapper;
using ReactWebsite.Services.Domain;

namespace ReactWebsite.Services.Mappings
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<DataAccess.Entities.Person, Person>()
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.PersonCode))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Address, opt => opt.MapFrom<AddressResolver, int>(src => src.AddressId.GetValueOrDefault()))
                .ForMember(dest => dest.Emails, opt => opt.MapFrom<EmailResolver>());

        }
    }
}