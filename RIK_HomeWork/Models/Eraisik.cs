using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RIK_HomeWork.Models
{
    public class Eraisik
    {
        public int Id { get; set; }
        public int Yritus_id { get; set; }
        public string Eesnimi { get; set; }
        public string Perekonnanimi { get; set; }
        public string Isikukood { get; set; }
        public int Makseviis { get; set; }
        public string Lisainfo { get; set; }

    }
}