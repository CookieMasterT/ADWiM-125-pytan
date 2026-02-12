using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_057 : IZadanie
    {
        public int ID { get; set; } = 57;
        public string Text { get; set; } = "57. Czym są typy anonimowe? Kiedy warto z nich skorzystać, a kiedy jest to niemożliwe?  ";
        public void Execute()
        {   
            var Person = new { Name = "Jan", Age = 30 }; // brak zdefiniowanego typu
            Console.WriteLine(@"Typ anonimowy to tymczasowy obiekt, podobny do rekordu.
Tworzony jest bez zdefiniowania typu, jest niemutowalny.
Powinno się je używać kiedy się potrzebuje tymczasowy zestaw danych.

Istnieją tylko w zakresie w którym zostały zadeklarowanem, nie można ich przekazywać np. jako typ zwracany w metodzie.");
        }
    }
}