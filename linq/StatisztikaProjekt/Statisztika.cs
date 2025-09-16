namespace StatisztikaProjekt
{
    public static class Statisztika
    {
        // --------------------------------------------------------------------
        // Adattag – 15 elemű, float lista (1 tizedesjegy pontossággal)
        // --------------------------------------------------------------------
        private static readonly List<float> _adatok = new()
        {
            12.5f, 8.0f, -3.2f, 15.4f, 9.9f,
            10.0f, 10.0f, 2.3f, 7.1f, 7.1f,
            0.0f, 5.5f, 3.3f, 18.7f, 12.0f
        };

        // =========================
        // 1) Aggregálások / számítások
        // =========================

        /// <summary>Visszaadja az értékek összegét.</summary>
        /// <returns>Az elemek összege.</returns>
        public static float Osszeg() => 0;

        /// <summary>Visszaadja az értékek átlagát.</summary>
        /// <returns>Az elemek átlaga.</returns>
        public static float Atlag() => 0;

        /// <summary>Visszaadja a legkisebb értéket.</summary>
        /// <returns>A lista minimuma.</returns>
        public static float Minimum() => 0;

        /// <summary>Visszaadja a legnagyobb értéket.</summary>
        /// <returns>A lista maximuma.</returns>
        public static float Maximum() => 0;

        /// <summary>Megadja az elemek számát.</summary>
        /// <returns>Az elemek darabszáma.</returns>
        public static int Darabszam() => 0;

        // =========================
        // 2) Keresés és kiválasztás
        // =========================

        /// <summary>Visszaadja az első elemet.</summary>
        /// <returns>Az első elem.</returns>
        public static float ElsoElem(float szam)
        {
            return _adatok.Last(szamok => ElsoElem(szam));
        }

        /// <summary>Visszaadja az utolsó elemet.</summary>
        /// <returns>Az utolsó elem.</returns>
        public static float UtolsoElem(float elem)
        {
            return _adatok.Last(szamok => UtolsoElem(elem));
        }

        /// <summary>Ellenőrzi, hogy szerepel-e a listában a megadott érték.</summary>
        /// <param name="ertek">A keresett érték.</param>
        /// <returns>Igaz, ha szerepel; különben hamis.</returns>
        public static bool Tartalmazza(float ertek)
        {
                return _adatok.Any(tartalom => Tartalmazza(ertek));
        }

        /// <summary>Visszaadja a 0-alapú indexen található elemet.</summary>
        /// <param name="index">A 0-alapú index.</param>
        /// <returns>Az adott indexű elem értéke.</returns>
        public static float ElemIndexen(int index) => 0;

        // =========================
        // 3) Szűrés (Where)
        // =========================

        /// <summary>Visszaadja azokat az értékeket, amelyek nagyobbak az alsó határnál.</summary>
        /// <param name="alsoHatar">Alsó határérték (nem inkluzív).</param>
        /// <returns>Az alsó határnál nagyobb elemek listája.</returns>
        public static List<float> SzuroNagyobbMint(float alsoHatar) =>
            new List<float>();

        /// <summary>Visszaadja azokat az értékeket, amelyek egy [alsó, felső] zárt intervallumban vannak.</summary>
        /// <param name="also">Alsó határ (inkluzív).</param>
        /// <param name="felso">Felső határ (inkluzív).</param>
        /// <returns>Az intervallumba eső elemek listája.</returns>
        public static List<float> SzuroIntervallum(float also, float felso) =>
            new List<float>();

        /// <summary>Visszaadja a negatív értékeket.</summary>
        /// <returns>A negatív elemek listája.</returns>
        public static List<float> NegativErtekek() =>
            new List<float>();

        /// <summary>Megadja, hogy van-e a megadott intervallumban legalább egy elem.</summary>
        /// <param name="also">Alsó határ (inkluzív).</param>
        /// <param name="felso">Felső határ (inkluzív).</param>
        /// <returns>Igaz, ha van ilyen elem, különben hamis.</returns>
        public static bool VanElemIntervallumban(float also, float felso) =>
            false;

        /// <summary>Visszaadja az átlag feletti értékeket.</summary>
        /// <returns>Az átlag feletti elemek listája.</returns>
        public static List<float> AtlagFelettiek() =>
            new List<float>();

        // =========================
        // 4) Transzformáció (Select)
        // =========================

        /// <summary>Minden elemet megszoroz a megadott szorzóval.</summary>
        /// <param name="szorzo">A szorzó értéke.</param>
        /// <returns>A transzformált elemek listája.</returns>
        public static List<float> Szorzas(float szorzo) =>
           new List<float>();

        /// <summary>Minden elemet megnövel az adott növekménnyel.</summary>
        /// <param name="novekmeny">A hozzáadandó érték.</param>
        /// <returns>A növelt elemek listája.</returns>
        public static List<float> Novel(float novekmeny) =>
            new List<float>();

        // =========================
        // 5) Duplikátumok kezelése (Distinct)
        // =========================

        /// <summary>Eltávolítja az ismétlődő értékeket.</summary>
        /// <returns>Az egyedi elemek listája.</returns>
        public static List<float> EgyediErtekek() =>
            new List<float>();

        /// <summary>Az első N egyedi értéket adja vissza a lista sorrendjében.</summary>
        /// <param name="n">A visszaadandó elemek száma.</param>
        /// <returns>Az első N egyedi elem listája.</returns>
        public static List<float> ElsoNEgyedi(int n) =>
            new List<float>();

        // =========================
        // 6) Rendezés (OrderBy / OrderByDescending)
        // =========================

        /// <summary>Növekvő sorrendbe rendezi az értékeket.</summary>
        /// <returns>Növekvő sorrendű lista.</returns>
        public static List<float> NovekvoRendezes() =>
            new List<float>();

        /// <summary>Csökkenő sorrendbe rendezi az értékeket.</summary>
        /// <returns>Csökkenő sorrendű lista.</returns>
        public static List<float> CsokkenoRendezes() =>
            new List<float>();

        /// <summary>A 3 legnagyobb értéket adja vissza.</summary>
        /// <returns>A három legnagyobb elem listája.</returns>
        public static List<float> Top3Legnagyobb() =>
            new List<float>();

        /// <summary>A 3 legkisebb értéket adja vissza.</summary>
        /// <returns>A három legkisebb elem listája.</returns>
        public static List<float> Also3Legkisebb() =>
            new List<float>();

        // =========================
        // 7) Részhalmaz (Take / Skip)
        // =========================

        /// <summary>Visszaadja az első N elemet.</summary>
        /// <param name="n">Az elemek száma.</param>
        /// <returns>Az első N elem listája.</returns>
        public static List<float> ElsoNElem(int n) =>
            new List<float>();

        /// <summary>Az első N elem kihagyása után visszaadja a maradékot.</summary>
        /// <param name="n">Kihagyandó elemek száma az elejéről.</param>
        /// <returns>Az N kihagyása utáni elemek listája.</returns>
        public static List<float> KihagyElsoN(int n) =>
            new List<float>();

        /// <summary>Az első N kihagyása után visszaad M elemet.</summary>
        /// <param name="skip">Kihagyandó elemek száma.</param>
        /// <param name="take">Visszaadandó elemek száma.</param>
        /// <returns>A részlista elemei.</returns>
        public static List<float> Részhalmaz(int skip, int take) =>
            new List<float>();

        /// <summary>Visszaadja az index 0..N-1 tartományt növekvő sorrendben.</summary>
        /// <param name="n">Felső határ (nem inkluzív).</param>
        /// <returns>Növekvő sorrendű részlista.</returns>
        public static List<float> NovekvoElsoN(int n) =>
            new List<float>();

        /// <summary>Visszaadja az első N elem kihagyása utáni listát csökkenő sorrendben.</summary>
        /// <param name="n">Kihagyandó elemek száma az elejéről.</param>
        /// <returns>Csökkenő sorrendű részlista.</returns>
        public static List<float> CsokkenoKihagyN(int n) =>
            new List<float>();

        // =========================
        // 8) Kombinált feladatok (megadott operátorok felhasználásával)
        // =========================

        /// <summary>Az egyedi, nem negatív értékeket adja vissza növekvő sorrendben.</summary>
        /// <returns>Egyedi, nem negatív, növekvő lista.</returns>
        public static List<float> EgyediNemNegativNovekvo() =>
            new List<float>();

        /// <summary>Az átlag feletti első három értéket adja vissza a lista sorrendjében.</summary>
        /// <returns>Az átlag feletti első három elem.</returns>
        public static List<float> AtlagFelettiElso3() =>
            new List<float>();

        /// <summary>Az utolsó 5 elem kétszeresét adja vissza csökkenő sorrendben.</summary>
        /// <returns>Utolsó 5 elem kétszerezve, csökkenő sorrendben.</returns>
        public static List<float> Utolso5DuplaCsokkeno() =>
            new List<float>();

        /// <summary>Megadja, hogy az első N elem között szerepel-e a megadott érték.</summary>
        /// <param name="n">Vizsgált elemszám az elejéről.</param>
        /// <param name="ertek">Keresett érték.</param>
        /// <returns>Igaz, ha az első N-ben benne van; különben hamis.</returns>
        public static bool ElsoNBenneVan(int n, float ertek) =>
           false;

        /// <summary>Megadja az átlag alatti elemek számát.</summary>
        /// <returns>Az átlag alatti elemek darabszáma.</returns>
        public static int AtlagAlattiDarab() =>
            0;
    }
}
