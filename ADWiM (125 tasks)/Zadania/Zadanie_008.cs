using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_008 : IZadanie
    {
        public int ID { get; set; } = 8;
        public string Text { get; set; } = "8. Opisz typy nullable – jak działają, kiedy z nich korzystać.  ";
        public void Execute()
        {
            int a; // zwykła zmienna typu wartościowego
            int? b = null; // zmienna nullable typu wartościowego
            //int c = null; // błąd kompilacji - zwykła zmienna nie może być null

            //Console.WriteLine(a); // Powoduje błąd kompilacji
            //Console.WriteLine(b); // Również powoduje błąd kompilacji

            //if (a.HasValue()) // Nieposiada tej funkcjonalności.
            if (b.HasValue)
            {

            }
            //a.GetValueOrDefault(); // Nieposiada tej funkcjonalności.
            b.GetValueOrDefault();

            string c = null; // zmienna referencyjna może być null
            string? d = null; // używanie nullable z typem referencyjnym to antipattern

            //if (c.HasValue()) // Nieposiada tej funkcjonalności.
            //if (d.HasValue()) // Nadal nie posiada tej funkcjonalności.
            if (c == null)
            {
            }
            if (d == null)
            {
            }

            Console.WriteLine(@"typy nullable pozwalają zmiennym wartościowym (int, float, bool)
na przyjęcie wartości null (brak wartości)
Warto zaznaczyć że wartości referencyjne zawsze są nullable i nullable wartość referencyjna to antipattern

Wartość nullable używa się za pomocą '?' np. int? zmienna = null;
typy nullable też zyskują dodatkowe metody np. GetValueOrDefault() czy HasValue().

typy nullable stosuje się gdy wiemy że zmienna może nie posiadać wartości, np. w opcjonalnych polach formularzy.
");
        }
    }
}