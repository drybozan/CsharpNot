using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritanceUygulama3
{
    public class Penguen
    {
        public Penguen() : this(93)
        {
            MessageBox.Show("Parametresiz Penguen ");
        }
    public Penguen(int yas) : this(true)
        {
        MessageBox.Show("int Parametreli Penguen ");
    }
    public Penguen(bool flag)
        {
            MessageBox.Show("Bool Parametreli Penguen ");
        }
    }
}
