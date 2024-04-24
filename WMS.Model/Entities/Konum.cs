namespace WMS.Model.Entities
{
    public class Konum
    {
        public int KonumId { get; set; }
        public int BlokID { get; set; }
        public int RafID { get; set; }
        public int BolmeID { get; set;}

        public Bolme Bolme { get; set; }
        public List<Blok>? Bloklar { get; set; }
        public List<Raf>? Raflar { get; set; }
        public Urun Urun { get; set; }



    }
}
