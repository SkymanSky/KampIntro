using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici kampı";
            string kurs2 = "Programlaya Başlangıc";
            string kurs3 = "Java";


            //array kurslar
            string[] kurslar = new string[] { kurs1, kurs2, kurs3 };

            //Birbirine benzeyen işleri tekrar etmek için döngüler kullanılır.

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            //Dizileri daha kolay dolaşmak için kullanılan döngüdür.
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
