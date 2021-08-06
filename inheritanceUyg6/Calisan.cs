using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritanceUyg6
{
   public class Calisan
    {
        public int yas = 67;
        public Calisan() : this(47)
        {
            yas = 57;
            MessageBox.Show("3");
            yas = 89;
        }
        public Calisan(int yas)
        {
           yas = 107;
           MessageBox.Show("4");
        }
    }
}
