using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_065 : IZadanie
    {
        public int ID { get; set; } = 65;
        public string Text { get; set; } = "65. Opisz obiekt Exception – wymień i opisz jego najważniejsze właściwości (Message, StackTrace, InnerException).  ";
        public void Execute()
        {
            Exception exception = new Exception();

            Console.WriteLine(@"Obiekt exception jest obiektem przeznaczonym do przechowywania wiadomości o wyjątkach,
wywoływany jest w przypadku krytycznego błedu, Zawiera wiele właściwości, najważniejsze z nich to:
    - Message, opis błędu, często z dodatkową informacją o jego potencjalnych źródłach
    - StackTrace, ścieżka wywołań które doprowadziły do wyjątku - dodatkowy kontekst
    - InnerException, Wyjątek źródłowy, jeżeli jeden wyjątek wynika z innego (np. został wywołany podczas obsługi wyjątku)");
        }
    }
}