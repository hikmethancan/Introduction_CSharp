using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Intro
{
    class FirstClass
    {
        private int _ID;
        public int Id { get { return _ID; } set {_ID = value; } }

        private string _name;
        public string Name { get { return _name; } set {_name = value; } }

        private string _lastName;
        public string LastName { get { return _lastName; } set { _lastName = value; } }

        private double _height;
        public double Height { get { return _height; } set { _height = value; } }

        private double _weight;
        public double Weight { get { return _weight; } set { _weight = value; } }

        private int _age;
        public int Age 
        { 
            get { return _age; } 
            set
            {
                if (value >= 10 && value <= 90)
                {
                    _age = value;
                }
                else
                {
                    MessageBox.Show("Yaş aralıgı 10'dan kücük 90'dan büyük olamaz !!..");
                }
            }
        }



    }
}
