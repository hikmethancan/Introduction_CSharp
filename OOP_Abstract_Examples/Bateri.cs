using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstract_Examples
{
    class Bateri : MuzikAleti
    {
        public override string Call()
        {
            return "Bateri Sesi";
        }

        public override string IsterCalIsterCalma()
        {
            return base.IsterCalIsterCalma();
        }
    }
}
