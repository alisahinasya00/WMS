using Infrastructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Model.Entities;

namespace WMS.DataAccess.Interfaces
{
    public interface IGirisIslemRepository : IBaseRepository<GirisIslem>
    {
        Task<GirisIslem> IdGoreGetir(int girisIslemId, params string[] includeList);

        Task<List<GirisIslem>> UrunAdaGoreGetir(string urunAdi, params string[] includeList);   
   
        Task<List<GirisIslem>> IslemTuruAdaGoreGetir(string islemTurAdi,  params string[] includeList);

        Task<List<GirisIslem>> FabrikaAdaGoreGetir(string fabrikaAdi, params string[] includeList);

        Task<List<GirisIslem>> TariheGoreGetir(DateTime baslangicTarihi, DateTime bitisTarihi, params string[] includeList);

        Task<List<GirisIslem>> CalisanAdaGoreGetir(string calisanAdi,  params string[] includeList);

    }
}
