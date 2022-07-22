using System;
using System.Collections.Generic;
using System.Text;

namespace ŞekilUygulaması
{
    public class Kare:Sekil
    {
        public int kenar { get; set; }
        public Kare(string isim, int kenar):base(isim)
        {
            this.kenar = kenar;
        }

        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim() + " " + "nin alanı : " + (kenar*kenar));
        }
        public override void sekilBilgileriniGoster()
        {
            base.sekilBilgileriniGoster();
            Console.WriteLine(getIsim() + " " + "nin bir kenar uzunluğu : " + kenar);
        }
    }
}
