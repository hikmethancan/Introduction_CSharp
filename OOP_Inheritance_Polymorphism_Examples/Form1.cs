using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Inheritance_Polymorphism_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nokiaBtn_Click(object sender, EventArgs e)
        {
            Nokia nokia = new Nokia();

            nokia.Id = 1;
            nokia.Model = "3310";
            //nokia.CallSound();

            MessageBox.Show("Telefonun IDsi: " + nokia.Id + " Markası: " + nokia.Brand + " Modeli: " + nokia.Model);
        }

        private void samsungBtn_Click(object sender, EventArgs e)
        {
            Samsung samsung = new Samsung();

            samsung.Id = 1;
            samsung.Model = "3310";
            //samsung.CallSound();

            MessageBox.Show("Telefonun IDsi: " + samsung.Id + " Markası: " + samsung.Brand + " Modeli: " + samsung.Model);
        }

        private void iphoneBtn_Click(object sender, EventArgs e)
        {
            Iphone iphone = new Iphone();

            iphone.Id = 1;
            iphone.Model = "3310";
            //iphone.CallSound();

            MessageBox.Show("Telefonun IDsi: " + iphone.Id + " Markası: " + iphone.Brand + " Modeli: " + iphone.Model);
        }
    }
}
