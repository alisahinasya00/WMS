using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.DataAccess.Implementations.EF;
using WMS.DataAccess.EF.Contexts;
using WMS.DataAccess.Interfaces;
using WMS.Model.Entities;


namespace WMS.DataAccess.EF.Repositories
{
    public class BlokRepository : BaseRepository<Blok, WMSDbContext>, IBlokRepository
    {
        public async Task<Blok> IdGoreGetir(int blokId, params string[] includeList)
        {
            return await GetAsync(blok => blok.BlokId == blokId, includeList);
        }

        public async Task<List<Blok>> IsmeGoreGetir(string blokadi, params string[] includeList)
        {
            return await GetAllAsync(blok => blok.BlokAdi == blokadi, includeList);

        }
    }
}
