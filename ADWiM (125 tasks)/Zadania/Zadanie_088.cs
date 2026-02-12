using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_088 : IZadanie
    {
        public int ID { get; set; } = 88;
        public string Text { get; set; } = "88. Czym są zdarzenia? Jak się je definiuje?  ";
        public void Execute()
        {
            Console.WriteLine(@"Zdarzenia to specjalny typ który ma za zadanie przechować tablicę delegat.
Najważniesza metoda którą udostępnia to jest Invoke( [parametry do delegaty] ),
powoduje ona wywołanie wszystkich delegat które zasubskrybowały do event.

Event udostępnia operator do subskrypcji i odsubskrypcji += i -=.

Definiuje się zdarzenia według:
[modifikacje] event [delegat] [nazwa]
czyli np.:
public event Action<int> MyDelegate.");
        }
    }
}