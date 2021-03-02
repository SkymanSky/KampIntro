using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //typesafety: veri türü bastan verilmeli
            //Do not Repeat Yourself: Kendini Tekrarlama
            //kategoriEtiketi=>Değer tutucu, alias
            //Program isimleri Pascal Case yazılır.
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;

            //Gerçek hayatta burası veri kaynağından gelir
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else
            {
                Console.WriteLine("Artış Butonu");
            }

            if (sistemeGirisYapmisMi)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
