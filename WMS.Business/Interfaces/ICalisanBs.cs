using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Model.Dtos.Calisan;
using WMS.Model.Dtos.Rol;
using WMS.Model.Entities;

namespace WMS.Business.Interfaces
{
    public interface ICalisanBs
    {
        Task<ApiResponse<List<Calisan>>> IdGoreCalisanGetir(params string[] includelist);
        Task<ApiResponse<List<Calisan>>> IsimGoreCalisanGetir(params string[] includelist);
        Task<ApiResponse<List<Calisan>>> RolGoreCalisanGetir(params string[] includelist);
        Task<ApiResponse<List<CalisanGetDto>>> GetCalisanlarAsync(params string[] includeList);


    }
}
