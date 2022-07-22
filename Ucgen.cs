using System;
using System.Collections.Generic;
using System.Text;

namespace ŞekilUygulaması
{
    public class Ucgen:Sekil
    {
        public int tabanAlani { get; set; }
        public int yukseklik { get; set; }

        public Ucgen(string isim, int tabanAlani, int yukseklik ) : base(isim)
        {
            this.tabanAlani = tabanAlani;
            this.yukseklik = yukseklik;
        }


        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim() + " " + "in alanı : " + (tabanAlani*yukseklik)/2);
        }
        public override void sekilBilgileriniGoster()
        {
            base.sekilBilgileriniGoster();
            Console.WriteLine(getIsim() + " " + "in taban alanı : " + tabanAlani);
            Console.WriteLine(getIsim() + " " + "in yüksekliği  : " +yukseklik);
        }
    }           
}
