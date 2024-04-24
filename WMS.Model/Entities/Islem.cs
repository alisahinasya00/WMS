using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Model.Entities
{
    public class Islem
    {
        public int IslemId { get; set; }
        public int IslemTurID { get; set; }
        public DateTime IslemTarihi { get; set;}

        public IslemTuru IslemTuru { get; set; }

    }
}
