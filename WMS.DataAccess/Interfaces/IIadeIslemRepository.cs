using Infrastructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Model.Entities;

namespace WMS.DataAccess.Interfaces
{
    public interface IIadeIslemRepository : IBaseRepository<IadeIslem>
    {
        Task<IadeIslem> IdGoreGetir(int iadeIslemId, params string[] includeList);

        Task<List<IadeIslem>> UrunAdaGoreGetir(string urunAdi, params string[] includeList);

        Task<List<IadeIslem>> IslemTuruAdaGoreGetir(string islemTurAdi, params string[] includeList);

        Task<List<IadeIslem>> MagazaAdiGoreGetir(string magazaAdi, params string[] includeList);

        Task<List<IadeIslem>> TariheGoreGetir(DateTime baslangicTarihi, DateTime bitisTarihi, params string[] includeList);

        Task<List<IadeIslem>> CalisanAdaGoreGetir(string calisanAdi, params string[] includeList);
    }
}
