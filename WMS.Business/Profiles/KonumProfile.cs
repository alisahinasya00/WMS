using AutoMapper;
using WMS.Model.Dtos.Konum;
using WMS.Model.Entities;

namespace WMS.Business.Profiles
{
    public class KonumProfile : Profile
    {
        public KonumProfile() {
            CreateMap<Konum, KonumGetDto>();
            CreateMap<KonumPutDto, Konum>();
            CreateMap<KonumPostDto, Konum>();
        }
    }
}
