using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Struct
{
    class SealedClassMirasMirasi : SealedClassMiras
    {
        //protected override void GetUser()  =>      Bu metodu çağıramayız çünkü bu metod miras aldıgımız classta sealed olarak korunuyoruz ulaşamıyoruz.
        //{
        //    base.GetUser();)
        //}

        protected override void GetUser2() // => GetUser2 metoduna ulasaibliyoruz cünkü sealed olarak tanımlanmadı.
        {
            base.GetUser2();
        }
    }
}
