using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritance_miras_
{
    public class DemoView:Demo //Demodan miras alıyor
    {
        public int yas = 7007;   //local globali ezer. globalde yaş tanımlı olsa dahi en son bu clastaki local veri geçerli olur eğer burda tanımlı başka yaş değeri yoksa
        public DemoView() : this(true)  
        {
            //this.yas = 907;
            MessageBox.Show("Parametresiz DemoView");
        }
        public DemoView(bool flag)    
        {
            this.yas = 3003;
            MessageBox.Show("Parametreli DemoView");
           // yas = 4003;
        }
    }
}
