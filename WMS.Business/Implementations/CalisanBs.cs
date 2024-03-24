using AutoMapper;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using WMS.Business.CustomExceptions;
using WMS.Business.Interfaces;
using WMS.DataAccess.Interfaces;
using WMS.Model.Dtos.Calisan;
using WMS.Model.Dtos.Rol;
using WMS.Model.Entities;

namespace WMS.Business.Implementations
{
    public class CalisanBs : ICalisanBs
    {
        private readonly ICalisanRepository _repo;
        private readonly IMapper _mapper;
        public CalisanBs(ICalisanRepository repo, IMapper mapper)
        {
            _repo= repo;
            _mapper= mapper;
        }

        public async Task<ApiResponse<NoData>> DeleteAsync(int id)
        {

            var calisan = await _repo.IdGoreGetir(id);
            await _repo.DeleteAsync(calisan);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }

        public async Task<ApiResponse<List<CalisanGetDto>>> GetCalisanlarAsync(params string[] includeList)
        {
            var calisanlar = await _repo.GetAllAsync(includeList: includeList);
            if (calisanlar.Count > 0)
            {
                var returnList = _mapper.Map<List<CalisanGetDto>>(calisanlar);
                var response = ApiResponse<List<CalisanGetDto>>.Success(StatusCodes.Status200OK, returnList);
                return response;
            }
            throw new NotFoundException("İçerik Bulunamadı");
        }

        public Task<ApiResponse<List<Calisan>>> IdGoreCalisanGetir(params string[] includelist)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<List<Calisan>>> IsimGoreCalisanGetir(params string[] includelist)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<List<Calisan>>> RolGoreCalisanGetir(params string[] includelist)
        {
            throw new NotImplementedException();
        }
    }
}
