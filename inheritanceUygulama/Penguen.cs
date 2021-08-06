using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritanceUygulama
{
    public class Penguen
    {
        public Penguen() : this(true)
        {
            
            MessageBox.Show("Parametresiz Penguen");
        }
        public Penguen(bool flag)
        {
           
            MessageBox.Show("Parametreli Penguen");
            
        }
    }
}
