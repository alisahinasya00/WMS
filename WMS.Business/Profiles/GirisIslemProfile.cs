using AutoMapper;
using WMS.Model.Dtos.GirisIslem;
using WMS.Model.Entities;

namespace WMS.Business.Profiles
{
    public class GirisIslemProfile : Profile
    {
        public GirisIslemProfile() {
            CreateMap<GirisIslem, GirisIslemGetDto>();
            CreateMap<GirisIslemPutDto, GirisIslem>();
            CreateMap<GirisIslemPostDto, GirisIslem>();
        }
    }
}
