using AutoMapper;
using ReactWebsite.Services.Domain;

namespace ReactWebsite.Services.Mappings
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<DataAccess.Entities.Address, Address>()
                .ForMember(dest => dest.Street, opt => opt.MapFrom(src => src.Street))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
                .ForMember(dest => dest.State, opt => opt.MapFrom(src => src.State.Name))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country.Name))
                .ForMember(dest => dest.Zip, opt => opt.MapFrom(src => src.Zip));
        }
    }
}