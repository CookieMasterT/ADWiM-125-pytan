using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_047 : IZadanie
    {
        public int ID { get; set; } = 47;
        public string Text { get; set; } = "47. Czym są metody abstrakcyjne?  ";

        private class Przykład()
        {
            // public abstract void A(); // nie można mieć metody abstrakcyjne w klasach nieabstrakcyjnych
        }

        private abstract class Zwierzę()
        {
            public abstract void Ukradnij();
        }

        public void Execute()
        {
            Console.WriteLine(@"Metody abstrakcyjne to są metody które mogą zostać zadeklarowane wyłącznie w klasach abstrakcyjnych.
Metody abstrakcyjne nie mogą mieć bezpośrednio zdefiniowanej implementacji, mogą one jedynie zostać nadpisane przez klasę pochodną.

Metody abstrakcyjne są wyłącznie informacją szablonu, o potrzebie utworzenia danej metody w przypadku dziedziczenia.");
        }
    }
}