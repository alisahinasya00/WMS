using Infrastructure.Model;

namespace WMS.Model.Entities
{
    public class Blok : IEntity
    {
        public int BlokId { get; set; }
        public string? BlokAdi { get; set; }



       // public Konum? Konum { get; set; }  // Buraya Dikkat 
        public List<Konum?> Konumlar { get; set; }
        public List<Raf>? Raflar { get; set; }
        public List<Bolme>? Bolmeler { get; set; }
       

    }
}
