using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_070 : IZadanie
    {
        public int ID { get; set; } = 70;
        public string Text { get; set; } = "70. Czym jest połykanie wyjątków?  ";
        public void Execute()
        {
            Console.WriteLine(@"Jest to try catch, bez znaczącego kodu w bloku catch.
Oznacza to że wywołany przez program błąd jest usuwany, nie jest wyrzucany, wypisany lub zalogowany.

Powoduje to problemy z debuggingiem i błędy których nie można znaleźć ani obsłużyć.");
        }
    }
}