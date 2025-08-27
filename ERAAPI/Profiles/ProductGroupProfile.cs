using AutoMapper;
using ERAAPI.DTO.ProductGroupDTO;
using ERAAPI.Models;
namespace ERAAPI.Profiles
{
    
    public class ProductGroupProfile :Profile
    {
        public ProductGroupProfile()
        {
            CreateMap<ProductGroupCreateDTO, ProductGroup>()
                .ForMember(dest => dest.GroupUnderName, opt => opt.Ignore())
                .ForMember(dest => dest.ExtraDate, opt => opt.Ignore())
                .ForMember(dest => dest.Extra1, opt => opt.Ignore())
                .ForMember(dest => dest.Extra2, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedDate, opt => opt.Ignore());

            CreateMap<ProductGroup, ProductGroupCreateDTO>();
        }
    }
}
