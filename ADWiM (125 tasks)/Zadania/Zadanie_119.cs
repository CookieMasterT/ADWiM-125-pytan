using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_119 : IZadanie
    {
        public int ID { get; set; } = 119;
        public string Text { get; set; } = "119. Czym jest Parallel LINQ? Kiedy warto z niego skorzystać?  ";
        public void Execute()
        {
            Console.WriteLine(@"Parallel LINQ (PLINQ) to jest rozserzenie klasycznego LINQ które polega na dodaniu równoległości.
Po użyciu zapytania LINQ wraz z AsParallel() reszta zapytania jest wykonywana z wykorzystaniem ThreadPool i wielu rdzeni. ");
        }
    }
}