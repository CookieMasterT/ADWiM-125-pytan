using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_081 : IZadanie
    {
        public int ID { get; set; } = 81;
        public string Text { get; set; } = "81. Zasady tworzenia metod umożliwiających odroczone wykonanie.  ";
        public void Execute()
        {
            Console.WriteLine(@"Zasady i najlepsze praktyki to:
    - Powinno być udostępniony IEnumerator najczęściej poprzez intefejs IEnumerable.
    - Enumeracja powinna używać yield return do zwracania kolejnych elementów.
    - Każde yield return powinno zwrócić pojedyńczą wartość.
    - Powinno się unikać kodu blokującego w iteratorze");
        }
    }
}