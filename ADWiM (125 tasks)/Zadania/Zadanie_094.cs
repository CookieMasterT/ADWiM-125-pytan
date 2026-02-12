using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_094 : IZadanie
    {
        public int ID { get; set; } = 94;
        public string Text { get; set; } = "94. Czym jest LINQ? (style, zastosowania, kiedy możliwe jest jego użycie?)  ";
        public void Execute()
        {
            Console.WriteLine(@"LINQ (Language INtegrated Query) to jest system zapytań w C#.
Zachowuje on się podobnie do SQL, ale działa bezpośrednio w C#.
Pozwala on na zaawansowane filtrowanie, sortowanie i grupowanie danych.

LINQ posiada 2 style:
    - Metodowy:
        numbers
        .Where(n => n > 5)
        .Select(n => n);
    - Zapytaniowy:
        from n in numbers
        where n > 5
        select n
Można go używać na obiektach które implementują interfejs IEnumerable<T>");
        }
    }
}