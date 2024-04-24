namespace WMS.Model.Entities
{
    public class IadeIslem
    {
        public int IadeIslemId { get; set; }
        public int UrunID { get; set; }
        public int IslemTuruID { get; set;}
        public int MagazaID { get; set;}
        public int CalisanID { get; set; }
        public int UrunAdedi { get;set;}
        public DateTime IslemTarihi { get; set; }
        public string? IadeDurumu { get; set; }


        public Calisan? Calisan { get; set; }
        public Magaza? Magaza { get; set; }
        public Urun? Urun { get; set; }
        public IslemTuru? IslemTuru { get; set; }

    }
}
