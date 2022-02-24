using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FirstClass human1 = new FirstClass();

        private void nameBtn_Click(object sender, EventArgs e)
        {
            human1.Name = "Hikmethan";
            human1.LastName = "Can";
            human1.Age = 24;
            //human1.Age = 9; => yaşı 9 girersek FirstClass'ımızdaki age koşulunu saglamadıgı için uyarı verir.

            MessageBox.Show("Welcome " + human1.Name + " " + human1.LastName);
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            human1.Name = "Hikmet";
            human1.LastName = "Can";
            human1.Age = 24;
            human1.Height = 176;
            human1.Weight = 67;
            human1.Id = 1;
            MessageBox.Show(human1.Name + " " + human1.LastName + " adlı kişinin özellikleri:\n" + "ID: " + human1.Id + "\nKilo: " + human1.Weight + "\nBoy: " + human1.Height + "\nYaş: " + human1.Age);
            
        }

        private void getBtn_Click(object sender, EventArgs e)
        {
            int yas = Convert.ToInt32(textBox1.Text);
            if (yas == human1.Age)
            {
                MessageBox.Show(human1.Name);
            }
            else
            {
                MessageBox.Show("There is no one registered in the database :(");
            }
        }
    }
}
