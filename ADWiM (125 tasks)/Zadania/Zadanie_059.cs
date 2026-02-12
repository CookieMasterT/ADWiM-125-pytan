using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_059 : IZadanie
    {
        public int ID { get; set; } = 59;
        public string Text { get; set; } = "59. Kiedy korzystamy (kiedy można) z bloku using? (using var a = new …())  ";
        public void Execute()
        {
            Console.WriteLine(@"Using w formie powyżej służy do automatycznego wywołania metody Dispose() z interfejsu IDisposable()
Dokonane to jest po zakończeniu bloku w którym jest zawarty using, lub który using deklaruje.
    - Using [...] {}
    - { Using [...] [kod] }
Using dokonuje zwalnianie pamięci nawet jeżeli wystąpi wyjątek.");
        }
    }
}