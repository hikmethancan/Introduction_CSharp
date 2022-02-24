using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReferenceAndValueTypes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            // Ogrenci clasını referans alan bir ogr objesi olusturduk.
            StudentRef student = new StudentRef();
            student.Name = " Hikmet";
            student.Surname = "CAN ";

            MessageBox.Show("Ogrenci : " + student.Name + " " + student.Surname);
            MessageBox.Show(student.GetHashCode().ToString());


            // **********

            StudentRef student2 = new StudentRef();
            student2.Name = "Hikmet2";
            student2.Surname = "CAN2";
            MessageBox.Show("Ogrenci2 : " + student2.Name + " " + student2.Surname);
            MessageBox.Show(student.GetHashCode().ToString());

            // student2 objesi olusturuldu ve referans olarak ogr atandı.
            
            student2 = student; // => student'teki degerleri student2'ye atadık.
            MessageBox.Show("Ogrenci2 : " + student2.Name + " " + student2.Surname); 

            // student3 ve student objeleri stack'te 2 değişken olarak oluştu fakat heapte ikisi de aynı sonuç değerine ulaşıyor.
            StudentRef student3 = student; // => student3 objecsı olusturuldu ve ref olarak student alındı.
            //Bu yüzden ikisi de aynı degere ulasır ve aynı sonucları döndürür.
            //student3'te yapılan degisiklikler student'i de etkiler cünkü referans alıyor.

            student3.Name = "Dilara";
            student3.Surname = "Karagulle";

            MessageBox.Show("ÖĞRENCİ ogr: " + student.Name + " " + student.Surname);
            MessageBox.Show("ÖĞRENCİ ogr2: " + student2.Name + " " + student2.Surname);
            MessageBox.Show("ÖĞRENCİ ogr3: " + student3.Name + " " + student3.Surname);

        }

        private void valueBtn_Click(object sender, EventArgs e)
        {
            //Struct yapılar Value type oldugu icin yani bir deger tuttugu icin direkt olarak stackte tanımlanırlar.
            //new ınstance() yapsak bile zaten bir deger tuttugu icin heapte 2 farklı deger olarak tutar.

            Studentvalues stu = new Studentvalues();
            stu.Name = "Hikmet";
            stu.Surname = "Can";

            Studentvalues stu2 = stu;
            stu2.Name = "Dilara";
            stu2.Surname = "Karagulle";
            MessageBox.Show(stu.Name);

            // stu değerlerini stu2'ye kopyaladık gibi düşünebiliriz. Yani heapte 2 farklı  yer tutar stu'nun değeri ve stu2'nin değeri diye.

        }
    }
}
