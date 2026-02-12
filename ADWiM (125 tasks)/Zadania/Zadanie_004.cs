using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_004 : IZadanie
    {
        public int ID { get; set; } = 4;
        public string Text { get; set; } = "4. Wyjaśnij jak działa „var” w C#. Kiedy dozwolone jest korzystanie z tego zapisu?  ";
        
        public void Execute()
        {
            var number = 10; // kompilator ustala, że number jest typu int
            //number = "abc"; // błąd kompilacji: nie można przypisać string do int
            Console.WriteLine(@"var w c# to niezdefiniowany typ.
Wybierany jest podczas czasu kompilacji (nie jest on dynamiczny, i się nie zmienia).
var może być użyty tylko w lokalnej deklaracji zmiennej,
oznacza to że może być użyta np. jako zmienna pomocnicza w funkcji,
ale nie jako zmienna w klasie.

Zapis tablic używając var jest niedozwolony ( var[] )");
        }
    }
}