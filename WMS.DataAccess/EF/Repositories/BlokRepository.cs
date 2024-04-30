using Infrastructure.DataAccess.Implementations.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.DataAccess.EF.Contexts;
using WMS.DataAccess.Interfaces;
using WMS.Model.Entities;

namespace WMS.DataAccess.EF.Repositories
{
    public class BlokRepository : BaseRepository<Blok, WMSDbContext>, IBlokRepository
    {
        public async Task<Blok> IdGoreGetir(int blokId, params string[] includeList)
        {
            return await GetAsync(add => add.BlokId == blokId, includeList);
        }

        public async Task<List<Blok>> IsmeGoreGetir(string adi, params string[] includeList)
        {
            return await GetAllAsync(add => add.BlokAdi == adi, includeList);
        }
    }
}
