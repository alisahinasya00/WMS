using AutoMapper;
using WMS.Model.Dtos.Konum;
using WMS.Model.Entities;

namespace WMS.Business.Profiles
{
    public class KonumProfile : Profile
    {
        public KonumProfile() {
            CreateMap<Konum, KonumGetDto>()
                .ForMember(dest => dest.BlokAdi,
                       opt => opt.MapFrom(src => src.Bloklar.BlokAdi))
                .ForMember(dest => dest.BolmeAdi,
                       opt => opt.MapFrom(src => src.Bolme.BolmeAdi))
                .ForMember(dest => dest.RafAdi,
                           opt => opt.MapFrom(src => src.Raflar.RafAdi));
            CreateMap<KonumPutDto, Konum>();
            CreateMap<KonumPostDto, Konum>();
        }
    }
}
