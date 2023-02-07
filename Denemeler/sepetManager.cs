using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler
{
    class SepetManager
    {
        public void sepeteEkle(Urun urun)
        {
            Console.WriteLine("Sepete Eklenen : " + urun.adi + " " + "Kalan Stok Adedi : " + (urun.adet-1));
        }
    }
}
