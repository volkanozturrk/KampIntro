// Clean Code - Best Practice
//Metot (Trendyoldaki Sepete Ekle)

using Metotlar;

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";
urun1.stokAdedi = 18;

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır Karpuzu";

Urun[] urunler = new Urun[] { urun1, urun2 };

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("-----------");
}

Console.WriteLine("------------METOTLAR-----------------");

//encapsulation : urun class'ına yeni bir property olan stok adedi eklendi ama kod patlamadı.
SepetManager sepetManager = new SepetManager();  //instance - örnek
sepetManager.Ekle(urun1);