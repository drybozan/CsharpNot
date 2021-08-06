using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritanceUygulama
{
     public class Demo
    {
        Penguen penguen = new Penguen();
        public string ad;
        public int yas;

        public Demo() : this(true)
        {
            MessageBox.Show("Parametresiz Demo");
  
        }
        public Demo(bool flag)
        {
            MessageBox.Show("Parametreli Demo");
        }
    }
}
