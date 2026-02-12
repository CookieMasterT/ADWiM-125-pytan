using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_074 : IZadanie
    {
        public int ID { get; set; } = 74;
        public string Text { get; set; } = "74. Czym jest pojemność (capacity) listy? Jak działa?  ";

        public void Execute()
        {
            List<int> numbers = new List<int>(5);

            for (int i = 0; i < 20; i++)
            {
                numbers.Add(i);
                Console.WriteLine($"Size: {numbers.Count}, Capacity: {numbers.Capacity}");
            }
            
            Console.WriteLine();

            Console.WriteLine(@"Ponieważ lista wewnętrznie operuje na tablicach, ta tablica ma własną wielkość.
Wielkość tej tablicy to jest capacity, jest to inna właściwość niż count listy, czyli aktualna ilość elementów.

Kiedy spróbuje się dodać do listy nowy element, i nie może się on zmieścić w tablicy, pojemność jest podwajana,
a elementy zawarte w starej tablicy, są przemieszczane do nowej.)");
        }
    }
}