using AutoMapper;
using ReactWebsite.Services.Domain;

namespace ReactWebsite.Services.Mappings
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<DataAccess.Entities.Customer, Customer>()
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.CustomerCode))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Address, opt => opt.MapFrom<AddressResolver, int>(src => src.AddressId.GetValueOrDefault()))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.PrimaryContact, opt => opt.MapFrom<PersonResolver, int>(src => src.PersonId.GetValueOrDefault()))
                .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}