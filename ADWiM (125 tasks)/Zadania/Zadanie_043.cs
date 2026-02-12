using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_043 : IZadanie
    {
        public int ID { get; set; } = 43;
        public string Text { get; set; } = "43. Czym jest przesłanianie (shadowing)? Jak działa?  ";

        private class KlasaBazowa
        {
            public void Metoda()
            {
                Console.WriteLine("Metoda z klasy bazowej");
            }
        }
        private class KlasaPochodna : KlasaBazowa
        {
            public new void Metoda()
            {
                Console.WriteLine("Metoda z klasy pochodnej");
            }
            public void WywolajMetodeBazowa()
            {
                base.Metoda();
            }
        }

        public void Execute()
        {
            KlasaPochodna KP = new KlasaPochodna();
            KP.Metoda();
            KP.WywolajMetodeBazowa();

            Console.WriteLine();

            Console.WriteLine(@"Przesłanianie to jest utworzenie przez klasę pochodną pola, właściwości lub metody, o tej samej nazwie
Ukrywa on wtedy metode, czyli podczas wywołania jej na klasie pochodnej, zostanie wywołana nowa,
ale jej nie nadpisuje (może nadal być użyte z słowem kluczowym base)");
        }
    }
}