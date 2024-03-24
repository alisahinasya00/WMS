using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Model.Entities;

namespace WMS.Business.Interfaces
{
    public interface IRolBs
    {
        Task<ApiResponse<Rol>> IdGoreRolGetir(int rolId, params string[] includeList);

    }
}
