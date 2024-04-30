﻿using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Model.Dtos.Bolme
{
    public class BolmePostDto : IDto
    {
        public int BlokID { get; set; }
        public int RafID { get; set; }
        public string? BolmeAdi { get; set; }
    }
}
