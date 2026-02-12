using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_009 : IZadanie
    {
        public int ID { get; set; } = 9;
        public string Text { get; set; } = "9. Czym się różni stos i sterta? Jakie dane przechowują te mechanizmy w .NET.  ";
        public void Execute()
        {
            Console.WriteLine(@"Stos (stack) to szybki magazyn dla danych tymczasowych (parametry metod, zmienne lokalne)
używa on LIFO last in first out

Sterta (heap) to magazyn obiektów dynamicznych (obiekty, klasy)
dane są w nim przechowywane dopóki istnieje do nich referencja,
a po tym są zbierane przez garbage collector.");
        }
    }
}