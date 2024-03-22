using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Model.Entities
{
    public class Rol
    {
        public int RolId { get; set; }
        public string RolAdi { get; set; }a

        public List <Calisan> Calisanlar { get; set; }
    }
}
