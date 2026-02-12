using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_108 : IZadanie
    {
        public int ID { get; set; } = 108;
        public string Text { get; set; } = "108. Dlaczego metody asynchroniczne muszą zwrócić wynik opakowany w Task<T>?  ";
        public void Execute()
        {
            Console.WriteLine(@"Ponieważ metody asynchroniczne udostępniają wartość swojego typu zwracanego po zakończeniu zadania, i muszą zwrócić Task,
to wynik wykonania metody asynchronicznej musi znaleźć się w tym samym miejscu co informacja o jego dostępności.
Dlatego używa się Task<T>, który poprzez typ generyczny może przechować miejsce na przyszłą zmienną.");
        }
    }
}