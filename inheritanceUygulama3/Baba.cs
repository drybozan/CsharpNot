using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritanceUygulama3
{
    public class Baba:Dede
    {
        public string tarla;
        public int ev;

        
        Penguen penguen = new Penguen(false);
        public Baba() : this(93)
        {
            MessageBox.Show("Parametresiz Baba ");
        }
        public Baba(int yas) : this(true)
        {
            MessageBox.Show("İnt Parametreli Baba ");
        }
        public Baba(bool flag):base(false)//üst classın bool metodunu çalıştır
        {
            MessageBox.Show("Bool Parametreli Baba ");
        }
        
    }
}
