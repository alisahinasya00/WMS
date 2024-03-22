using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Model.Entities
{
    public class Calisan : IEntity
    {
        public int CalisanId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Maas { get;  set; }
        public string TelefonNo { get; set; }
        public string Adres { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public int RolId { get; set; }

        public Rol Rol { get; set;}

    }
}
