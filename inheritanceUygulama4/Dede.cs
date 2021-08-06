using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritanceUygulama4
{
    public class Dede
    {
        public readonly int yas=907;  //değişkene readonly yazınca sadece bir kere değer veriyoruz.
                                      //Bu satırda veya constructer(kurucu) method olan yerlerde verebiliriz bi daha değişmez tek atımlık kurşun muhabetti
        public Dede() //: this("Sinan", 555)
        {
            yas = 9800; //hata vermez;

            MessageBox.Show("Parametresiz Dede ");
        }
        public Dede(string ad, int yas) : base()//aynı şekil burası çalışır
        {
            yas = 3265; //Burdada değer verebilirz
            MessageBox.Show(" Parametreli Dede ");
        }
        public virtual void maas()
        {
            MessageBox.Show("Dedeyim");
        }
    }
}
