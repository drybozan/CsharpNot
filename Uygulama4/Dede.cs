using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iUygulama4
{
    public class Dede
    {
        public Dede() : this("Sinan", 555)
        {

            MessageBox.Show("Parametresiz Dede ");
        }
        public Dede(string ad,int yas) :base()//aynı şekil burası çalışır
        {

            MessageBox.Show(" Parametreli Dede ");
        }
       

    }
}
