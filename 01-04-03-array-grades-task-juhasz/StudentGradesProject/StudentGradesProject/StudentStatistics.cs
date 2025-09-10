namespace StudentGradesProject
{
    class StudentStatistics
    {
        private string[] names;
        private int[] grades;

        public StudentStatistics()
        {
            // 20 tanuló neve
            names = new string[]
            {
                "Anna", "Bence", "Csilla", "Dávid", "Erika",
                "Ferenc", "Gábor", "Hanna", "István", "Judit",
                "Kata", "László", "Mária", "Norbert", "Orsolya",
                "Péter", "Rita", "Sándor", "Tamás", "Zsófia"
            };

            // 20 tanuló jegye (1–5 között)
            grades = new int[]
            {
                5, 3, 2, 4, 1,
                2, 5, 4, 3, 2,
                5, 1, 4, 3, 2,
                5, 5, 1, 3, 4
            };
        }

        // 1. Jegyek kiíratása
        public void PrintGrades()
        {
        }

        // 2. Jegyek száma
        public void CountGrades()
        {
        }

        // 3. Első és utolsó jegy
        public void FirstAndLastGrade()
        {
        }

        // 5. Jegyek átlaga
        public void AverageGrade()
        {
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