
                                    //VERİ YAPILARI
string kategoriEtiketi = "Kategoriler";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = true;
double dolarDun = 18.80;
double dolarBugun = 18.90;

Console.WriteLine(kategoriEtiketi);
Console.WriteLine("*************************");


                                     //IF-ELSE
if (dolarDun > dolarBugun)
{
    Console.WriteLine("Azalış Butonu");
}
else if (dolarDun < dolarBugun)
{
    Console.WriteLine("Artış Butonu");
}
else
{
    Console.WriteLine("Sabit Butonu");
}
Console.WriteLine("*************************");

        
                                    //DONGULER
if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanıcı Ayarları Butonu");
}
else
{
    Console.WriteLine("Giriş Yap Butonu");
}
Console.WriteLine("*************************");