using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using WMS.Business.Interfaces;
using WMS.DataAccess.Interfaces;
using WMS.Model.Entities;

namespace WMS.Business.Implementations
{
    public class CalisanBs : ICalisanBs
    {
        private readonly ICalisanRepository _repo;

        public CalisanBs(ICalisanRepository repo)
        {
            _repo= repo;
        }

        public async Task<ApiResponse<NoData>> DeleteAsync(int id)
        {
           

            var calisan = await _repo.IdGoreGetir(id);
            await _repo.DeleteAsync(calisan);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }

        public Task<ApiResponse<List<Calisan>>> IdGoreCalisanGetir(params string[] includelist)
        {
            throw new NotImplementedException();
        }
    }
}
