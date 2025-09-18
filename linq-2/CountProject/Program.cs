using CountProject;

Console.WriteLine("Lányok száma: " + DiakFeladatok.LanyokSzama());
Console.WriteLine("Fiúk száma: " + DiakFeladatok.FiukSzama());
Console.WriteLine("Ösztöndíjasok száma: " + DiakFeladatok.OsztondijasokSzama());
Console.WriteLine("Ösztöndíj nélküli diákok száma: " + DiakFeladatok.NullasOsztondijSzama());
Console.WriteLine("2005 előtt születettek száma: " + DiakFeladatok.KisebbMint2005benSzulettek());

Console.WriteLine("Lányok ösztöndíjjal: " + DiakFeladatok.LanyokOsztondijjal());
Console.WriteLine("Fiúk 2005 után: " + DiakFeladatok.Fiuk2005Utan());
Console.WriteLine("Lányok VAGY ösztöndíjasok: " + DiakFeladatok.OlyanDiakokAkikVagyLanyVagyVanOsztondijuk());
Console.WriteLine("2004 előtt született fiúk: " + DiakFeladatok.OlyanDiakokAkik2004ElottSzulettekEsFiuk());
Console.WriteLine("Lányok VAGY nullás ösztöndíj: " + DiakFeladatok.LanyokVagyNullasOsztondij());

