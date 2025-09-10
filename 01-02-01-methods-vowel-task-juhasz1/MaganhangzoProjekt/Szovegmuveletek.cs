namespace MaganhangzoProjekt
{

    /// <summary>
    /// Szöveges segédfüggvényeket tartalmazó statikus osztály.
    /// </summary>
    public static class Szovegmuveletek
    {
        /// <summary>
        /// Eldönti, hogy a karakter magánhangzó-e (kis vagy nagy betű).
        /// </summary>
        /// <param name="c">A vizsgált karakter</param>
        /// <returns>Igaz, ha a karakter magánhangzó, különben hamis</returns>
        /// <example>MaganhangzoE('a') => true, MaganhangzoE('b') => false</example>
        public static bool MaganhangzoE(char c)
        {
            /*switch (c)
            {
                case 'a': return true;
                case 'e': return true;
                case 'i': return true;
                case 'o': return true;
                case 'u': return true;
                case 'á': return true;
                case 'é': return true;
                case 'í': return true;
                case 'ó': return true;
                case 'ö': return true;
                case 'ő': return true;
                case 'ú': return true;
                case 'ü': return true;
                case 'ű': return true;
            }*/

            return "aáeéiíoóöőuúű".Contains(char.ToLower(c));
        }

        /// <summary>
        /// Megvizsgálja, hogy a szöveg tartalmaz-e legalább egy magánhangzót.
        /// </summary>
        /// <param name="szoveg">A vizsgált sztring</param>
        /// <returns>Igaz, ha van benne legalább egy magánhangzó, különben hamis</returns>
        /// <example>TartalmazMaganhangzot("kutya") => true, TartalmazMaganhangzot("krptn") => false</example>
        public static bool TartalmazMaganhangzot(string szoveg)
        {
            foreach(char betu in szoveg)
            {
                if (MaganhangzoE(betu))
                    return true;
            }
            return false;
        }
    }
}