using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_026 : IZadanie
    {
        public int ID { get; set; } = 26;
        public string Text { get; set; } = "26. Czym jest klasa?  ";
        public void Execute()
        {
            Console.WriteLine(@"Klasa to jest szablon obiektu, definiuje ona nowy typ danych.
Mówi o tym jakie pola, właściwości lub metody będzie zawierał obiekt.

Warto wspomnieć że klasa sama w sobie jest abstrakcyjna.");
        }
    }
}