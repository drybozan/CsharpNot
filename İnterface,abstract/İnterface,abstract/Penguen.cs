using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface_abstract
{
    public interface Penguen
    {
        //public int yas= 1001;  interface de değişken tanımlayamıyoruz.
        //interface de abstract metotlar bulunabilir 
        //kurucu metotlar oluşturamayız
        void bozan(); // abstract classın önüne abstract yazamayız metot zaten abstract,public de yazdırmaz.
        void toklu();
    }
}
