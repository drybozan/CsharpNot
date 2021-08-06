using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Çok_biçimlilik_
{
    public class Dede
    {
        public int yas = 977;
        public Dede():this(555)
        {
            this.yas = 1003;
            Console.WriteLine("Parametresiz Dede");
        }
        public Dede(int yas)
        {
            this.yas = 2003;
            Console.WriteLine("Parametreli Dede");
        }
    }

    public class Baba:Dede
    {
       // public int yas = 877;  
        public Baba() : this(888)
        {
           this.yas = 3003;
            Console.WriteLine("Parametreli Baba");
        }
        public Baba(int yas)
        {
            this.yas = 4003;
            Console.WriteLine("Parametresiz Baba");
        }

    }
    public class Cocuk : Baba
    {
       // public int yas = 777; // burda yaş tanımlamayınca gider babanınkini alır babanınki de tanımlı değilse gider dedeninkini alır
        public Cocuk() : this(888)
        {
            this.yas = 5003;
            Console.WriteLine("Parametreli Cocuk");
        }
        public Cocuk(int yas)
        {
           // this.yas = 6003;
            Console.WriteLine("Parametresiz Cocuk");
        }

    }
    public class Amca : Dede
    {
        public Amca() : this(888)
        {
            Console.WriteLine("Parametreli Amca");
        }
        public Amca(int yas)
        {
            Console.WriteLine("Parametresiz Amca");
        }

    }
    public class Kuzen : Amca
    {
        public Kuzen() : this(888)
        {
            Console.WriteLine("Parametreli Kuzen");
        }
        public Kuzen(int yas)
        {
            Console.WriteLine("Parametresiz Kuzen");
        }

    }



}
