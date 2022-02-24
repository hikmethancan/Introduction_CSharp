using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Struct yapılarda boş yapıcı metot oluşturulamadığından dolayı, new anahtar kelimesi kullanmak zorunluluğu yoktur.
        Kitap k;


        private void Form1_Load(object sender, EventArgs e)
        {
            k.Ad = "Müptezeller";
            k.Turu = "Roman";
            k.YazarAdi = "Emrah Serbes";
            k.ISBNNO = "9789750520976";

            Kitap kitap = new Kitap();

            kitap.Ad = "Mavi";
            kitap.Turu = "Şiir";
            kitap.YazarAdi = "Hikmet";
            kitap.ISBNNO = "234234";


            Kitap kitap2 = new Kitap(1, "Savas Atı", "Cocuk", "234234", "Micheal");
        }
        private void structBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(k.ISBNNO + "-" + k.YazarAdi + " " + k.Ad + " " + k.Turu);
        }

        private void sealedBtn_Click(object sender, EventArgs e)
        {
            SealedClass s = new SealedClass();
            s.sayi1 = 10;
            s.sayi2 = 20;

            int sonuc = s.sayi1 + s.sayi2;
            s.sonucMetin = "Sayının Sonucu : " + sonuc;
            MessageBox.Show(s.sonucMetin);

            BaseClass bc = new BaseClass();
            //MessageBox.Show(bc.GetUser());  => BaseClasstaki GetUser metodları Protected oldugu için çagıralamıyor.
            //MessageBox.Show(bc.GetUser2()); => BaseClasstaki GetUser metodları Protected oldugu için çagıralamıyor.

            SealedClassMiras sc = new SealedClassMiras();

            //MessageBox.Show(sc.GetUser()); => SealedClassMirasstaki GetUser metodları Protected oldugu için çagıralamıyor.
            //MessageBox.Show(sc.GetUser2()); => SealedClassMirasstaki GetUser metodları Protected oldugu için çagıralamıyor.

            SealedClassMirasMirasi scm = new SealedClassMirasMirasi();

            //MessageBox.Show(scm.GetUser()); => SealedClassMirassMirasstaki GetUser metodları Protected oldugu için çagıralamıyor.
            //MessageBox.Show(scm.GetUser2()); => SealedClassMirassMirasstaki GetUser metodları Protected oldugu için çagıralamıyor.
        }


    }
}
