using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_039 : IZadanie
    {
        public int ID { get; set; } = 39;
        public string Text { get; set; } = "39. Zasady projektowania interfejsów.  ";
        public void Execute()
        {
            Console.WriteLine(@"Deklarując interfejs użyj konwencji nazewnictwa: Pierwsza litera I, PascalCase
Najlepsze praktyki to:
    - Zasada segregacji interfejsów - Powinno sie mieć wiele wyspecjalizowanych interfejsów zamiast jednego ogólnego.
    - Interfejsy powinny mówić co obiekt robi, a nie jak to robi.
    - Interfejsy nie powinny wymuszać detali implementacji np. specyficznych bibliotek.
    - Unikaj interfejsów zbyt dużych, zawierających zbyt wiele metod.
    - Unikaj zmian w interfejsach już używanych.
");
        }
    }
}