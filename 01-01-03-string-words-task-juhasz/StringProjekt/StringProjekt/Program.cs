using StringProjekt;

string tesztSzoveg = "alma a fa alatt";
string[] szavak = StringMuveletek.SzavakListaja(tesztSzoveg);

Console.WriteLine("Szavak listája:");
foreach (var szo in szavak)
{
    Console.WriteLine($"- {szo}");
}

Console.WriteLine("\nCímformázott szöveg:");
Console.WriteLine(StringMuveletek.CimFormazas(tesztSzoveg));

Console.WriteLine("\nSzavak, amelyek 'a'-val kezdődnek:");
var kezdodoSzavak = StringMuveletek.SzavakKezdodikEvel(szavak, "a");
foreach (var szo in kezdodoSzavak)
{
    Console.WriteLine($"- {szo}");
}

Console.WriteLine("\nSzavak, amelyek 't'-re végződnek:");
var vegzodoSzavak = StringMuveletek.SzavakVegzodikEvel(szavak, "t");
foreach (var szo in vegzodoSzavak)
{
    Console.WriteLine($"- {szo}");
}
