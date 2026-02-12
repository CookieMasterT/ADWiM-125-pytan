using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_076 : IZadanie
    {
        public int ID { get; set; } = 76;
        public string Text { get; set; } = "76. Czym jest hashset? Jakie wymagania powinien spełniać obiekt w kolekcji?  ";
        public void Execute()
        {
            Console.WriteLine(@"Hashset to jest zestaw unikatowych wartości,
charakteryzuje się bardzo szybkim dodawaniem, usuwaniem i znajdowaniem wartości.
W przeciwieństwie do Dictionary wartości nie posiadają własnego klucza.
Z powodu hashowania i braku klucza każda wartość która jest dodana do hashset nie może być równa innej,
w przeciwnym razie wartość zostanie zgubiona

Obiekty w hashset muszą posiadać metodę Equals z IEquatable, i GetHashCode.
Hash w obiektach w hashset powinienen być stabilny - nie powinienen się zmieniać podczas ich istnienia.
Dlatego nie wolno zmieniać wartości obiektów w hashset, wtedy hash się zmieni i hashset ten obiekt zgubi.");
        }
    }
}