using _20241118_BerekCLI;
using System.Reflection.Metadata.Ecma335;
using System.Text;

List<Berek> berek = [];

using StreamReader sr = new("..\\..\\..\\src\\berek2020.txt",Encoding.UTF8);
sr.ReadLine();
while (!sr.EndOfStream) berek.Add(new(sr.ReadLine()));
Console.WriteLine($"3.feladat: Dolgozók létszáma: {berek.Count}");

var f4 = berek.Average(f => f.Ber);
Console.WriteLine($"4.feladat: Bérek átlaga {f4:0.00} eFt");

//f6
Console.Write("5.feladat: Kérem a részleg nevét: ");
var f5 = Console.ReadLine();

Console.WriteLine("A legtöbbet kereső dolgozó a megadott részlegen: ");

for(int i = 0; i<berek.Count; i++)
{
    if (berek[i].Reszleg == f5.ToLower())
    {
        var f6 = berek.Where(f => f.Reszleg == f5.ToLower()).Max(f => f.Ber);
        Console.WriteLine($"Név: {berek[i].Nev}\nNem:{berek[i].Neme}\nBelépés: {berek[i].Belepes}\nBér: {berek[i].Ber} Forint");
        return;
    }
}

Console.WriteLine("7. Feladat: Statisztika");
var f7 = berek.Select(f => f.Reszleg);
foreach(var position in berek.Distinct())
{
    Console.WriteLine($"\n{position} - {berek.Count(f => f.Reszleg.Equals(position))} fő;");
}