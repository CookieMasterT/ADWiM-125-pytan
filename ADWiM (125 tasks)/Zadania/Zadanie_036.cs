using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public static class RozszerzenieZad36
    {
        public static void Zklep(this ref int liczba) // stara metoda
        {
            liczba *= 5;
        }

        extension(ref int num) // nowa metoda rozszerzenia
        {
            public void Zaklep()
            {
                num /= 5;
            }
        }
        
        public static void NewMethod(this PrzykladZad36 PZ)
        {
            Console.WriteLine("To jest nowa metoda rozszerzenia dla klasy PrzykladZad36");
        }
    }

    public class PrzykladZad36
    {
    }

    public class Zadanie_036 : IZadanie
    {
        public int ID { get; set; } = 36;
        public string Text { get; set; } = "36. Czym są oraz jak tworzyć metody rozszerzeń?  ";

        public void Execute()
        {
            int liczba = 10;
            liczba.Zklep();
            Console.WriteLine(liczba.ToString());

            Console.WriteLine(@"Metody rozserzeń to są metody które rozszerzają istniejące już typy lub klasy, bez modyfikowania ich.
Jest to szczególnie użyteczne przy typach podstawowych (np. int, string) lub klasach z bibliotek zewnętrznych.

Metoda rozszerzenia musi być w statycznej, niezagnieżdzonej klasie, jako statyczna metoda.
Są 2 metody zadeklarowania metody rozszerzenia:
    - Stara, utworzenie metody która jako pierwszy parametr przyjmuje typ z słowem kluczowym ""this"" np.: 
    public static void Pomnóż(this ref int liczba) { liczba *= 5 }
    - Nowa, zadeklarowanie funkcji w zakresie ""extension()"" np.:
    extension(ref int num)
    {
        public void Podziel() { num /= 5; }
    }");
        }
    }
}