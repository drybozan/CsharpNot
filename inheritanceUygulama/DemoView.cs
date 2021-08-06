using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritanceUygulama
{
    public class DemoView:Demo
    {
        Penguen penguen = new Penguen();

        public DemoView() : this(true)
        {
            
            
            MessageBox.Show("Parametresiz DemoView");
        }
        public DemoView(bool flag)
        {
            MessageBox.Show("Parametreli DemoView");
            
        }
    }
}
