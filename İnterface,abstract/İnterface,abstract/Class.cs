using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface_abstract
{
    public class Dede
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
    }

    public class Baba : Dede,Penguen //birden fazla interface olduğunda , diyip yanına yazabiliriz.
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

      
        public virtual void  hesapla() //miras aldığı classın hesapla fonksiyonunu çiğner
        {
            Console.WriteLine("Baba hesapla");
        }
        public void bozan()
        {
            throw new NotImplementedException();
            
        }

        public void toklu()
        {
            throw new NotImplementedException();
        }

    }
    public class Cocuk : Baba
    {
        public int yas = 777;
        public Cocuk() : this(888)
        {
            
            Console.WriteLine("Parametreli Cocuk");
        }
        public Cocuk(int yas)
        {
         
            Console.WriteLine("Parametresiz Cocuk");
        }
        public override void hesapla() //miras aldığı classın hesapla fonksiyonunu çiğner
        {
            Console.WriteLine("Cocuk hesapla");
        }

    }
    //NOT: override işlemi yapmak istediğimde çiğnenecek classın fonksiyonunun önünde virtual olması gerek.Çiğneyecek olanın önünde ise ovveride olması lazım.
}
