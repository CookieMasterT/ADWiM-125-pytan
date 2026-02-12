using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_051 : IZadanie
    {
        public int ID { get; set; } = 51;
        public string Text { get; set; } = "51. Czym są struktury w C#?  ";

        private struct Przykład
        {
            public Przykład() // podobno nie można utworzyć konstruktora bez parametrowego.
            {
                Y = 5; 
            } 

            public int X;
            public int Y;
        }

        public void Execute()
        {
            Przykład P = new Przykład();
            P.X = 10; // powinno utworzyć nową strukturę w miejsce starej.
            Console.WriteLine($"X: {P.X}, Y: {P.Y}");

            Console.WriteLine();

            Console.WriteLine(@"Struktury są podobne do klas, są one zestawem pól, właściwości, metod z konstruktorem zdefiniowane przez użytkownika.
Są jednak typami wartościowymi czyli są przechowywane na stosie a nie na stercie,
a kopiowanie ich nie tworzy referencji tylko nowy obiekt.
Wartości które są przechowywane w strukturach są przechowywane bezpośrednio w strukturze,
a nie jako referencje do innych obiektów.

Nie mogą one również dziedziczyć, być statyczne, posiadać destruktora, ani mieć konstruktora o ograniczonym dostępie.

Są one szybsze z powodu bycia na stosie, nadają się najlepiej do małych zestawów danych.");
        }
    }
}