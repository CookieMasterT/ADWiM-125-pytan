using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_110 : IZadanie
    {
        public int ID { get; set; } = 110;
        public string Text { get; set; } = "110. Opisz różne strategie używania await.  ";
        // ??? what do they want to be said here ???
        public void Execute()
        {
            Console.WriteLine(@"Strategie używania await to:
    - Użycie await aby wykonać pojedyńcze zadanie w celu zwolnienia wątku, a potem wracasz do niego.
    - Wywołanie wielu asynchronicznych zadań równolegle do siebie.
    - Delegowanie zadań w ważnych wątkach np. UI używając await.");
        }
    }
}