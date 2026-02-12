using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_100 : IZadanie
    {
        public int ID { get; set; } = 100;
        public string Text { get; set; } = "100. Czym jest wątek programu?  ";
        public void Execute()
        {
            Console.WriteLine(@"Wątek programu to jest najmniejsza jednostka robocza, czyli pojedyńcze zadanie wykonujące czynności.
Program może mieć dowolną ilość wątków, ale zawsze będzie działał na conajmniej jednym wątku głównym.

Wątek możę wykonywać zadania jeden po drugim, nie może samodzielnie wykonywać kilku czynności naraz.

Wątek rózni się od procesu tym, że kilka wątków w jednym programie działa w tej samej sferze.");
        }
    }
}