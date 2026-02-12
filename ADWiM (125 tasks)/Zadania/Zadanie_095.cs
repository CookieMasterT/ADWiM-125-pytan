using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_095 : IZadanie
    {
        public int ID { get; set; } = 95;
        public string Text { get; set; } = "95. Wymień i opisz podstawowe operatory LINQ – Where, Select, OrderBy, ThenBy, GroupBy, Distinct.  ";
        // wymień ???
        public void Execute()
        {
            Console.WriteLine(@"Podstawowe operatory LINQ to:
    - Where, przyjmuje delegatę Func<T, bool> (Predicate). wybiera elementy które spełniają warunek.
    - Select, przyjmuję delegatę Func<T, TResult>. Zmienia każdy element w coś innego.
    - OrderBy, przyjmuję delegatę Func<TSource, TKey>, która przekazuję źródło informacji
    i klucz który będzie przyrównywany podczas sortowania. Operator ten zmiena IEnumerable na IOrderedEnumerable.
    - ThenBy, To samo co OrderBy ale sortuje elementy które mają taką samą wartość według OrderBy.
    - GroupBy, Przyjmuję Func<Tsource, Tkey>, zwraca zestaw grup podzielonych według klucza
    (Jeżeli kilka elementów ma ten sam klucz to należą do jednej grupy).
    - Distinct, Może przyjąć IEqualityComparer<T> zwraca unikatowe elementy.");
        }
    }
}