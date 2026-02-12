using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_077 : IZadanie
    {
        public int ID { get; set; } = 77;
        public string Text { get; set; } = "77. Opisz interfejs IEnumerable<T>, jakie daje możliwości?  ";

        public class Example : IEnumerable<int>
        {
            private int[] numbers = { 1, 2, 3, 4, 5 };
            public IEnumerator<int> GetEnumerator()
            {
                foreach (var number in numbers)
                {
                    yield return number;
                }
            }
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
        public void Execute()
        {
            Console.WriteLine(@"Interfejs IEnumerable udostępnia metodę GetEnumerator(),
GetEnumerator() zwraca obiekt typu IEnumerator<T>, obiekt ten:
    - Trzyma indeks / stan.
    - Posiada metodę MoveNext(), przejdź do następnego elementu
    - Posiada właściwość Current(), aktualny element
    - Posiada metodę Reset() - powrót do początku
    - Implementuje interfejs IDisposable");
        }
    }
}