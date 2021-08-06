using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritanceUygulama4
{
    public class Baba:Dede //public sealed class Dede dediğimizde dede Classına erişemez
    {
        public Baba() : this("Sinan", 555)
        {

            MessageBox.Show("Parametresiz Baba ");
        }
        public Baba(string ad, int yas) : base("Toklu", 222)//dede clasına gider parametreli metodu çalıştırır
        {
            MessageBox.Show("Parametreli Baba ");
        }
        public sealed override void maas()//'Baba.maas()', 'Dede.maas()' devralınan üyesini gizler.Gizleme isteniyorsa yeni anahtar sözcük kullanın uyarsı verilir. program babanın maasını çalıştırır
                                          // Bir kere override etmek için başına sealed override yazılır
        {
            //base.maas();//dedenin maas fonksiyonuna gidecek önce
            MessageBox.Show("Babadayım");
            base.maas();//babanın maas fonksiyonu çalıştırdıktan sonra dedenin maas fonksiyonuna gider
        }
    }
}
