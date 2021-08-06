using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Dede //içinde abstract metot bulunmadan da çalışır,
                              //ama public abstarct class Dede yazmayıp da altta abstract metot varsa çalışmaz.
    {
        public int yas = 977;
        public Dede() : this(555)
        {

            Console.WriteLine("Parametresiz Dede");
        }
        public Dede(int yas)
        {

            Console.WriteLine("Parametreli Dede");
        }
        public virtual void hesapla()
        {
            Console.WriteLine("Dede hesapla");
        }
        public abstract void bozan(); //abstract classı miras alan classta imlement etmek gerekiyor
    }

    public class Baba : Dede
    {
        public int yas = 877;
        public Baba() : this(888)
        {

            Console.WriteLine("Parametreli Baba");
        }
        public Baba(int yas)
        {

            Console.WriteLine("Parametresiz Baba");
        }

        public override void bozan()  //metodu burda imlement etmek gerekiyor
        {
            throw new NotImplementedException();
        }

        public void hesapla()
        {
            Console.WriteLine("Baba hesapla");
        }
    }
}
