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

        Task<List<CikisIslem>> UrunAdaGoreGetir(string urunAdi, params string[] includeList);

        Task<List<CikisIslem>> IslemTurAdaGoreGetir(string islemTurAdi, params string[] includeList);

        Task<List<CikisIslem>> MagazaAdaGoreGetir(string magazaAdi, params string[] includeList);

        Task<List<CikisIslem>> TariheGoreGetir(DateTime baslangicTarihi, DateTime bitisTarihi, params string[] includeList);

        Task<List<CikisIslem>> CalisanAdaGoreGetir(string calisanAdi, params string[] includeList);
    }
}
