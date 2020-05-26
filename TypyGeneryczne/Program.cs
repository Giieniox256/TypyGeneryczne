using System;

namespace TypyGeneryczne
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var kolejka = new KolejkaKolowa(3);
            var wartosc = 0.0;

            while (true)
            {
                var wpisana = Console.ReadLine();

                if (double.TryParse(wpisana,out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;

            }
            Console.WriteLine("W naszej kolejce jest :");
            while (!kolejka.JestPusty)
            {
                Console.WriteLine("\t\t"+kolejka.Czytaj());
            }
        }
    }
}
