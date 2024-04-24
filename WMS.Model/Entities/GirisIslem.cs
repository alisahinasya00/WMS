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

        public Calisan Calisan { get; set; }
        public Fabrika Fabrika { get; set; }
        public IslemTuru IslemTuru { get; set; }
        public Urun Urun { get; set; }
    }
}
