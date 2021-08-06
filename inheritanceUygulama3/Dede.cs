using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritanceUygulama3
{
    public class Dede
    {
        public string kat;
        public int yat;

        
        Penguen penguen = new Penguen(true);
        public Dede():this(93)
        {
          
            MessageBox.Show("Parametresiz Dede ");
        }
        public Dede(int yas):this(true)
        {
           
            MessageBox.Show("İnt Parametreli Dede ");
        }
        public Dede(bool flag)
        {
            MessageBox.Show("Bool Parametreli Dede ");
        }
       
    }
}
