namespace StudentGradesProject
{
    class StudentStatistics
    {
        private string[] nevek;
        private int[] erdemjegyek;

        public StudentStatistics()
        {
            // 20 tanuló neve
            nevek = new string[]
            {
                "Anna", "Bence", "Csilla", "Dávid", "Erika",
                "Ferenc", "Gábor", "Hanna", "István", "Judit",
                "Kata", "László", "Mária", "Norbert", "Orsolya",
                "Péter", "Rita", "Sándor", "Tamás", "Zsófia"
            };

            // 20 tanuló jegye (1–5 között)
            erdemjegyek = new int[]
            {
                5, 3, 2, 4, 1,
                2, 5, 4, 3, 2,
                5, 1, 4, 3, 2,
                5, 5, 1, 3, 4
            };
        }

        // 1. Jegyek kiíratása nevekkel
        public void PrintGrades()
        {
            // foreach
            foreach (int jegy in erdemjegyek)
            {
                Console.WriteLine(jegy);

                foreach (string nev in nevek)
                {
                    Console.WriteLine(nev);
                    Console.WriteLine("jegy: " + erdemjegyek[jegy] + "nev: " + Convert(ToString(nevek[nev]));
                }
            }
        }

        // 2. Jegyek száma
        public void CountGrades()
        {
            int db = 0;
            foreach(int jegy in erdemjegyek)
            {
                db++;
            }
            Console.WriteLine("az erdemjegyek darabszama a tombben: " + db);
        }

        // 3. Első és utolsó jegy
        /*public void FirstAndLastGrade()
        {
            //erdemjegyek[0]
            int utolsoIndexe=erdemjegyek.Length-1;

        }*/
       

        // 5. Jegyek átlaga
        /*public void AverageGrade()
        {
            //int szumma = 0;

        //    for(int jegy in erdemjegyek)
        //    {
        //        szumma=;
        //    }
        }

        // 6. Legjobb jegy nevekkel
        public void MaxGrade()
        {
        }

        // 7. Legrosszabb jegy nevekkel
        public void MinGrade()
        {
        }

        // 8. Hány ötös volt?
        public void CountFives()
        {
        }

        // 9. Bukások száma (1-esek)
        public void CountFails()
        {
        }

        // 10. Jegy keresése
        public void SearchGrade(int search)
        {
        }

        // 11. Jegyek megfordítása
        public void ReverseGrades()
        {
        }

        // 12. Legjobb és legrosszabb helye
        public void BestAndWorstPosition()
        {
        }

        // 13. Van-e javulás?
        public void CheckImprovement()
        {
        }

        // 14. Átlag feletti jegyek száma
        public void CountAboveAverage()
        {
        }

        // 15. Rendezés (növekvő sorrend)
        public void SortGrades()
        {
        }
    }
}
