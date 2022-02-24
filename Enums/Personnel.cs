using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum Departmans : byte
    {
        Yazilim = 10,SistemAgUzmanligi,GrafikTasarim,Ingilizce,Muhasebe
    } 
    class Personnel
    {
        /*
        * ENUM
        * Kisilere sabit secenekler sunmak icin kullanilan bir deger tipidir.Secenekleri kontrol altinda tutup, uygulamanizi da kendi kontrolunuz cercevesinde yonetebilirsiniz. Bu sebeple uygulamanizda herhangi bir surprize yer birakmadan cok daha performansli ve cok daha guvenli bir yapiyi olusturmus olursunuz.
        */

        private string _nameSurname;
        public string NameSurname { get { return _nameSurname; } set {_nameSurname = value; } }

        private Departmans _departman;
        public Departmans  Departman { get {return _departman; } set {_departman = value; } }

    }
}
