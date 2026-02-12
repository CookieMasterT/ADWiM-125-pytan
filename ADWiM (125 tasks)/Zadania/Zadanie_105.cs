using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_105 : IZadanie
    {
        public int ID { get; set; } = 105;
        public string Text { get; set; } = "105. Opisz słowa kluczowe async i await.  ";

        private class Example 
        {
            async void Run()
            {
                await Task.Delay(1000);
            }
        }
        public void Execute()
        {
            Console.WriteLine(@"Async to jest deklaracja funkcji która jest w stanie zwolnić własny wątek,
Słowo kluczowe async jest modyfikatorem funkcji, który mówi o jej asynchroniczności.

Await to jest wykonanie asynchronicznego zadania, metoda wykonująca to zadanie, musi być asynchroniczna,
aby móc zwolnić swój wątek.
Zadanie wykonywanie przez await, nie zatrzymuje wątku, ale metoda go wykonująca nie wykona dalszych zadań
w sobie zawartych, dopóki zadanie wywołane z słowem kluczowym await, nie ukończy się.
");
        }
    }
}