using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_020 : IZadanie
    {
        public int ID { get; set; } = 20;
        public string Text { get; set; } = "20. Czym jest zmienna?  ";
        public void Execute()
        {
            Console.WriteLine(@"Zmienna to obiekt przeznaczony do przechowania danej informacji.
Każda zmienna ma:
    Typ danych - int, float, double, string, array
        Warto wspomnieć podział na:
        Wartościowe - int, float, double; które przechowują wartość i są przechowywane w stosie.
        Referencyjne - string, array; które przechowują wskaźnik do pamięci obiektu który jest w stercie.
    Nazwę, czyli jak odnieść się do zmiennej, istnieje wyłącznie dla programisty.
    Zakres, czyli gdzie w kodzie zmienna jest widoczna.
    Wartość, czyli informacja która jest przechowana w zmiennej.");
        }
    }
}