using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RIK_HomeWork.Models
{
    public class JurIsik
    {
        public int Id { get; set; }
        public int YritusID { get; set; }
        public string Jurnimi { get; set; }
        public string FirmaKood { get; set; }
        public int Makseviis { get; set; }
        public string Lisainfo { get; set; }

    }
}