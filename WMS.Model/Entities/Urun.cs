namespace WMS.Model.Entities
{
    public class Urun
    {
        public int UrunId { get; set; }
        public int KategoriID { get; set; }
        public int StokMiktari { get; set; }
        public string Adi { get; set; }
        public DateTime KayıtTarihi { get; set; }
        public int KonumID { get; set; }
    }
}
