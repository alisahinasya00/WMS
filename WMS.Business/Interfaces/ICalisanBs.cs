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
        Task<ApiResponse<List<CalisanGetDto>>> IsimGoreCalisanGetirAsync(string adi, params string[] includeList);
        Task<ApiResponse<List<CalisanGetDto>>> GetCalisanlarAsync(params string[] includeList);
        Task<ApiResponse<List<CalisanGetDto>>> RoleGoreCalisanGetirAsync(int rol,params string[] includeList);


    }
}
