using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_098 : IZadanie
    {
        public int ID { get; set; } = 98;
        public string Text { get; set; } = "98. Opisz różnicę między IEnumerable<T> i IQueryable<T>.  ";
        public void Execute()
        {
            Console.WriteLine(@"IEnumerable<T> Polega na udostępnieniu enumeratora do danego zestawu danych.
IQueryable<T> jednak działa w kontekście baz danych, często nie zawartych w c# i jest warstwą tłumaczenia.

Mimo tego że na obu rzeczach można wywoływać zapytania np. do LINQ to IEnumerable to jest dostęp do tablicy
a IQueryable to dostęp do bazy danych");
        }
    }
}