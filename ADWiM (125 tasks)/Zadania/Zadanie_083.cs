using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_083 : IZadanie
    {
        public int ID { get; set; } = 83;
        public string Text { get; set; } = "83. Jak dodać obsługę indeksatora do własnej kolekcji?  ";
        private class MyOwnCollection<T>
        {
            private T[]? items;

            public T this[int index]
            {
                get { return items[index]; }
                set { items[index] = value; }
            }
        }

        public void Execute()
        {
            Console.WriteLine(@"Trzeba nadpisać właściwość this[int index];
Wtedy po deklaracji (typ dowolny powinienen odpowiadać typu w tablicy lub typu generycznemu), można nadpisać get; set;");
        }
    }
}