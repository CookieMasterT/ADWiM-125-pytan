using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_085 : IZadanie
    {
        public int ID { get; set; } = 85;
        public string Text { get; set; } = "85. Wymień oraz opisz podstawowe delegaty predefiniowane – Action, Func, Predicate.  ";
        public void Execute()
        {
            Console.WriteLine(@"Action<T1, [...] T16> - Funkcja typu void, posiada od 0 do 16 parametrów.
Func<T1, [...], T16, TResult> - przyjmuje od 0 do 16 parametrów, a potem zwraca TResult.
Predicate<T, bool> - przyjmuje 1 parametr, i zwraca bool.");
        }
    }
}