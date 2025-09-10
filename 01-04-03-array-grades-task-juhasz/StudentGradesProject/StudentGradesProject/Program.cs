using StudentGradesProject;

StudentStatistics stats = new StudentStatistics();

Console.WriteLine("=== 1. Jegyek kiíratása nevekkel ===");
stats.PrintGrades();

Console.WriteLine("\n=== 2. Jegyek száma ===");
stats.CountGrades();

Console.WriteLine("\n=== 3. Első és utolsó jegy nevekkel ===");
stats.FirstAndLastGrade();

Console.WriteLine("\n=== 5. Jegyek átlaga ===");
stats.AverageGrade();

Console.WriteLine("\n=== 6. Legjobb jegy érték ===");
stats.MaxGrade();

Console.WriteLine("\n=== 7. Legrosszabb jegy érték ===");
stats.MinGrade();

Console.WriteLine("\n=== 8. Ötös jegyek és tanulók ===");
stats.CountFives();

Console.WriteLine("\n=== 9. Bukások (1-esek) ===");
stats.CountFails();

Console.WriteLine("\n=== 10. Keresés: van-e 4-es jegy? ===");
stats.SearchGrade(4);

Console.WriteLine("\n=== 11. Jegyek fordított sorrendben nevekkel ===");
stats.ReverseGrades();

Console.WriteLine("\n=== 12. Legjobb és legrosszabb jegy nevekkel ===");
stats.BestAndWorstPosition();

Console.WriteLine("\n=== 13. Volt-e javulás? ===");
stats.CheckImprovement();

Console.WriteLine("\n=== 14. Átlag feletti jegyek nevekkel ===");
stats.CountAboveAverage();

Console.WriteLine("\n=== 15. Rendezett jegyek nevekkel ===");
stats.SortGrades();

Console.WriteLine("\n=== Program vége ===");
Console.ReadLine(); // hogy ne záródjon be azonnal a konzol
