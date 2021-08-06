using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Çok_biçimlilik_
{
    class Program
    {
         static void Main(string[] args)
        {
            Cocuk cocuk = new Cocuk();
            Dede dede = new Cocuk();//burda cocukta kumanda var dede de kumanda var ama dedenin kumadası çıkar.
                                    //Cocukta kumanda yoksa dede var ise yine dedenin kumadası çıkar
                                    //cocukta kumanda var ama dede yok ise kumanda yazamazsınız yaş pronlemleri için not!
            Baba baba = new Cocuk();
           // Dede dede2 = new Kuzen();
           // Amca amca = new Kuzen();
           // Amca amca2 = new Amca();

           /* Console.WriteLine(cocuk.yas);   //s
            Console.WriteLine(baba.yas);
            Console.WriteLine(dede.yas);*/

           // liste(cocuk);
            //liste(dede);
            //liste(baba);
            //liste(dede2);
            //liste(amca);
           // liste(amca2);
           Console.ReadLine();
        }
         static public void liste(Dede dede)
        {
            if(dede is Dede)
            {
                Console.WriteLine("Dede soyundan");
               
            }
            if (dede is Baba) //else if olduğunda bu bloğa uğramicak.Dedenin elsesi olmuş oluyor.İlk şart sağlanır ikinciye girmez
            {
                Console.WriteLine("Baba soyundan");
            }
            if (dede is Cocuk)
            {
                Console.WriteLine("Cocuk soyundan");
            }
            if (dede is Amca)
            {
                Console.WriteLine("Amca soyundan");
            }
            if (dede is Kuzen)
            {
                Console.WriteLine("Kuzen soyundan");
            }
        }
    }
}
