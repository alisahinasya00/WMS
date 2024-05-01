using Infrastructure.Model;

namespace WMS.Model.Entities
{
    public class CikisIslem : IEntity
    {
        public int CikisIslemId { get; set; }
        public int UrunID { get; set; }
        public int IslemTuruID { get;set; }
        public int MagazaID { get; set; }
        public int CalisanID { get; set; }
        public int UrunAdedi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public List<IslemTur>? IslemTurler { get; set; }
        public Magaza? Magaza { get; set; }
        public Calisan? Calisan { get; set; }
        public Urun Urun { get; set; }

    }
}
