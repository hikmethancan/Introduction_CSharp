using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Struct
{
    sealed class SealedClass
    {

        // sealed anahtar sözcüğü, kendisinden nesne türetilebilir, fakat miras verilemez anlamına gelir. Abstract class'ın aksine bir çalışma mantığı vardır. Abstract yapılarda miras alınabilir, ancak kendisinden nesne türetilmesine izin vermez.

        // Eğer property veya metotları sealed olarak işaretlerseniz miras verdiğiniz class içerisinde ilgili nesneye ulaşamayacaksınız.

        public int sayi1;
        public int sayi2;
        public string sonucMetin;
    }
}
