
Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.egitmeni = "Engin Demiroğ";
kurs1.IzlenmeOrani= 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.egitmeni = "Kerem Varış";
kurs2.IzlenmeOrani = 64;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python";
kurs3.egitmeni = "Berkay Bilgin";
kurs3.IzlenmeOrani = 80;

Kurs kurs4 = new Kurs();
kurs4.KursAdi = "C++";
kurs4.egitmeni = "Murat Gül";
kurs4.IzlenmeOrani = 100;

//Console.WriteLine(kurs1.KursAdi + " : " + kurs1.egitmeni);

Kurs[] kurslar= new Kurs[] {kurs1, kurs2, kurs3, kurs4};

foreach (var kurs in kurslar) //kurs alias
{
    Console.WriteLine(kurs.KursAdi + " : " + kurs.egitmeni + " : " + kurs.IzlenmeOrani);
}


class Kurs
{
    public string KursAdi { get; set; } //prop tab tab

    public string egitmeni { get; set; }

    public int IzlenmeOrani { get; set; }
}

