using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using WMS.Business.CustomExceptions;
using WMS.Business.Interfaces;
using WMS.DataAccess.Interfaces;
using WMS.Model.Entities;

namespace WMS.Business.Implementations
{
    public class RolBs : IRolBs
    {
        private readonly IRolRepository _repo;

        public RolBs(IRolRepository repo)
        {
            _repo = repo;
        }

        public async Task<ApiResponse<NoData>> DeleteAsync(int id)
        {

            var rol = await _repo.IdGoreGetir(id);
            await _repo.DeleteAsync(rol);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }

        public async Task<ApiResponse<Rol>> IdGoreRolGetir(int rolId, params string[] includeList)
        {
            if (rolId <= 0)
                throw new BadRequestException("id değeri 0 dan büyük olmalıdır");

            var rol = await _repo.IdGoreGetir(rolId, includeList);
            if (rol != null)
            {
                return ApiResponse<Rol>.Success(StatusCodes.Status200OK,rol);
            }

            throw new NotFoundException("İçerik Bulunamadı");
        }
    }
}
