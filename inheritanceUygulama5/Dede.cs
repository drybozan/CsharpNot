using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritanceUygulama5
{
    public class Dede
    {
       // public readonly int yas = 907;  //değişkene readonly yazınca sadece bir kere değer veriyoruz.
        //Bu satırda veya constructer(kurucu) method olan yerlerde verebiliriz bi daha değişmez tek atımlık kurşun muhabetti

        public static int yas = 925478;
        public Dede(): this("Sinan", 555)
        {
           yas = 9800; //hata vermez;//en son burayı terk ediyor burdaki yaş değerini alır gider

            MessageBox.Show("Parametresiz Dede ");
        }
        public Dede(string ad, int yas) 
        {
            yas = 3265; //Burdada değer verebilirz
            MessageBox.Show(" Parametreli Dede ");
        }
        public static void maas1()
        {
            int sonuc = 0;
            sonuc += yas;
            MessageBox.Show(sonuc.ToString());

        }

    }
}
