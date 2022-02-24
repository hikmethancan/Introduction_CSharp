using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstract_Examples
{
    //Abstract classlar sadece Base Class olarak kullanılmasını istediğimiz ve kendisinden instance cıkartılmamasını istedigimiz durumlarda kullanılır.
    abstract class MuzikAleti
    {
        //Abstract olarak tanımlanan yapılar mutlaka override edilmelidir.


        public string Brand { get; set; }
        public string Description { get; set; }

        public abstract string Call(); //=> Abstract metodların gövdesi olamaz. Çünkü onlar sadece miras alındığı class larda implement edilebilir.


        public virtual string IsterCalIsterCalma() // Cagırıldıgı yerde default olarak base returnu vardı ve istersek degistirebiliriz.Kullanıslıdır.
        {
            return "Bu Basedeki metoddur";
        }
        
        public string KafanaGore() // => cagırıldıgı yerde sadece basedeki returnu döndürür.
        {
            return "Pasa keyfin bilir metodu :)";
        }
    }
}
