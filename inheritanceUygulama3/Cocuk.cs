using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritanceUygulama3
{
    public class Cocuk:Baba
    {
        Penguen penguen = new Penguen(99);
        public Cocuk() : this(93)
        {
            MessageBox.Show("Parametresiz Cocuk ");
        }
        public Cocuk(int yas) : this(true)
        {
            
            MessageBox.Show("İnt Parametreli Cocuk ");
        }
        public Cocuk(bool flag):base(true)//bir üst classa git bool değerindeki metodu çalıştır
        {
            MessageBox.Show("Bool Parametreli Cocuk ");
        }
       
    }
}
