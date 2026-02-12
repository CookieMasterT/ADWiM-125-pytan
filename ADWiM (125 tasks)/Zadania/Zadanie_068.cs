using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_068 : IZadanie
    {
        public int ID { get; set; } = 68;
        public string Text { get; set; } = "68. Wyjaśnij różnicę między throw a throw ex.  ";
        public void Execute()
        {
            Console.WriteLine(@"Wyrzucenie wyjątku który jest wyłapany poprzez try catch, utworzy nowy wyjątek bez stacktrace.
Dlatego wyrzucenie wyjątku z try catch poprzez throw ex utraci stacktrace, jest tworzony nowy stacktrace zamiast użycia starego.

Wyrzucenie bez argumentowe throw, wywoła wyjątek bez tworzenia nowego obiektu, spowoduje to że system automatycznie
uwzględni w stacktrace wszystkie poprzednie wyjątki.");
        }
    }
}