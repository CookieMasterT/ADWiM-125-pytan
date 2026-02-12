using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_080 : IZadanie
    {
        public int ID { get; set; } = 80;
        public string Text { get; set; } = "80. Opisz różnicę między break i yield break – specjalna dedykacja dla Filipa.  ";
        private class Example : IEnumerable<int>
        {
            private int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            public IEnumerator<int> GetEnumerator()
            {
                foreach (var number in numbers)
                {
                    if (number > 5)
                       break;
                    yield return number;
                }
                yield return 100; // gdyby było yield break zamiast break, to ten kod by się nie wykonał
            }
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public void Execute()
        {
            Example example = new Example();
            foreach (var num in example)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(@"Break to jest wyjście z pętli obejmującej,
ta instrukcja powoduje wyjście z najbardziej wewnętrznej pętli do, while, for, foreach.

Yield break to jest zakończenie iteracji, ustawia ono enumerator.GetNext() na null co powoduje że kończy się enumeracja.

Mimo tego że jeżeli się zaimplementuje IEnumerator używając np. pętli foreach to będą miały w tym samym miejscu, ten sam efekt,
to yield break wyjdzie z enumeracji, a break by wykonało kod który by mógł się znaleźć po pętli wewnętrznej.");
        }
    }
}