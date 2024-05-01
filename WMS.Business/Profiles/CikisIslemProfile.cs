using AutoMapper;
using WMS.Model.Dtos.CikisIslem;
using WMS.Model.Entities;

namespace WMS.Business.Profiles
{
    public class CikisIslemProfile : Profile
    {
        public CikisIslemProfile() {
            CreateMap<CikisIslem, CikisIslemGetDto>();
            CreateMap<CikisIslemPutDto, CikisIslem>();
            CreateMap<CikisIslemPostDto, CikisIslem>();
        }
        
    }
}
