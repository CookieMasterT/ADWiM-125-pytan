using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_106 : IZadanie
    {
        public int ID { get; set; } = 106;
        public string Text { get; set; } = "106. Czym jest Task?  ";
        public void Execute()
        {
            Console.WriteLine(@"Task to jest reprezentacja zadania które zostało przeznaczone do asynchronicznego wykonania.
Ponieważ podczas zwalniania wątku trzeba posiadać odwołanie do niego, aby móc powrócić po jego ukończeniu,
to istnieje klasa Task, reprezentująca te odwołanie.

Posiada on właściwości zawierające status wykonywanego zadania i dodatkowe informację na temat sposobu jego utworzenia.
Implementuję interfejs IAsyncResult i IDisposable.

Task może być zadeklarowany z typem z funkcji, jest to informacja że funkcja asynchroniczna po swoim wykonaniu,
zwróci zmienną o danym typie, jest to typ zwracany funkcji przekazany w Task.");
        }
    }
}