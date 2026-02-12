using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_060 : IZadanie
    {
        public int ID { get; set; } = 60;
        public string Text { get; set; } = "60. Czym są wyjątki?  ";
        public void Execute()
        {
            Console.WriteLine(@"Wyjątki to są błedy w programie które nie pozwalają na jego dalszą pracę.
Powstają kiedy kod napotka sytuację której nie jest w stanie obsłużyć, lub są wywoływane ręcznie.

Wyjątki składają się z trzech części:
    1. Typ, np. NullReferenceException
    2. Komunikat - Wygenerowany przez środowisko lub napisany przez programistę opis problemu.
    3. StackTrace - Lista wywołanych funkcji które doprowadziły do błędu.");
        }
    }
}