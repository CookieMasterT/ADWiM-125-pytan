using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_099 : IZadanie
    {
        public int ID { get; set; } = 99;
        public string Text { get; set; } = "99. Jak działa tłumaczenie LINQ na SQL? Czym są operacje nietłumaczalne?  ";
        public void Execute()
        {
            Console.WriteLine(@"Aby przetłumaczyć zapytanie LINQ na SQL,
IQueryable zbiera operacje i według nich buduje expression tree które reprezentuje zapytanie.
Następnie expression tree jest przekazywane do dostawcy usług, i tam jest tłumaczone na SQL.

Operację nietłumaczalne to są operacje których nie można przetłumaczyć na kod SQL.
Na przykład nie można przetłumaczyć metody która jest zadeklarowana w kodzie, SQL nie jest w stanie tego wykonać.");
        }
    }
}