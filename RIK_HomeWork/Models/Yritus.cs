using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RIK_HomeWork.Models
{
    public class Yritus
    {
        public int Id { get; set; }
        public string Yritus_nimi { get; set; }
        public DateTime Kuupaev { get; set; }
        public string Asukoht { get; set; }
        public string Lisainfo { get; set; }

    }
}