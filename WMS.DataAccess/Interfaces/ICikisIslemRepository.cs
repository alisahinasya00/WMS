using Infrastructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Model.Entities;

namespace WMS.DataAccess.Interfaces
{
    public interface ICikisIslemRepository: IBaseRepository<CikisIslem>
    {
        Task<CikisIslem> IdGoreGetir(int cikisIslemId, params string[] includeList);

        Task<List<CikisIslem>> UrunIdGoreGetir(int urunId, params string[] includeList);

        Task<List<CikisIslem>> IslemTuruIdGoreGetir(int islemTurId, params string[] includeList);

        Task<List<CikisIslem>> MagazaIdGoreGetir(int magazaId, params string[] includeList);

        Task<List<CikisIslem>> TariheGoreGetir(DateTime baslangicTarihi, DateTime bitisTarihi, params string[] includeList);

        Task<List<CikisIslem>> CalisanIdGoreGetir(int calisanId, params string[] includeList);
    }
}
