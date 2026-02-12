using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_062 : IZadanie
    {
        public int ID { get; set; } = 62;
        public string Text { get; set; } = "62. Opisz w jaki sposób działa blok finally.  ";
        public void Execute()
        {
            Console.WriteLine(@"Blok finally to jest blok który może się znaleźć po bloku try catch.
Zostanie on zawsze wykonany po dowolnym wyjściu z bloku,
nawet jeżeli blok będzie miał nie obsłużony wyjątek lub wyjdzie z zakresu poprzez return;");
        }
    }
}