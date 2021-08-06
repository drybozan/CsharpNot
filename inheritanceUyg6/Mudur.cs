using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritanceUyg6
{
   public class Mudur:Calisan
    {
        public Mudur():this(47)
        {
            yas = 807;
            MessageBox.Show("1");
        }
        public Mudur(int yas) : base(97)
        {
            yas = 707;
            MessageBox.Show("2");
        }
    }
}
