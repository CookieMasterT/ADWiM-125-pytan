using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_014 : IZadanie
    {
        public int ID { get; set; } = 14;
        public string Text { get; set; } = "14. Opisz rolę przestrzeni nazw – czym są, do czego służą?  ";
        public void Execute()
        {
            Console.WriteLine(@"Przestrzenie nazw pozwalają na deklarację ugrupowania powiązanych obiektów (np. zadeklarowanych klas, intefejsów etc.)
Służą do organizacji dużych projektów i zapobiegają kolizji nazw
(kilka obiektów może mieć tą samą nazwę, ale dzięki przestrzeni nazw są one oddzielone od siebie)");
        }
    }
}