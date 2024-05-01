using AutoMapper;
using WMS.Model.Dtos.Islem;
using WMS.Model.Entities;

namespace WMS.Business.Profiles
{
    public class IslemProfile : Profile
    {
        public IslemProfile() {
            CreateMap<Islem, IslemGetDto>();
            CreateMap<IslemPutDto, Islem>();
            CreateMap<IslemPostDto, Islem>();
        }
    }
}
