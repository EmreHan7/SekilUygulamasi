using System;
using System.Collections.Generic;
using System.Text;

namespace ŞekilUygulaması
{
    public class Sekil
    {
        public string isim { get; set; }
        public Sekil(string isim)
        {
        }
        public string getIsim()
        {
            return isim;
        }

        public virtual void sekilHesapla()
        {
            Console.WriteLine("Şeklin alanı hesaplanıyor..");
        }

        public virtual void sekilBilgileriniGoster ()
        {
            Console.WriteLine(getIsim() + "bilgileri.." );
        }

    }
}
