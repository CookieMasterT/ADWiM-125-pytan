using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_064 : IZadanie
    {
        public int ID { get; set; } = 64;
        public string Text { get; set; } = "64. Jaki jest wpływ występowania wyjątków na wydajność programu?  ";
        public void Execute()
        {
            Console.WriteLine(@"Wyjątki wyłapywane poprzez blok try catch drastycznie spowalniają program,
W najgorszym wypadku powodują że program może funkcjonować nawet 250-275 razy wolniej.");
        }
    }
}