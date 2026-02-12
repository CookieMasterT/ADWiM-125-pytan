using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_120 : IZadanie
    {
        public int ID { get; set; } = 120;
        public string Text { get; set; } = "120. Czym jest stopień równoległości?  ";
        public void Execute()
        {
            Console.WriteLine(@"Stopień równoległości to jest właściwość która opisuje ile wątków równocześnie może wykonywać dane zadania.
Domyślnie aby zapewnić najszybsze wykonanie zadania, używana jest maksymalna ilość wątków ale można to ograniczyć np. aby nie obciążyć całego systemu.");
        }
    }
}