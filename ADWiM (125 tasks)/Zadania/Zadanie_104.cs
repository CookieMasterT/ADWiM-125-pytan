using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_104 : IZadanie
    {
        public int ID { get; set; } = 104;
        public string Text { get; set; } = "104. Czym jest asynchroniczność? Wyjaśnij jak działa.  ";
        public void Execute()
        {
            Console.WriteLine(@"Asynchroniczność to jest działanie wielu elementów nie zależnie od siebie.
W wątku powoduje że operację które są nie blokujące, czyli nie wymagają aktywnej pracy, pozwalają na dokonywanie innych czynności.

Asynchroniczność działa poprzez zarejestrowanie zadania które będzie potem wykonane, przejście do innej pracy,
a potem powrócenie do tego zadania kiedy już się w pełni wykona.");
        }
    }
}