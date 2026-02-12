using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_103 : IZadanie
    {
        public int ID { get; set; } = 103;
        public string Text { get; set; } = "103. Opisz różnicę między czekaniem synchronicznym i asynchronicznym?  ";
        public void Execute()
        {
            Console.WriteLine(@"Czekanie synchroniczne to jest czekanie które blokuje wątek,
a czekanie asynchroniczne to jest takie które zezwala na dalsze akcję dokonywane w danym wątku.

W czekaniu asynchronicznym wątek jedynie zatrzymuje dokonywanie danego bloku kodu, i do niego wraca po zakończeniu czekania,
jest w stanie nadal dokonywać inne operacje w tym czasie, w przeciwieństwie do czekania synchronicznego.");
        }
    }
}