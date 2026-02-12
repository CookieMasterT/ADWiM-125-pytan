using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_113 : IZadanie
    {
        public int ID { get; set; } = 113;
        public string Text { get; set; } = "113. Opisz strategię anulowania operacji asynchronicznych – CancellationToken.  ";
        public void Execute()
        {
            Console.WriteLine(@"CancellationToken to jest token który może być przekazany funkcją asynchronicznym,
w celu kontrolowanego przerwania ich działania.
Funkcja asynchroniczna która posiada CancellationToken jest gotowa na zostanie przerwanym.

Metoda Cancel() potem przerywa działanie odpowiednich funkcji asynchronicznych.");
        }
    }
}