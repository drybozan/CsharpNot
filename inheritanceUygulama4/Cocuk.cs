using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritanceUygulama4
{
    public class Cocuk : Baba
    {
       /* public override void maas()//Hata   'Cocuk.maas()': korumalı olduğundan 'Baba.maas()' devralınmış üyesi geçersiz kılınamaz  inheritanceUygulama4 C:\Users\derya\Documents\C# forms\inheritance(miras)\inheritanceUygulama4\Cocuk.cs	12	Etkin

        {
            MessageBox.Show("Cocuktayım");
        }
       şeklinde yazamayız .nette sadece bir kere override yapılır ve biz bunu baba classında yapmıştık*/ 

       /* public void maas() //	'Cocuk.maas()' devralınmış 'Baba.maas()' üyesini gizliyor.Geçerli üyenin bu uygulamayı geçersiz kılması için 
                            //override anahtar sözcüğünü ekleyin.Aksi takdirde new anahtar sözcüğünü ekleyin.

        {
            MessageBox.Show("Cocuktayım");
        }*/
       public void maas1()
        {
           // base.maas();//babanın maasına gidecek önce
            MessageBox.Show("Cocuktayım");
            base.maas();//cocuk maas1 fonksiyonu çalıştırdıktan sonra babanın maas fonksiyonuna gider
        }
    }
}
