using AutoMapper;
using ERAAPI.DTO.UnitDTO;
using ERAAPI.Models;

namespace ERAAPI.Profiles
{
    public class UnitProfile : Profile
    {

        public UnitProfile()
        {
            CreateMap<UnitCreateOrUpdateDTO, Unit>()
                .ForMember(dest => dest.Extra1, opt => opt.Ignore())
                .ForMember(dest => dest.Extra2, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedDate, opt => opt.Ignore());

            CreateMap<Unit, UnitCreateOrUpdateDTO>();
        }
    }
}
