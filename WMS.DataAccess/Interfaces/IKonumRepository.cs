using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Model.Entities;

namespace WMS.DataAccess.Interfaces
{
    public interface IKonumRepository
    {
        Task<Konum> IdGoreGetir(int konumId, params string[] includeList);
        Task<List<Konum>> BlokaGoreGetir(string blokAdi, params string[] includeList);
        Task<List<Konum>> RafaGoreGetir(string rafAdi, params string[] includeList);
        Task<List<Konum>> BolmeyeGoreGetir(string bolmeAdi, params string[] includeList);
    }
}
