﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Model.Entities;

namespace WMS.DataAccess.Interfaces
{
    public interface IBolmeRepository
    {
        Task<Bolme> IdGoreGetir(int bolmeId, params string[] includeList);
        Task<List<Bolme>> IsmeGoreGetir(string adi, params string[] includeList);
        Task<List<Bolme>> BlokAdaGoreGetir(string blokAdi, params string[] includeList);
        Task<List<Bolme>> RafAdaGoreGetir(string rafAdi, params string[] includeList);
    }
}
