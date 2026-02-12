using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_028 : IZadanie
    {
        public int ID { get; set; } = 28;
        public string Text { get; set; } = "28. Czym są pola i właściwości w klasach?  ";

        private int a = 0; // pole
        private int b { get; set; } // właściwość

        public void Execute()
        {
            Console.WriteLine(@"pole - dane które są częścią klasy np. zmienne;
zazwyczaj są prywatne i dostęp do nich jest kontrolowany przez metody lub właściwości.

właściwości - kontrolowany sposób dostępu do danych, posiada akcesory get, set;
zazwyczaj są publiczne i się odnoszą do danych zawartych w polach.");
        }
    }
}