using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_089 : IZadanie
    {
        public int ID { get; set; } = 89;
        public string Text { get; set; } = "89. Opisz znaczenie i potencjalne zastosowania delegaty EventHandler.  ";

        public event EventHandler MyEvent;

        public void Execute()
        {
            var A = (int x, object sender) => Console.WriteLine($"Delegate A with x = '{x}' Invoked by {sender}");
            Action<int> B = (x) => Console.WriteLine($"Delegate B x = '{x}'");

            MyEvent += (sender, e) => A(2, sender);
            MyEvent += (sender, e) => B(3);

            MyEvent?.Invoke(this, EventArgs.Empty);

            Console.WriteLine(@"EventHandler to standardowy delegat (jak Func, Action, Predicate),
zaprojektowany do obsługi zdarzeń (przeznaczony jest do przekazania w Event.)

Zawiera on 2 argumenty:
    - object? sender, który powinienen przechowywać informację o nadawcy.
    - EventArgs e, czyli instancja klasy EventArgs, lub obiekt po tej klasie dziedziczący.

EventHandler istnieje aby mieć jednolitą strukturę wydarzeń w dużych projektach.");
        }
    }
}