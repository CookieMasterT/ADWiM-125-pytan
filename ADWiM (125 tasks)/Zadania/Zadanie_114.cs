using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_114 : IZadanie
    {
        public int ID { get; set; } = 114;
        public string Text { get; set; } = "114. Czym jest przetwarzanie równoległe?  ";
        public void Execute()
        {
            Console.WriteLine(@"Przetwarzanie równoległe to jest jednoczesne wykonywanie zadań na wielu wątkach.
Ponieważ processor fizycznie posiada wiele rdzeni, to utworzenie wielu wątków pozwoli na szybsze działania.

Najczęściej jest ta strategia używana przy ciężkich operacjach (szyfrowanie, kompresja, rendering)");
        }
    }
}