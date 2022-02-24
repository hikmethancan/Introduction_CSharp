using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Struct
{
    class SealedClassMiras : BaseClass // SealedClass => Sealed Classlar inherit olamazlar. Bu yüzden SealedClass'ı buraya miras alamıyoruz.
    {
        protected sealed override void GetUser() // =>GetUser metodunu sealed olarak tanımladık. Bu yüzden SealedClassMiras clasını miras alanlar GetUSer metoduna ulaşamayacak.02
        {
            MessageBox.Show("User'i getiriyorum");
        }
        protected override void GetUser2()
        {
            MessageBox.Show("User2'i getiriyorum");
        }
    }
}
