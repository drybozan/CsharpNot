using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Dede dede = new Cocuk();
            Baba baba = new Cocuk();
            Cocuk cocuk = new Cocuk();

            Console.WriteLine(dede.yas);
            Console.WriteLine(baba.yas);
            Console.WriteLine(cocuk.yas);

            dede.hesapla();
            baba.hesapla();
            cocuk.hesapla();

           // Penguen penguen = new Penguen();  abstract classın veya interface in nesnesini oluşturamazsın




            Console.ReadLine();
        }
    }
}
