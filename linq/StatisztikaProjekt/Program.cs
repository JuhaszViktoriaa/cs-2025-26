using StatisztikaProjekt;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== 1) Aggregálások / számítások ===");
        Console.WriteLine($"Összeg: {Statisztika.Osszeg():0.0}");
        Console.WriteLine($"Átlag: {Statisztika.Atlag():0.0}");
        Console.WriteLine($"Minimum: {Statisztika.Minimum():0.0}");
        Console.WriteLine($"Maximum: {Statisztika.Maximum():0.0}");
        Console.WriteLine($"Darabszám: {Statisztika.Darabszam()}");
        Console.WriteLine();

        Console.WriteLine("=== 2) Keresés és kiválasztás ===");
        Console.WriteLine($"Első elem: {Statisztika.ElsoElem():0.0}");
        Console.WriteLine($"Utolsó elem: {Statisztika.UtolsoElem():0.0}");
        Console.WriteLine($"Tartalmazza a 10.0-t? {Statisztika.Tartalmazza(10.0f)}");
        Console.WriteLine($"Elem index 2: {Statisztika.ElemIndexen(2):0.0}");
        Console.WriteLine();

        Console.WriteLine("=== 3) Szűrés (Where) ===");
        Print("Nagyobb mint 5.0", Statisztika.SzuroNagyobbMint(5.0f));
        Print("Intervallum [0.0, 10.0]", Statisztika.SzuroIntervallum(0.0f, 10.0f));
        Print("Negatív értékek", Statisztika.NegativErtekek());
        Console.WriteLine($"Van elem az [10.0, 20.0] intervallumban? {Statisztika.VanElemIntervallumban(10.0f, 20.0f)}");
        Print("Átlag felettiek", Statisztika.AtlagFelettiek());
        Console.WriteLine();

        Console.WriteLine("=== 4) Transzformáció (Select) ===");
        Print("×2.0 szorzás", Statisztika.Szorzas(2.0f));
        Print("+1.5 növelés", Statisztika.Novel(1.5f));
        Console.WriteLine();

        Console.WriteLine("=== 5) Duplikátumok (Distinct) ===");
        Print("Egyedi értékek", Statisztika.EgyediErtekek());
        Print("Első 5 egyedi", Statisztika.ElsoNEgyedi(5));
        Console.WriteLine();

        Console.WriteLine("=== 6) Rendezés (OrderBy / OrderByDescending) ===");
        Print("Növekvő", Statisztika.NovekvoRendezes());
        Print("Csökkenő", Statisztika.CsokkenoRendezes());
        Print("Top 3 legnagyobb", Statisztika.Top3Legnagyobb());
        Print("Alsó 3 legkisebb", Statisztika.Also3Legkisebb());
        Console.WriteLine();

        Console.WriteLine("=== 7) Részhalmaz (Take / Skip) ===");
        Print("Első 4 elem", Statisztika.ElsoNElem(4));
        Print("Kihagy első 4-et", Statisztika.KihagyElsoN(4));
        Print("Részhalmaz (skip:4, take:3)", Statisztika.Részhalmaz(4, 3));
        Print("Növekvő az első 6-ból", Statisztika.NovekvoElsoN(6));
        Print("Csökkenő a 4 kihagyása után", Statisztika.CsokkenoKihagyN(4));
        Console.WriteLine();

        Console.WriteLine("=== 8) Kombinált feladatok ===");
        Print("Egyedi, nem negatív, növekvő", Statisztika.EgyediNemNegativNovekvo());
        Print("Átlag feletti első 3", Statisztika.AtlagFelettiElso3());
        Print("Utolsó 5 kétszerezve, csökkenő", Statisztika.Utolso5DuplaCsokkeno());
        Console.WriteLine($"Első 5-ben benne van a 10.0? {Statisztika.ElsoNBenneVan(5, 10.0f)}");
        Console.WriteLine($"Átlag alatti darab: {Statisztika.AtlagAlattiDarab()}");
    }

    // Kis segédfüggvény szép kiíráshoz
    private static void Print(string label, IEnumerable<float> seq)
        => Console.WriteLine($"{label}: {string.Join(", ", seq.Select(x => x.ToString("0.0")))}");
}

