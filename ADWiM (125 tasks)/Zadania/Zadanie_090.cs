using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_090 : IZadanie
    {
        public int ID { get; set; } = 90;
        public string Text { get; set; } = "90. Opisz ryzyko wycieków pamięci w C# przy korzystaniu z mechanizmu zdarzeń.  ";
        public void Execute()
        {
            Console.WriteLine(@"Ponieważ Garbage Collector usuwa dane na stosie tylko kiedy przestanie istnieć do nich referencja,
a event, trzyma referencje do każdej delegaty która do niego zasubskrybuje, to przy zapomnieniu o usunięciu referencji z event,
dojdzie do wycieku pamięci (trzymanie przez program bezużytecznych informacji przez nieskończony czas).");
        }
    }
}