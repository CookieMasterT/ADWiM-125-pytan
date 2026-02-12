using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_123 : IZadanie
    {
        public int ID { get; set; } = 123;
        public string Text { get; set; } = "123. Opisz wady i zalety kolekcji bezpiecznych wątkowo. Kiedy warto z nich skorzystać?  ";
        public void Execute()
        {
            Console.WriteLine(@"Kolekcje bezpieczne wątkowo są w stanie być modyfikowane przez wiele wątków naraz, bez tracenia danych.
Mimo tego jednak mają nie przewidywalną kolejność informacji, i są one bardziej kosztowne obliczeniowo z powodu implementowania procedur synchronizacji.

Warto z nich korzystać kiedy wiadomo że na kolekcji będzie działało wiele wątków jednocześnie np. aby zebrać wyniki pracy ich wszystkich.");
        }
    }
}