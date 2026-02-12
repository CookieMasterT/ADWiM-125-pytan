using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_058 : IZadanie
    {
        public int ID { get; set; } = 58;
        public string Text { get; set; } = "58. Podaj rolę interfejsu IDisposable. Jakie możliwości dostarcza jego implementacja?  ";
        public void Execute()
        {
            Console.WriteLine(@"Interfejs IDisposable Pozwala na ręczne zwalnianie zasobów niezarządzanych. Bez czekania na Garbage Collector.
Metoda Dispose() wymagana przez interfejs jest automatycznie wywołana po zakończeniu bloku w ktorym jest użyte słowo kluczowe using.");
        }
    }
}