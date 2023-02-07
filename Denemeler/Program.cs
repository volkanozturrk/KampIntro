
using Denemeler;

Urun urun1 = new Urun();
urun1.adi = "Kazak";
urun1.aciklama = "Kırmızı";
urun1.adet = 20;

SepetManager sepetManager = new SepetManager();
sepetManager.sepeteEkle(urun1);