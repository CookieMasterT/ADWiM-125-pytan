using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_107 : IZadanie
    {
        public int ID { get; set; } = 107;
        public string Text { get; set; } = "107. Czym jest async void? Dlaczego nie powinniśmy go stosować, kiedy jest on dopuszczalny?  ";

        private class Example
        {
            public async void Run()
            {
                await Task.Delay(10000);
            }
        }

        public void Execute()
        {
            Example a = new Example();
            // await a.Run(); // Cannot await 'void'

            Console.WriteLine(@"Async void to jest funkcja asynchroniczna która zamiast zwracać Task który nie ma deklaracji typu zwracanego, nie zwraca żadnej informacji.
Powoduje to że odwołanie które pozwala na oczekiwanie na wykonanie zadanie, i połączenie tego wykonywania z resztą kodu, nie istnieje.

Skutkiem ubocznym tego jest że nie da się oczekiwać (await) na async void, a wyjątki nie mogą zostać obsłużone przez kod który async void wykonał.
Nie powinno się stosować async void ponieważ jest to anti pattern, jedyny dopuszczalny czas to jest w przypadku EventHandler,
ponieważ EventHandler potrzebuje sygnatury typu zwracanego void.");
        }
    }
}