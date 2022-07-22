using System;
using System.Collections.Generic;
using System.Text;

namespace ŞekilUygulaması
{
    public class Dikdörtgen : Sekil
    {
        public int kısakenar { get; set; }
        public int uzunkenar { get; set; }
        public Dikdörtgen(string isim, int kısakenar, int uzunkenar):base(isim)
        {
            this.kısakenar = kısakenar;
            this.uzunkenar = uzunkenar;
        }

        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim() + " " + "in alanı : " + (kısakenar*uzunkenar));
        }

        public override void sekilBilgileriniGoster()
        {
            base.sekilBilgileriniGoster();
            Console.WriteLine(getIsim() + " " + "in uzun kenarı : " +uzunkenar);
            Console.WriteLine(getIsim() + " " + "in kısa kenarı : " +kısakenar);
        }

    }
}
