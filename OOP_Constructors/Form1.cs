using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Constructors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Constructor Tanımlamadan Once Yazım Şekli :
            //Car car1 = new Car();
            //car1.Brand = "Ford";
            //car1.Model = "Mustang";
            //car1.Engine = 6000;

            //Constructor Sonrası Yazım Şekli :

            Car car2 = new Car("Ford", "Mustang", 6000);
            MessageBox.Show(car2.Brand + " " + car2.Model);

            // Default Constructor Olarak Brand = "Ford" olarak Car Classımızın içinde tanımlamıştık.Parametre girilmezse def olarak bu gelir.
            Car car3 = new Car();
            MessageBox.Show(car3.Brand);
        }
    }
}
