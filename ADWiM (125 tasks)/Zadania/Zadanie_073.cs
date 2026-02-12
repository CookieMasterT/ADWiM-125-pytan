using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_073 : IZadanie
    {
        public int ID { get; set; } = 73;
        public string Text { get; set; } = "73. Czym jest typ generyczny? Jakie są jego zalety i jakie daje możliwości?  ";
        public class Container<T>
        {
            public required T Item { get; set; }
        }

        public void Execute()
        {
            Container<int> intContainer = new Container<int> { Item = 10 };
            Container<string> stringContainer = new Container<string> { Item = "Hello" };

            Console.WriteLine(@"Typ generyczny to mechanizm który pozwala na tworzenie klas, metod, interfejsów i struktur,
w których typ danych jest podawany jako parametr w momencie ich użycia.

Pozwala to na utworzenie uniwersalnego szablonu kodu, w kontekstach gdzie typ ma mniejsze znaczenie.
Wyznaczanie typu poprzez typ generyczny uelastycznia kod, i pozwala na mniejszą redundancję np. w tworzeniu tablic.");
        }
    }
}