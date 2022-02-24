using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Struct
{
    class BaseClass
    {
        protected virtual void GetUser()
        {
            MessageBox.Show("Get User Ana Metod");
        }
        protected virtual void GetUser2()
        {
            MessageBox.Show("Get User 2 Ana Metod");
        }
    }
}
