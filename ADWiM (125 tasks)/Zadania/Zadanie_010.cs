using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_010 : IZadanie
    {
        public int ID { get; set; } = 10;
        public string Text { get; set; } = "10. Czym jest i jak działa Garbage Collector?  ";
        public void Execute()
        {
            Console.WriteLine(@"Garbage Collector to mechanizm służący do automatycznego zwalniania nieużywanej pamięci.
Pozwala on zapomnieć o ręcznym zwalnianiu pamięci (jak to się robiło w c++) i zmniejsza ryzyko memory leak.

Jest on automatyczny (nie musi być inicjowany lub wywoływany przez kod programu) i działa w tle.
Nie powoduje on ryzyka usunięcia wartości używanych przez program.
Działa poprzez mierzenie wieku obiektów, i ilości odniesień do nich.
(np. usuwa on obiekt z sterty kiedy nie istnieją już żadne referencje do niego).");
        }
    }
}