using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //Manager uzantılı classlar operasyon tutarlar
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi:"+urun.Adi);
        }

    }
}
