using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Model.Entities
{
    public class GirisIslem
    {
        public int GirisIslemId { get; set; }
        public int UrunID { get; set; }
        public int IslemTuruID { get; set; }
        public int FabrikaID { get; set; }
        public int CalisanID { get; set; }
        public int UrunAdedi { get; set; }
        public DateTime IslemTarihi { get; set; }
    }
}
