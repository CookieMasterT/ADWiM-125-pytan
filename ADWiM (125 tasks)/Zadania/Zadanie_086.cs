using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_086 : IZadanie
    {
        public int ID { get; set; } = 86;
        public string Text { get; set; } = "86. Jaką rolę pełnią funkcje anonimowe? Kiedy warto z nich skorzystać?  ";
        public void Execute()
        {
            Console.WriteLine(@"Funkcja anonimowa to jest funkcja bez nazwy.
Używa się je kiedy chce się nadać wartość delegacie, wtedy można pominąć nadanie nazwy funkcji
i można pominąć tworzenie funkcji pomocniczej tylko aby móc ją przekazać");
        }
    }
}