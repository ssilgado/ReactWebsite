using AutoMapper;
using ReactWebsite.Services.Domain;

namespace ReactWebsite.Services.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ReactWebsite.DataAccess.Entities.Product, Equipment>()
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.ProductCode))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.PricePerUnit));
            
            CreateMap<ReactWebsite.DataAccess.Entities.Product, Consultation>()
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.ProductCode))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.HourlyFee, opt => opt.MapFrom(src => src.PricePerHour))
                .ForMember(dest => dest.Consultant, opt => opt.MapFrom<PersonResolver, int>(src => src.ConsultantId.GetValueOrDefault()));
            
            CreateMap<ReactWebsite.DataAccess.Entities.Product, License>()
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.ProductCode))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ServiceFee, opt => opt.MapFrom(src => src.ServiceFee))
                .ForMember(dest => dest.AnnualFee, opt => opt.MapFrom(src => src.AnnualFee));
        }
    }
}