using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_066 : IZadanie
    {
        public int ID { get; set; } = 66;
        public string Text { get; set; } = "66. Czym jest owijanie wyjątków? Kiedy się je stosuje?  ";
        public void Execute()
        {
            Console.WriteLine(@"Owijanie wyjątków to jest utworzenie obiektu Exception wraz z parametrem InnerException.
Stosuje się to aby dodać dodatkowy kontekst do błędu który został przewidziany, bez tracenia stacktrace,
czyli dodatkowego kontekstu wynikającego z pierwotnego obiektu Exception.");
        }
    }
}