using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_109 : IZadanie
    {
        public int ID { get; set; } = 109;
        public string Text { get; set; } = "109. Wyjaśnij różnicę między Task a ValueTask.  ";
        public void Execute()
        {
            Console.WriteLine(@"ValueTask to jest rozbudowana wersja Task, jest ona przeznaczone do scenariusza kiedy metoda asynchroniczna,
zostanie wykonana synchronicznie, bez zwracania wątku, powoduje to że utworzenie obiektu Task nie jest potrzebne.

Oznacza to że Task jest deklaracją zadania które zwróciło wątek a ValueTask jest strukturą z deklaracją jego wyniku lub Task.");
        }
    }
}