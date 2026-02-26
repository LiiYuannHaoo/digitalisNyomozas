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
            Console.WriteLine("1 Új ügy");
            Console.WriteLine("2 Ügyek listázása");

            string valasz = Console.ReadLine() ?? "";

            switch (valasz)
            {
                case "1":
                    Console.Write("Azonosító: ");
                    string id = Console.ReadLine() ?? "";
                    Console.Write("Cím: ");
                    string cim = Console.ReadLine() ?? "";
                    Console.Write("Leírás: ");
                    string leiras = Console.ReadLine() ?? "";

                    store.Ugyek.Add(new Case(id, cim, leiras));
                    break;

                case "2":
                    foreach (var u in store.Ugyek)
                        Console.WriteLine(u);
                    break;

                
            }
        }
    }
}