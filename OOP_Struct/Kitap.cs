using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Struct
{
    public struct Kitap
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Turu { get; set; }
        public string ISBNNO { get; set; }
        public string YazarAdi { get; set; }

        public Kitap(int ıd, string ad, string tur, string ısbnno,string yazarAdi)
        {
            this.Ad = ad;
            this.Id = ıd;
            this.Turu = tur;
            this.ISBNNO = ısbnno;
            this.YazarAdi = yazarAdi;
        }
    }
}
