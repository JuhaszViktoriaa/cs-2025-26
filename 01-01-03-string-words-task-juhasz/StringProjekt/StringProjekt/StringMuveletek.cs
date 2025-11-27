namespace StringProjekt
{
    public static class StringMuveletek
    {
        /// <summary>
        /// Felbontja a szöveget szóközök mentén szavakra.
        /// </summary>
        /// <param name="szoveg">A vizsgált teljes szöveg</param>
        /// <returns>A szavakat tartalmazó tömb</returns>
        /// <example>SzavakListaja("alma a fa") => ["alma", "a", "fa"]</example>
        public static string[] SzavakListaja(string szoveg)
        {
            string[] szavak = szoveg.Split(' ');
            return szavak;
        }

        /// <summary>
        /// Eldönti, hogy a megadott szöveg a keresett szöveggel kezdődik-e.
        /// </summary>
        /// <param name="szoveg">Vizsgált szöveg</param>
        /// <param name="keresett">Keresett kezdő szórészlet</param>
        /// <returns>True, ha kezdődik vele, egyébként false</returns>
        /// <example>KezdodikE("alma", "al") => true</example>
        private static bool KezdodikE(string szoveg, string keresett)
        {
            return false;
        }

        /// <summary>
        /// Visszaadja azokat a szavakat, amelyek a keresett részlettel kezdődnek.
        /// </summary>
        /// <param name="szavak">Szavak tömbje</param>
        /// <param name="keresett">Kezdő szórészlet</param>
        /// <returns>Azok a szavak, amelyek ezzel kezdődnek</returns>
        /// <example>SzavakKezdodikEvel(["alma", "fa"], "a") => ["alma"]</example>
        public static string[] SzavakKezdodikEvel(string[] szavak, string keresett)
        {
            return [];
        }

        /// <summary>
        /// Eldönti, hogy a megadott szöveg a keresett szöveggel végződik-e.
        /// </summary>
        /// <param name="szoveg">Vizsgált szöveg</param>
        /// <param name="keresett">Keresett végződés</param>
        /// <returns>True, ha végződik vele, egyébként false</returns>
        /// <example>VegzodikE("alatt", "tt") => true</example>
        private static bool VegzodikE(string szoveg, string keresett)
        {
            return false;
        }

        /// <summary>
        /// Visszaadja azokat a szavakat, amelyek a keresett részlettel végződnek.
        /// </summary>
        /// <param name="szavak">Szavak tömbje</param>
        /// <param name="keresett">Végződő szórészlet</param>
        /// <returns>Azok a szavak, amelyek ezzel végződnek</returns>
        /// <example>SzavakVegzodikEvel(["alma", "alatt"], "t") => ["alatt"]</example>
        public static string[] SzavakVegzodikEvel(string[] szavak, string keresett)
        {
            return [];
        }

        /// <summary>
        /// Minden szó első betűjét nagybetűssé alakítja, a többit kisbetűssé.
        /// </summary>
        /// <param name="szoveg">A bemeneti szöveg</param>
        /// <returns>Címszerűen formázott szöveg</returns>
        /// <example>CimFormazas("alma a fa alatt") => "Alma A Fa Alatt"</example>
        public static string CimFormazas(string szoveg)
        {
            return string.Empty;
        }

    }
}
