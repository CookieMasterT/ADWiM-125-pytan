using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_111 : IZadanie
    {
        public int ID { get; set; } = 111;
        public string Text { get; set; } = "111. Czym jest odrzucanie tasków? Jak działa?  ";
        public void Execute()
        {
            Console.WriteLine(@"Jest to wykonywanie funkcji asynchronicznych na zasadzie fire-and-forget, czyli wywołanie ich bez oczekiwania.
Poprzez brak oczekiwania, odrzucamy Task który byśmy otrzymali wraz z czekaniem na zadania.
Dlatego wyjątki wykonywane przez tą asynchroniczną funkcję są nie obsługiwane przez oryginalną funkcję.

Funkcje wykonane w ten sposób będą wykonywane w nieprzywidywalnej kolejności,
ponieważ funkcja która została wywołana może się zakończyć w dowolnym momencie podczas dalszego działania innego kodu");
        }
    }
}