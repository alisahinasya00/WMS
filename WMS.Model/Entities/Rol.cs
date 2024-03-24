using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Model.Entities
{
    public class Rol : IEntity
    {
        public int RolId { get; set; }
        public string RolAdi { get; set; }

        public List<Calisan>? Calisanlar { get; set; }
    }
}
