namespace CountProject
{
    internal static class DiakFeladatok
    {
        // -------------------------------
        // Adatmodell
        // -------------------------------
        public struct Diak
        {
            public string Nev { get; set; }
            public string Nem { get; set; }   // "F" = fiú, "L" = lány
            public DateTime SzuletesiDatum { get; set; }
            public int Osztondij { get; set; }
        }

        // -------------------------------
        // Teszt adatok
        // -------------------------------
        public static readonly List<Diak> Diakok = new()
    {
        new Diak { Nev="Anna",   Nem="L", SzuletesiDatum=new DateTime(2005,1,1), Osztondij=5000 },
        new Diak { Nev="Bence",  Nem="F", SzuletesiDatum=new DateTime(2004,5,12), Osztondij=0 },
        new Diak { Nev="Csilla", Nem="L", SzuletesiDatum=new DateTime(2006,3,23), Osztondij=10000 },
        new Diak { Nev="Dávid",  Nem="F", SzuletesiDatum=new DateTime(2005,9,15), Osztondij=7000 },
        new Diak { Nev="Erika",  Nem="L", SzuletesiDatum=new DateTime(2003,12,2), Osztondij=0 },
        new Diak { Nev="Ferenc", Nem="F", SzuletesiDatum=new DateTime(2004,2,5), Osztondij=6000 },
        new Diak { Nev="Gabi",   Nem="L", SzuletesiDatum=new DateTime(2005,4,30), Osztondij=8000 },
        new Diak { Nev="Hunor",  Nem="F", SzuletesiDatum=new DateTime(2006,7,7), Osztondij=4000 },
        new Diak { Nev="Ildikó", Nem="L", SzuletesiDatum=new DateTime(2005,11,20), Osztondij=0 },
        new Diak { Nev="János",  Nem="F", SzuletesiDatum=new DateTime(2003,8,8), Osztondij=9000 },
        new Diak { Nev="Kata",   Nem="L", SzuletesiDatum=new DateTime(2004,6,15), Osztondij=3000 },
        new Diak { Nev="László", Nem="F", SzuletesiDatum=new DateTime(2006,1,18), Osztondij=0 },
        new Diak { Nev="Mária",  Nem="L", SzuletesiDatum=new DateTime(2005,2,2), Osztondij=2000 },
        new Diak { Nev="Nóra",   Nem="L", SzuletesiDatum=new DateTime(2004,10,25), Osztondij=10000 },
        new Diak { Nev="Olivér", Nem="F", SzuletesiDatum=new DateTime(2003,3,14), Osztondij=0 },
        new Diak { Nev="Péter",  Nem="F", SzuletesiDatum=new DateTime(2005,5,5), Osztondij=2500 },
        new Diak { Nev="Réka",   Nem="L", SzuletesiDatum=new DateTime(2006,9,9), Osztondij=0 },
        new Diak { Nev="Sándor", Nem="F", SzuletesiDatum=new DateTime(2004,11,11), Osztondij=7500 },
        new Diak { Nev="Tímea",  Nem="L", SzuletesiDatum=new DateTime(2005,7,21), Osztondij=6000 },
        new Diak { Nev="Zoltán", Nem="F", SzuletesiDatum=new DateTime(2006,12,31), Osztondij=0 },
    };

        // -------------------------------
        // Feladatok (Count metódusok)
        // -------------------------------

        // --- Egyszerű feltételek ---
        public static int LanyokSzama()
        {
            return Diakok.Count(d => d.Nem == "L");
        }

        public static int FiukSzama()
        {
            return Diakok.Count(d => d.Nem == "F");
        }

        public static int OsztondijasokSzama()
        {
            return Diakok.Count(d => d.Osztondij > 0);
        }

        public static int NullasOsztondijSzama()
        {
            return Diakok.Count(d => d.Osztondij == 0);
        }

        public static int KisebbMint2005benSzulettek()
        {
            return Diakok.Count(d => d.SzuletesiDatum.Year <= 2005);
        }

        public static int LanyokOsztondijjal()
        {
            return Diakok.Count(d => d.Nem == "F" && d.Osztondij > 0);
        }

        public static int Fiuk2005Utan()
        {
            return Diakok.Count(d => d.Nem == "F" && d.SzuletesiDatum.Year > 2005);
        }

        public static int OlyanDiakokAkikVagyLanyVagyVanOsztondijuk()
        {
            return Diakok.Count(d => d.Nem == "F" || d.Osztondij > 0);
        }

        public static int OlyanDiakokAkik2004ElottSzulettekEsFiuk()
        {
            return Diakok.Count(d => d.Nem == "F" && d.SzuletesiDatum.Year < 2004);
        }

        public static int LanyokVagyNullasOsztondij()
        {
            return Diakok.Count(d => d.Nem == "F" || d.Osztondij == 0);
        }
    }
}