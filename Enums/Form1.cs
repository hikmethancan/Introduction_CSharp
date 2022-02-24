using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Enum.GetNames(typeof(Departmans)));
        }

        List<Personnel> personnelList = new List<Personnel>();
        private void button1_Click(object sender, EventArgs e)
        {
            Personnel personnel = new Personnel();
            personnel.NameSurname = personelTxt.Text;
            personnel.Departman = (Departmans)Enum.Parse(typeof(Departmans), comboBox1.Text);
            personnelList.Add(personnel);

            foreach (var personnels in personnelList)
            {
                MessageBox.Show("Adı: " + personnels.NameSurname + " Departman: " + personnels.Departman);
                listBox1.Items.Add("Adı: " + personnels.NameSurname + " Departman: " + personnels.Departman);
            }

        }

        
    }
}
