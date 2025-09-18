# 1.2.1 Struct, List, Count és lambda kifejezések

## struct

A `struct` (struktúra) egy értéktípus C#-ban, amely hasonlít az
osztályhoz, de kisebb adatmodellekhez gyakran használjuk.\
A `struct` adattagokat és metódusokat is tartalmazhat, de általában
egyszerűbb, mint egy osztály.

### Példa struct-ra: Dolgozó

A `struct` segítségével egyszerű adatmodelleket készíthetünk.

Most hozzunk létre egy `Dolgozo` nevű struktúrát, amely több adattal
rendelkezik:

``` csharp
public struct Dolgozo
{
    public string Nev { get; set; }         // Dolgozó neve
    public int Eletkor { get; set; }        // Életkor
    public string Beosztas { get; set; }    // Beosztás
    public DateTime Belepes { get; set; }   // Belépés dátuma
    public int Fizetes { get; set; }        // Fizetés (Ft)

    // Konstruktor
    public Dolgozo(string nev, int eletkor, string beosztas, DateTime belepes, int fizetes)
    {
        Nev = nev;
        Eletkor = eletkor;
        Beosztas = beosztas;
        Belepes = belepes;
        Fizetes = fizetes;
    }
}
```

### Program.cs példa

``` csharp
class Program
{
    static void Main(string[] args)
    {
        // Új dolgozó létrehozása
        Dolgozo dolgozo = new Dolgozo(
            "Kovács Péter",
            30,
            "Fejlesztő",
            new DateTime(2020, 5, 12),
            450000
        );

        // Egy adat kiírása
        Console.WriteLine("Dolgozó neve: " + dolgozo.Nev);

        // Egy adat megváltoztatása
        dolgozo.Fizetes = 500000;

        Console.WriteLine("Dolgozó új fizetése: " + dolgozo.Fizetes);
    }
}
```

------------------------------------------------------------------------

## Count

A `Count` egy LINQ művelet, amely megszámolja a gyűjtemény elemeit.\
A `Count` használható egyszerűen az elemszám meghatározására, vagy egy
feltétel megadásával csak a feltételnek megfelelő elemeket számolja meg.

## Lambda kifejezések és Count

A lambda kifejezések rövid, névtelen függvények, amelyeket gyakran
használunk LINQ műveletekben.\
A `Count` metódusban például így használhatjuk:

``` csharp
public struct Diak
{
    public string Nev { get; set; }
    public string Nem { get; set; }   // "F" = fiú, "L" = lány
    public DateTime SzuletesiDatum { get; set; }
    public int Osztondij { get; set; }
 }
...
public static readonly List<Diak> Diakok = new()
...
Diakok.Count(d => d.Nem == "L")
```

Ez megszámolja, hány olyan diák van a listában, akinek a neme `'L'`.

------------------------------------------------------------------------

## Feladat

Nyisd meg a **DiakFeladatok.cs** állományt.

1.  Számold meg, hány lány van a listában.
2.  Számold meg, hány fiú van a listában.
3.  Számold meg, hány ösztöndíjas diák van.
4.  Számold meg, hány olyan diák van, akinek nincs ösztöndíja.
5.  Számold meg, hány diák született 2005 előtt.
6.  Számold meg, hány lány rendelkezik ösztöndíjjal.
7.  Számold meg, hány fiú született 2005 után.
8.  Számold meg, hány olyan diák van, aki vagy lány, vagy van
    ösztöndíja.
9.  Számold meg, hány fiú született 2004 előtt.
10. Számold meg, hány olyan diák van, aki lány vagy nincs ösztöndíja.

A megoldáshoz minden feladathoz hozz létre egy metódust, amely visszaadja az adott megszámlált értéket.
