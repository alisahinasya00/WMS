using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Model.Entities;

namespace WMS.DataAccess.Interfaces
{
    public interface IRafRepository
    {
        Task<Raf> IdGoreGetir(int rafId, params string[] includeList);
        Task<List<Raf>> IsmeGoreGetir(string adi, params string[] includeList);
        Task<List<Raf>> BlokaGoreGetir(int blokId, params string[] includeList);
    }
}
