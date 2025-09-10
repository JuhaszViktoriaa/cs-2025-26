// Program.cs
using MaganhangzoProjekt;

class Program
{
    static void Teszt(string szoveg)
    {
        Console.WriteLine($"\"{szoveg}\" tartalmaz magánhangzót? => {Szovegmuveletek.TartalmazMaganhangzot(szoveg)}");
    }

    static void Main()
    {
        Console.WriteLine("=== Magánhangzó vizsgálat ===\n");

        Teszt("kutya");
        Teszt("vrt");
        Teszt("npm");
        Teszt("");
        Teszt("");
    }
}