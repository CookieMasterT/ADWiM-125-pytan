using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_082 : IZadanie
    {
        public int ID { get; set; } = 82;
        public string Text { get; set; } = "82. Jak stworzyć własną kolekcję w C#? Szczegółowy opis implementacji interfejsu IEnumerable<T>.  ";

        private class MyOwnCollection<T> : IEnumerable<T>
        {
            private T[]? items;

            public T this[int index]
            {
                get { return items[index]; }
                set { items[index] = value; }
            }

            private System.Collections.Generic.IEnumerator<T> GetEnumeratorImpl()
            {
                for (int i = 0; i < items.Length; i++)
                {
                    yield return items[i];
                }
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return GetEnumeratorImpl();    
            }
            System.Collections.Generic.IEnumerator<T> IEnumerable<T>.GetEnumerator()
            {
                return GetEnumeratorImpl();
            }
        }

        public void Execute()
        {
            Console.WriteLine(@"Aby stworzyć własną kolekcję według IEnumerable<T> trzeba:
    - Nadpisać właściwość this, aby pozwolić na normalne odzyskanie wartości
    - Zaimplementować interfejs poprzez zadeklarowanie IEnumerable.GetEnumerator() z typem zwracanym Inumerator.
    - Zrobić to samo drugi raz ale z typem generycznym (dodać <T>)
    - IEnumerator powinienen:
        - Mieć metodę MoveNext(), która przesuwa stan na następny element kolekcji i zwraca bool czy się udało.
        - Mieć metodę Reset(), która ustawia stan na początek kolekcji.
        - Mieć właściwość Current, która przekazuję wartość według stanu
        - Implementować interfejs IDisposable.");
        }
    }
}