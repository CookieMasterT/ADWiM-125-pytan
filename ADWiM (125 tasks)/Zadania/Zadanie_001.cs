using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_001 : IZadanie
    {
        public int ID { get; set; } = 1;
        public string Text { get; set; } = "1. Wyjaśnij rolę typów danych w językach programowania.  ";
        public void Execute()
        {
            Console.WriteLine(
               @"Typy danych w językach programowania określają rodzaj wartości jaką może przechowywać zmienna.
Pozwalają na lepsze zarządzanie pamięcią, zapewniają bezpieczeństwo kodu i zawierają informację o tym,
jakie operacje można dokonywać na zmiennych.
Używanie typów danych również może polepszyć czytelność kodu."
                );
        }
    }
}