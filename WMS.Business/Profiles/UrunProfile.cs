using AutoMapper;
using WMS.Model.Dtos.Urun;
using WMS.Model.Entities;

namespace WMS.Business.Profiles
{
    public class UrunProfile : Profile
    {
        public UrunProfile() {
            CreateMap<Urun, UrunGetDto>();
            CreateMap<UrunPutDto, Urun>();
            CreateMap<UrunPostDto, Urun>();
        }
    }
}
