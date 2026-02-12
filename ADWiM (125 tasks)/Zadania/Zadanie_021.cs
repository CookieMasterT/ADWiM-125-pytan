using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_021 : IZadanie
    {
        public int ID { get; set; } = 21;
        public string Text { get; set; } = "21. Czym jest obiekt?  ";
        public void Execute()
        {
            Console.WriteLine(@"Obiekt to jest instancja klasy lub struktury, reprezentuje on pamięć w programie.
Każdy obiekt ma swoje zachowanie (metody) i dane (pola lub właściwości)");
        }
    }
}