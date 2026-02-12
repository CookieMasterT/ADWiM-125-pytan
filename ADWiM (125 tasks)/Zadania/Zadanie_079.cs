using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_079 : IZadanie
    {
        public int ID { get; set; } = 79;
        public string Text { get; set; } = "79. Czym jest i jak działa wykonanie odroczone?  ";
        public void Execute()
        {
            Console.WriteLine(@"Wykonanie odroczone - yield return, pozwala zwykłej metodzie zachowywać się jak kolekcja.
Jest to wykonanie odroczone, oznacza to że po zwróceniu elementu, kod będzie kontynuowany,
dopiero kiedy zostanie poproszony o następny element.");
        }
    }
}