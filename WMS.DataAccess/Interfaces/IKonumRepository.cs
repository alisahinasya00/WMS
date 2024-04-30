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
        Task<List<Konum>> BlokaGoreGetir(int blokId, params string[] includeList);
        Task<List<Konum>> RafaGoreGetir(int rafId, params string[] includeList);
        Task<List<Konum>> BolmeyeGoreGetir(int bolmeId, params string[] includeList);
    }
}
