using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritanceUygulama3
{
    public partial class form3 : Form
    {
        public form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cocuk cocuk = new Cocuk(93);//parametresiz cocuk metodu çalımayacak
            //Baba baba = new Baba(); //cocuk classına uğramaz
            Cocuk cocuk = new Cocuk();
            
        }

        private void form3_Load(object sender, EventArgs e)
        {

        }
    }
}
