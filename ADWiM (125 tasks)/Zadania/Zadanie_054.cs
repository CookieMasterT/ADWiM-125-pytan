using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_054 : IZadanie
    {
        public int ID { get; set; } = 54;
        public string Text { get; set; } = "54. Podaj sposoby definiowania rekordów.  ";

        private record Osoba1() // Pełna definicja wartości
        {
            public required string Imię { get; init; }
            public required string Nazwisko { get; init; }
        }
        private record Osoba2(string Imię, string Nazwisko ); // definicja pozycyjna
        private record Osoba3 : Osoba1 // definicja z dziedziczeniem.
        {
            public required int Wiek { get; init; }
        }

        public void Execute()
        {
            Osoba1 O1 = new Osoba1() { Imię = "Jan", Nazwisko = "Kowalski" };
            Osoba2 O2 = new Osoba2("Jan", "Kowalski");
            Osoba3 O3 = new Osoba3() { Imię = "Jan", Nazwisko = "Kowalski", Wiek = 30 };

            Console.WriteLine(@"Są 3 sposoby zdefiniowania rekordu:
    - Pozycyjne, definiujesz jedynie konstruktor i pozwalasz kompilatorowi wypełnić właściwości z domyślnym { get; init; }.
    - Klasycznie, z pełną definicją wartości, definiujesz każdą wartość razem z wybranym { get; init; }.
    - Poprzez dziedziczenie, część wartości wynika z dziedziczenia, można po tym zdefiniować ich więcej.");
        }
    }
}