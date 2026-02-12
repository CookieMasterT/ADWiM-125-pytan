using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_035 : IZadanie
    {
        public int ID { get; set; } = 35;
        public string Text { get; set; } = "35. Czym są klasy cząstkowe? Kiedy się z nich korzysta, w jaki sposób?  ";

        private partial class PrzykladCzastkowy
        {
            public void Czesc1()
            {
                Console.WriteLine("To jest część 1");
            }
        }
        
        private partial class PrzykladCzastkowy
        {
            public void Czesc2()
            {
                Console.WriteLine("To jest część 2");
            }
        }

        public void Execute()
        {
            PrzykladCzastkowy PC = new PrzykladCzastkowy();

            PC.Czesc1();
            PC.Czesc2(); // obie części istnieją.
            // PC.Czesc3(); // nie istnieje, jest zadeklarowana w innym miejscu (poza Zadanie_35).

            Console.WriteLine();

            Console.WriteLine(@"Klasy cząstkowe tworzy się poprzez użycie słowa kluczowego ""partial"" w deklaracji (deklaracjach) klasy.
Wszystkie częsci klasy zadeklarowane w ten sposób (jeżeli jest zrobione to w jednym zakresie)
będą interpretowane jako jedna klasa, nawet jeżeli jest to zrobione w kilku plikach.

Pozwala to na:
    - Organizację dużych klas (rozdzielenie logiki, właściwości, metod etc.)
    - Wprowadzić podział kodu wygenerowanego automatycznie, od kodu napisanego przez programistę (ręcznie)");
        }
    }
}

public partial class PrzykladCzastkowy
{
    public void Czesc3()
    {
        Console.WriteLine("To jest część 3");
    }
}