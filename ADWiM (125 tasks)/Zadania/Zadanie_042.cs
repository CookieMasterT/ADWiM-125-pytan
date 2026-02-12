using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_042 : IZadanie
    {
        public int ID { get; set; } = 42;
        public string Text { get; set; } = "42. Czym jest polimorfizm? Jak działa?  ";
        public void Execute()
        {
            Console.WriteLine(@"Polimorfizm pozwala na traktowanie obiektów klas dziedziczących tak samo jak ich rodzice.
Pozwala to na używanie danej rzeczy np. zwierzęcia, bez wiedzy czy jest to np. kot czy pies.
(Mimo tego że operujemy na klasie bazowej, są wykonywane metody specyficzne dla danych wyspecjalizowanych klas.)");
        }
    }
}