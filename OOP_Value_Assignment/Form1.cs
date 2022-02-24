using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Value_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            First a = new First();
            First b = new First();

            a.j = 11;
            // Classtaki bir static ifadeyi Classİsmi.StaticDegiskenİsmi yazarak çağırabiliyoruz.
            First.i = 30;
            MessageBox.Show(First.i.ToString());
            MessageBox.Show(a.j.ToString());

            Second s = new Second(); // => Second Classındaki Default Constructor çalışır.Hello Guys yazar
            Second s2 = new Second("merabalar"); //=> Second Classındaki parametre alan Constructor çalışı ve merabalar yazar.
            Thirdcs t = new Thirdcs(); // => Default Constructoru boş olduğu için ve public bir propertysi olmadığı için herhangi bir işe yaramaz.
        }
    }
}
