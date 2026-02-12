using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_019 : IZadanie
    {
        public int ID { get; set; } = 19;
        public string Text { get; set; } = "19. Opisz działanie słowa kluczowego when w instrukcji switch.  ";
        public void Execute()
        {
            Console.WriteLine(@"słowo kluczowe when w instrukcji switch używa się aby sprawdzić dodatkowy warunek.
Można go użyc aby przypisać zmienną przekazaną do switch
do zmiennej tymczasowej aby móc na niej wykonywać bardziej skomplikowane operacje logiczne np.:
case int n when n > 5 && n < 10
Lub aby dokonac operacje logiczną na kilku parametrach przekazanych do switch np.:
case (>0, >0) when a == b:");
        }
    }
}