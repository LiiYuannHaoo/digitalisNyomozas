using System;
using DigitalisNyomozas;

internal class Program
{
    private static void Main(string[] args)
    {
        DataStore store = new DataStore();
        DecisionEngine engine = new DecisionEngine();

        bool fut = true;

        while (fut)
        {
            Console.WriteLine("1 Új ugy");
            Console.WriteLine("2 Ügyek listázása");
            Console.WriteLine("3 Személy hozzáadás");
            Console.WriteLine("4 Bizonyíték rögzítés");

            string valasz = Console.ReadLine() ?? "";

            switch (valasz)
            {
                case "1":
                    Console.Write("Azonosító: ");
                    string id = Console.ReadLine() ?? "";
                    Console.Write("Cim: ");
                    string cim = Console.ReadLine() ?? "";
                    Console.Write("Leírás: ");
                    string leiras = Console.ReadLine() ?? "";

                    store.Ugyek.Add(new Case(id, cim, leiras));
                    break;

                case "2":
                    foreach (var u in store.Ugyek)
                        Console.WriteLine(u);
                    break;

                case "3":
                    Console.Write("Ügy ID: ");
                    string uid = Console.ReadLine() ?? "";
                    var ugy = store.Ugyek.Find(x => x.UgyAzonosito == uid);

                    if (ugy != null)
                    {
                        Console.Write("Név: ");
                        string nev = Console.ReadLine() ?? "";
                        Console.Write("Kor: ");
                        int kor = int.Parse(Console.ReadLine() ?? "0");

                        ugy.SzemelyHozzaadas(new Person(nev, kor, ""));
                    }
                    break;

                case "4":
                    Console.Write("Ügy ID: ");
                    string bid = Console.ReadLine() ?? "";
                    var ugy2 = store.Ugyek.Find(x => x.UgyAzonosito == bid);

                    if (ugy2 != null)
                    {
                        Console.Write("Bizonyíték ID: ");
                        string eid = Console.ReadLine() ?? "";
                        Console.Write("Tipus: ");
                        string tipus = Console.ReadLine() ?? "";
                        Console.Write("Leírás: ");
                        string l = Console.ReadLine() ?? "";
                        Console.Write("Megbízhatósag (1-5): ");
                        int m = int.Parse(Console.ReadLine() ?? "1");

                        ugy2.BizonyitekHozzaadas(new Evidence(eid, tipus, l, m));
                    }
                    break;

            }
        }
    }
}