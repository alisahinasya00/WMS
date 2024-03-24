using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Model.Dtos.Rol
{
    public class RolGetDto : IDto
    {
        public int RolId { get; set; }
        public string RolAdi { get; set; }
    }
}
