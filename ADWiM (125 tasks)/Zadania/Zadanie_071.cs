using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_071 : IZadanie
    {
        public int ID { get; set; } = 71;
        public string Text { get; set; } = "71. Opisz sens tworzenia własnych typów wyjątków.  ";

        class DidNotStudyEnoughException : Exception
        {
            public DidNotStudyEnoughException() : base("You did not read this slowly enough, to catch all the details and know whats going on")
            {
            }
        }

        public void Execute()
        {
            Console.WriteLine(@"Tworzy się własne wyjątki kiedy wyjątki już istniejące, nie są w stanie opisać sensu problemu.
Pozwala to na dodanie dodatkowego kontekstu do wyrzuconego wyjątku.

Używa się tego najczęściej w problemach wynikających z logikii domenowej, kiedy operacja jest dokonana poprawnie,
ale nie można jej wykonać z powodu logikii domenowej.
Pozwala to programiście dokładnie zrozumieć problem, a do wyjątku można również dodać dodatkowe informację (pola i właściwości)");
        }
    }
}