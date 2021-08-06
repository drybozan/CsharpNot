using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama4
{
    public class Baba : Dede
    {
        public Baba() : this("Sinan", 555)
        {

            MessageBox.Show("Parametresiz Baba ");
        }
        public Baba(string ad, int yas)// : base("Toklu", 222)//dede clasına gider parametreli metodu çalıştırır
        {
            MessageBox.Show("Parametreli Baba ");
        }
    }
}
