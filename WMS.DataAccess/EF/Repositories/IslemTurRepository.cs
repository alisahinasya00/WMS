﻿using Infrastructure.DataAccess.Implementations.EF;
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
    public class IslemTurRepository : BaseRepository<IslemTur, WMSDbContext>, IIslemTurRepository
    {
        public async Task<IslemTur> IdGoreGetir(int islemTurId, params string[] includeList)
        {
            return await GetAsync(islemTur => islemTur.IslemTurId == islemTurId, includeList);

        }
    }
}
