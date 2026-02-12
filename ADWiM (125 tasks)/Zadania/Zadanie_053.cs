using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_053 : IZadanie
    {
        public int ID { get; set; } = 53;
        public string Text { get; set; } = "53. Czym są rekordy w C#?  ";

        private record Osoba ()
        {
            public required string Imię { get; init; } // required, wymagana wartość
            public string Nazwisko { get; init; } = "Kowalski";
        }

        private record DowódOsobisty : Osoba // rekordy mogą po sobie dziedziczyć
        {
            public required string Numer { get; init; }
            public required int wiek { get; init; }
        }

        public void Execute()
        {
            Osoba P = new Osoba() { Imię = "Jan" };
            //P.Nazwisko = "Nowak"; // rekordy są niemutowalne.
            P = P with { Nazwisko = "Nowak" };
            Console.WriteLine(P.ToString());

            Console.WriteLine();

            Console.WriteLine(@"Rekord to prosty typ służący do przechowywanie danych w sposób niemutowalny.
Może on mieć konstruktory, pola, właściwości i metody, pozwala to na implementowanie interfejsu.

Ponieważ rekordy są niemutowalne, to posiadają { get; init; } zamiast { get; set; } w swoich właściwościach,
Również aby zmienić wartość to trzeba utworzyć nowy rekord, często robi się to za pomocą słowa kluczowego with.

Implementuje on Equals(), GetHashCode() i ToString() które porównują swoje zawartości według wartości,
pozwala to na traktowanie tych metod podobnie jak na mniej rozbudowanych typach.

Można w rekordzie:
    - Użyć słowa kluczowego required, co powoduje wymóg przypisanie wartości przy deklaracji
    - Użyc słowa kluczowego class, mimo tego że to nic nie robi, zaznacza że rekord nie powinienen zostać struct'em
    - Użyć słowa kluczowego struct, co spowoduje że rekord będzie typem wartościowym i nie będzie mógł dziedziczyć.");
        }
    }
}