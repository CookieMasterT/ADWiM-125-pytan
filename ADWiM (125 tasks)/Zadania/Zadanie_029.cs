using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_029 : IZadanie
    {
        public int ID { get; set; } = 29;
        public string Text { get; set; } = "29. Czym jest (jak działa?) konstruktor klasy?  ";
        public void Execute()
        {
            Przyklad p = new Przyklad(5, "test");

            Console.WriteLine(@"Konstruktor klasy jest wywoływany przy alokacji obiektu na stercie (czyli podczas tworzenia obiektu).
Jest to metoda o tej samej nazwie co klasa, nie może ona mieć typu zwracanego, ale może ona mieć parametry i być przeciążana.

Metoda ta jest odpowiedzialna za wykonanie wszystkich czynności które powinny być dokonane przed użytkiem instancji klasy
(wywoływanie metod, dependency injection, przypisywanie zmiennych, wywoływanie innych funkcji etc.)

Istnieje kilka typów konstruktorów klasy:
    - Konstruktor domyślny (często generowany automatycznie).
    - Konstruktor parametrowy, pozwala na elastyczną inicjalizacje instancji klasy.
    - Konstruktor statyczny, wywoływany przy pierwszym użyciu danej klasy.");
        }

        private class Przyklad
        {
            // Konstruktor klasy
            public Przyklad(int a, string b)
            {
                this.a = a;
                this.b = b;
            }
            private int a;
            private string b;
        }
        private class Przykład2()
        {
            private int a;
        }
    }
}