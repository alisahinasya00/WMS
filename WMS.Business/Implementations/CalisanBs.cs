using Infrastructure.Utilities.ApiResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
           

            var calisan = await _repo.GetByIdAsync(id);
            await _repo.DeleteAsync(calisan);

        }

        public Task<ApiResponse<List<Calisan>>> IdGoreCalisanGetir(params string[] includelist)
        {
            throw new NotImplementedException();
        }
    }
}
