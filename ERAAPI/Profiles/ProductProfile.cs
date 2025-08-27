using AutoMapper;
using ERAAPI.DTO.Product;
using ERAAPI.Models;

namespace ERAAPI.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductCreateOrUpdateDTO, Product>()
                .ForMember(dest => dest.Barcode, opt => opt.Ignore())  
                .ForMember(dest => dest.Extra1, opt => opt.Ignore())   
                .ForMember(dest => dest.Extra2, opt => opt.Ignore())
                .ForMember(dest => dest.ExtraDate, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedDate, opt => opt.Ignore());

            CreateMap<Product, ProductCreateOrUpdateDTO>()
                .ForMember(dest => dest.PurchaseRate, opt => opt.MapFrom(src => src.PurchaseRate)) // مثال لو فيه تحويلات
                .ForMember(dest => dest.SalesRate, opt => opt.MapFrom(src => src.SalesRate))
                .ForMember(dest => dest.Mrp, opt => opt.MapFrom(src => src.Mrp));
        }
    }
}
