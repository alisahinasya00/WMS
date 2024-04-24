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
        public string? SiparisDurum { get; set; }

        public IslemTuru? IslemTuru { get; set; }
        public IadeIslem? IadeIslem { get; set; }
        public Magaza? Magaza { get; set; }
        public Calisan? Calisan { get; set; }

    }
}
