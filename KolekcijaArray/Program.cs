using KolekcijaArray;

int[] niz = { 5, 2, 3, 1 };
Array.Sort(niz);
Array.Reverse(niz);
/* foreach (var n in niz)
    Console.Write(n + " ");
Console.WriteLine(); */
Ispis(niz);

void Ispis(Array niz)
{
	foreach (var item in niz)
	{
		Console.WriteLine(item);
	}
}

Rezultat[] rezultati = new[]
{
	new Rezultat(new ("John","Doe"), "abc", 5),
	new Rezultat(new ("Mary","Doe"), "def", 1),
	new Rezultat(new ("Ann","Doe"), "ghi", 9),
	new Rezultat(new ("Edward","Doe"), "gkl", 4)
};

Console.WriteLine("-----Prije sortiranja-----");
Ispis(rezultati);
Console.WriteLine("-----Nakon sortiranja-----");

/* int funkcija(Rezultat x, Rezultat y)
	=> x.bodovi - y.bodovi; */

Array.Sort(rezultati); //, (x,y) => funkcija(x,y));
Ispis(rezultati);

bool PocetnoSlovo(Rezultat x, char z)
	=> x.sifra[0] == z;

int rez = Array.FindIndex(rezultati, 
	x => PocetnoSlovo(x, 'g'));
Console.WriteLine("nasao: " + rez);

var neparni = Array.FindAll(rezultati,
	x => x.bodovi % 2 == 1);
foreach (var item in neparni)
{
	Console.WriteLine(item);
}

bool postoji = Array.TrueForAll(rezultati,
	x => x.bodovi < 10);
Console.WriteLine("Svi imaju < 10: " + postoji);

int t = Array.BinarySearch(rezultati,
    new Rezultat(new("John", "Doe"), "abc", 5));
Console.WriteLine(t);