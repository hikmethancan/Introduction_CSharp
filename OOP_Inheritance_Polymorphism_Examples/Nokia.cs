using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_Polymorphism_Examples
{
    class Nokia : Phones
    {
        public Nokia()
        {
            this.Brand = "Nokia";
        }

        public override void CallSound()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sounds\nokia.waw"))
            {
                player.PlaySync();
            }
        }
    }
}
