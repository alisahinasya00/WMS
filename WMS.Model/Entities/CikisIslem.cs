using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Model.Entities
{
    public class CikisIslem
    {
        public int CikisIslemId { get; set; }
        public int UrunID { get; set; }
        public int IslemTuruID { get;set; }
        public int MagazaID { get; set; }
        public int CalisanID { get; set; }
        public int UrunAdedi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string SiparisDurum { get; set; }
    }
}
