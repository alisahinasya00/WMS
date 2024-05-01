using AutoMapper;
using WMS.Model.Dtos.IadeIslem;
using WMS.Model.Entities;

namespace WMS.Business.Profiles
{
    public class IadeIslemProfile : Profile
    {
        public IadeIslemProfile() {
            CreateMap<IadeIslem, IadeIslemGetDto>();
            CreateMap<IadeIslemPutDto, IadeIslem>();
            CreateMap<IadeIslemPostDto, IadeIslem>();
        }
    }
}
