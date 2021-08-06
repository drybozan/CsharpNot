using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Dede dede = new Baba(); //polimorpizizmde abstact classtan nesne üretebiliyoruz
            Baba baba = new Baba();

           // Dede dede2 = new Dede(); hata verir. Abstract classlardan nesne üretemiyoruz.

            Console.ReadLine();
        }
    }
}
