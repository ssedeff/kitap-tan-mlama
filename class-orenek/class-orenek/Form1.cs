using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_orenek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitap kitap1 = new kitap();
            kitap1.türü = "roman";
            kitap1.yazarı = "meryem mart";
            kitap1.adı = "yok musun";
            kitap1.sayfaSayısı = 502;
            kitap1.yayınevi = "Ephesus";
            kitap1.tipi = "ciltli";

            label1.Text = kitap1.adı + " " + kitap1.sayfaSayısı + " " + kitap1.türü + " " + kitap1.yazarı + " " +
                kitap1.yayınevi + " " + kitap1.tipi;
        }
    }
}
