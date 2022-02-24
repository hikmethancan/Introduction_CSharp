using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Abstract_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gitarBtn_Click(object sender, EventArgs e)
        {
            Gitar gitar1 = new Gitar();
            gitar1.Brand = "Yamaha";
            gitar1.Description = "Çok Kaliteli marka";

            string sound = gitar1.Call();

            Muzisyen muzisyen = new Muzisyen();
            muzisyen.FirstName = "Hikmet";
            muzisyen.LastName = "Can";
            muzisyen.Enstruman = gitar1;

            MessageBox.Show(string.Format(@"
                    Gitaristin Adı: {0} 
                    Gitaristin Soyadı: {1}
                    Gitaristin Enstrümanının Sesi: {2}
                    Gitaristin Enstrüman Markası : {3}
                    Gitaristin Enstrümanının Acıklaması : {4}", muzisyen.FirstName, muzisyen.LastName, sound, muzisyen.Enstruman.Brand,muzisyen.Enstruman.Description));

        }

        private void bateriBtn_Click(object sender, EventArgs e)
        {
            Bateri bateri = new Bateri();

            bateri.Brand = "Valencia";
            bateri.Description = "Çok kaliteli ses çıkaran bir bateri markası";
            
            string sound = bateri.Call();

            Muzisyen muzisyen = new Muzisyen();

            muzisyen.FirstName = "Dilara";
            muzisyen.LastName = "Karagülle";
            muzisyen.Enstruman = bateri;

            MessageBox.Show(string.Format(@"
                    Bateristin Adı: {0} 
                    Bateristin Soyadı: {1}
                    Bateristin Enstrümanının Sesi: {2}
                    Bateristin Enstrüman Markası : {3}
                    Bateristin Enstrümanının Acıklaması : {4}", muzisyen.FirstName, muzisyen.LastName, sound, muzisyen.Enstruman.Brand, muzisyen.Enstruman.Description));

        }

        private void flutBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
