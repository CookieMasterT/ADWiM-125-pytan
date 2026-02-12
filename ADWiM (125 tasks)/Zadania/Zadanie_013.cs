using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_013 : IZadanie
    {
        public int ID { get; set; } = 13;
        public string Text { get; set; } = "13. Jak działają operatory: ?, ??. Podaj przykład kodu z ich wykorzystaniem.  ";
        public void Execute()
        {
            bool condition = false;
            Console.WriteLine($"bool condition {(condition ? "jest prawdziwy" : "jest fałszywy")}");

            int? someNumber = null;
            Console.WriteLine($"someNumber ma wartość {(someNumber ?? -1)}");

            Console.WriteLine();

            Console.WriteLine(@"Operator ? to jest skrót do operator warunkowy, jest skrótem do if-else
Warunek ? wartość_jeśli_prawda : wartość_jeśli_fałsz
np. 
int wiek = 20;
Console.WriteLine($""osoba jest {wiek >= 18 ""pełnoletnia"" : ""niepełnoletnia""}"")

Operator ?? to szybkie ustawienie wartości domyślnej jeżeli zmienna nie jest przypisana
Zmienna : Wartość_Jeżeli_Null
np. 
int imie = null
Console.WriteLine($""Osoba nazywa się: {imie ?? ""anonim""}"")");
        }
    }
}