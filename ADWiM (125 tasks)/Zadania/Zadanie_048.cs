using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_048 : IZadanie
    {
        public int ID { get; set; } = 48;
        public string Text { get; set; } = "48. Czym są (i jak działają) metody i klasy zapieczętowane (sealed).  ";

        private sealed class KlasaZapieczętowana { }

        //private class KlasaPochodna : KlasaZapieczętowana { } // nie można dziedziczyć po klasie zapieczętowanej

        private class KlasaBazowa
        {
            // public sealed void MetodaZapieczętowana() { } // nie można zapieczętować metody która nie jest nadpisem
            public virtual void Metoda() { }
        }
        private class KlasaPochodna : KlasaBazowa
        {
            public sealed override void Metoda() { }
        }

        private class PochodnaPochodna : KlasaPochodna
        {
            // public override void Metoda() { } // nie można nadpisać zapieczętowanej metody
        }

        public void Execute()
        {
            Console.WriteLine(@"Sealed to jest oznaczenie które zatrzymuje dalsze dziedziczenie, w przypadkach gdyby to było by bez sensu.
Dowolną klasę można oznaczyć jako sealed, co zatrzymuje dziedziczenie po niej.

Można również oznaczyć metodę nadpisującą (sł. kl. override) jako sealed,
powoduje to że nie będzie się mogło jej nadpisać w dalszych klasach pochodnych.

Normalnych metod (innych niż nadpisujących) nie można zapieczętować");
        }
    }
}