namespace WMS.Model.Entities
{
    public class IslemTur
    {
        public int IslemTurId { get; set; }
        public string IslemAdi { get; set; }

        public List<Islem>? Islemler { get; set; }
        public List<GirisIslem>? GirisIslemler { get; set; }
        public List<CikisIslem>? CikisIslemler { get; set; }
        public List<IadeIslem>? IadeIslemler { get; set; }
    }
}
