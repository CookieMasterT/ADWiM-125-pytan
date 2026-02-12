using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_000 : IZadanie
    {
        public int ID { get; set; } = 0;
        public string Text { get; set; } = "0. Zacznij się uczyć";
        public void Execute()
        {
            Console.WriteLine("Funktioniert richtig");
        }
    }
}
