using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritanceUygulama5
{
    public class Baba:Dede
    {
        public Baba() : this("Sinan", 555)
        {

            MessageBox.Show("Parametresiz Baba ");
        }
        public Baba(string ad, int yas) :base("ali",4545455)//dede klasının sadece parametreli metodunu çalıştırır
        {
            MessageBox.Show("Parametreli Baba ");
        }
       
       
    }
}
