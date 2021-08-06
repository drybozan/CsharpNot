using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritance_miras_
{
    public class Demo
    {
        public string ad;
        public int yas=587;

        public Demo():this(true)  
        {
            this.yas = 507;
            MessageBox.Show("Parametresiz Demo");
            yas = 607;
        }
        public Demo(bool flag)   
        {
            yas = 1001;
            MessageBox.Show("Parametreli Demo");
        }
    }
}
