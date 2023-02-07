using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convension
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + urun.Adi + "Kalan : " + (urun.stokAdedi - 1));
        }
    }
}
