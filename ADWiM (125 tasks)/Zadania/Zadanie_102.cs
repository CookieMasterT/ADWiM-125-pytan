using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_102 : IZadanie
    {
        public int ID { get; set; } = 102;
        public string Text { get; set; } = "102. Opisz różnicę między zadaniami ciężkimi obliczeniowymi a zadaniami I/O.  ";
        public void Execute()
        {
            Console.WriteLine(@"Zadania cięzkie obliczeniowo to takie, które zajmują dużą ilość surowców lokalnych,
czyli powodują że komputer użytkownika jest zajęty.

Zadania I/O (Input / Output) to są zadania która charakteryzują się odwołaniem do zewnętrznego źródła,
Komputer w tym czasie nie jest zajęty, ale musi poczekać na odpowiedź.");
        }
    }
}