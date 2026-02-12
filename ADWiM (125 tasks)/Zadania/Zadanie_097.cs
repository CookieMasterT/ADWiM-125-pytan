using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_097 : IZadanie
    {
        public int ID { get; set; } = 97;
        public string Text { get; set; } = "97. Do czego służy interfejs IQueryable<T> - na jakich źródłach danych operuje, w jaki sposób?  ";
        public void Execute()
        {
            Console.WriteLine(@"Interfejs IQueryable operuje na zewnętrznych źródłach danych, dostępnych poprzez zewnętrznego operatora.
Tłumaczy on zapytanie LINQ na expression tree które potem jest przez dostawcę usług,
tłumaczone na odpowiednie zapytanie i zwracane jako wynik do aplikacji.");
        }
    }
}