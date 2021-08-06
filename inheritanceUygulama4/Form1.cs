using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritanceUygulama4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Baba baba = new Baba();
             Dede dede = new Dede();
           MessageBox.Show(dede.yas.ToString());
             baba.maas();
             dede.maas();*/
            /* Cocuk cocuk = new Cocuk();
              cocuk.maas(); //babanın maas fonksiyonu çalışacak
              cocuk.maas1();*/
            Cocuk cocuk = new Cocuk();
            cocuk.maas1();
            MessageBox.Show(cocuk.yas.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
