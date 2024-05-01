using AutoMapper;
using WMS.Model.Dtos.Bolme;
using WMS.Model.Entities;

namespace WMS.Business.Profiles
{
    public class BolmeProfile : Profile
    {
        public BolmeProfile() {
            CreateMap<Bolme, BolmeGetDto>();
            CreateMap<BolmePutDto, Bolme>();
            CreateMap<BolmePostDto, Bolme>();

        }
    }
}
