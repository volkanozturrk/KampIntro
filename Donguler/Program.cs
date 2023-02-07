                                           //DONGULER
for (int i = 1; i <= 10; i += 2)
{
    Console.WriteLine(i);
}

Console.WriteLine("*************");
                                            //DİZİLER
string Kurs1 = "Yazılım Geliştirme Kampı";
string Kurs2 = "Programlamaya Başlangıç Temel Kurs";
string Kurs3 = "Java Kursu";
string Kurs4 = "C++";

Console.WriteLine(Kurs1);
Console.WriteLine(Kurs2);
Console.WriteLine(Kurs3);
Console.WriteLine(Kurs4);   

Console.WriteLine("************************");

//tek tek tanımlamak yerine bir array'de tutulur, başka bir kurs ekleneceği zaman sadece array'e eklenir. Gidip bir daha kod yazmak zorunda kalınmaz.

string[] kurslar = new string[]{"Yazılım Geliştirme Kampı",
    "Programlamaya Başlangıç Temel Kurs","Java Kursu","Python","C++"};

for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("***************");

foreach (string kurs in kurslar) // kurs bir alias yani takma isim. foreach diziler için daha rahat.
{
    Console.WriteLine(kurs);
}

Console.WriteLine("Sayfa Sonu");