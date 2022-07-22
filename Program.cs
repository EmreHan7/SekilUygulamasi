using System;

namespace ŞekilUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şekil Uygulamasına Hoşgeldiniz..");

            while (true)
            {
                Console.WriteLine("Lütfen Bir İşlem Seçiniz..");
                Console.WriteLine("1- Dikdörtgen İşlemleri ");
                Console.WriteLine("2- Üçgen İşlemleri ");
                Console.WriteLine("3- Kare İşlemleri ");
                Console.WriteLine("4- Çıkış Yap");
                string secim = Console.ReadLine();

                if (secim=="4")
                {
                    Console.WriteLine("Çıkış Yapılıyor");
                    break;
                }
                else if (secim=="1")
                {
                    Console.WriteLine("Lütfen Dikdörtgenin sırasıyla kısa kenarını ve uzun kenarını giriniz..");
                    int secim4 = Convert.ToInt32(Console.ReadLine());
                    int secim3 = Convert.ToInt32(Console.ReadLine());
                    Dikdörtgen dikdörtgen = new Dikdörtgen("Dikdörtgen", secim3, secim4);


                    while (true)
                    {


                        

                        Console.WriteLine("Lütfen Dikdörtgen İşlemlerinde Yapmak İstediğiniz İşlemi Seçiniz..");
                        Console.WriteLine("1- Dikdörtgen Alanını Hesapla ");
                        Console.WriteLine("2- Dikdörtgen Bilgilerini Göster");
                        Console.WriteLine("3- Bir Üst Menüye Çıkış Yap..");
                        string secim1 = Console.ReadLine();
                        if (secim1 == "3")
                        {
                            Console.WriteLine("Bir Üst Menüye Çıkış Yapılıyor..");
                            break;
                        }
                        else if (secim1 == "1")
                        {
                            dikdörtgen.sekilHesapla();
                        }
                        else if (secim1 == "2")
                        {
                            dikdörtgen.sekilBilgileriniGoster();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen Geçerli Bir İşlem Giriniz..");
                        }
                    }
                }
                else if (secim=="2")
                {
                    Console.WriteLine("Lütfen Üçgenin sırasıyla Taban Alanını ve Yüksekliğini giriniz..");
                    int secim5 = Convert.ToInt32(Console.ReadLine());
                    int secim6 = Convert.ToInt32(Console.ReadLine());
                    Ucgen ucgen = new Ucgen("Üçgen", secim5, secim6);

                    Console.WriteLine("Lütfen Üçgen İşlemlerinde Yapmak İstediğiniz İşlemi Seçiniz..");
                    Console.WriteLine("1- Üçgen Alanını Hesapla ");
                    Console.WriteLine("2- Üçgen Bilgilerini Göster");
                    Console.WriteLine("3- Bir Üst Menüye Çıkış Yap..");
                    string secim7 = Console.ReadLine();

                    if (secim7=="3")
                    {
                        Console.WriteLine("Bir Üst Menüye Çıkış Yapılıyor..");
                        break;
                    }
                    else if (secim7=="1")
                    {
                        ucgen.sekilHesapla();
                    }
                    else if (secim7=="2")
                    {
                        ucgen.sekilBilgileriniGoster();
                    }
                    else
                    {
                        Console.WriteLine("Lütfen Geçerli Bir İşlem Giriniz..");
                    }


                }
                else if (secim=="3")
                {
                    Console.WriteLine("Lütfen Karenin Bir Kenar Uzunluğunu Giriniz..");
                    int secim8 = Convert.ToInt32(Console.ReadLine());
                    Kare kare = new Kare("Kare", secim8);

                    Console.WriteLine("Lütfen Kare İşlemlerinde Yapmak İstediğiniz İşlemi Seçiniz..");
                    Console.WriteLine("1- Karenin Alanını Hesapla ");
                    Console.WriteLine("2- Kare Bilgilerini Göster");
                    Console.WriteLine("3- Bir Üst Menüye Çıkış Yap..");
                    string secim9 = Console.ReadLine();

                    if (secim9=="3")
                    {
                        Console.WriteLine("Bir Üst Menüye Çıkış Yapılıyor..");
                        break;
                    }
                    else if (secim9=="1")
                    {
                        kare.sekilHesapla();
                    }
                    else if (secim9=="2")
                    {
                        kare.sekilBilgileriniGoster();
                    }
                    else
                    {
                        Console.WriteLine("Lütfen Geçerli Bir İşlem Giriniz..");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen Geçerli Bir İşlem Giriniz..");
                }
            }
            
        }
    }
}
