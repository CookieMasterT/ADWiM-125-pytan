using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_056 : IZadanie
    {
        public int ID { get; set; } = 56;
        public string Text { get; set; } = "56. Opisz różnicę między rekordami referencyjnymi a wartościowymi.  ";

        record struct RekordWartościowy
        {
            public int A { get; init; }
            public int B { get; init; }
        }

        record class RekordReferencyjny
        {
            public int A { get; init; }
            public int B { get; init; }
        }

        public void Execute()
        {
            Console.WriteLine(@"Rekordy referencyjne:
    - Tworzone za pomocą record class.
    - Przechowywane na stercie.
    - Kopiowanie tworzy referencję do tego samego obiektu.
Rekordy wartościowe:
    - Tworzone za pomocą record struct.
    - Przechowywane na stosie
    - Kopiowanie tworzy osobny zestaw wartości
    - Nie mogą dziedziczyć");
        }
    }
}