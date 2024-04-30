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

        Task<List<GirisIslem>> UrunIdGoreGetir( int urunId, params string[] includeList);   
   
        Task<List<GirisIslem>> IslemTuruIdGoreGetir( int islemTurId,  params string[] includeList);

        Task<List<GirisIslem>> FabrikaIdGoreGetir(int fabrikaId, params string[] includeList);

        Task<List<GirisIslem>> TariheGoreGetir(DateTime baslangicTarihi, DateTime bitisTarihi, params string[] includeList);

        Task<List<GirisIslem>> CalisanIdGoreGetir(int calisanId,  params string[] includeList);

    }
}
