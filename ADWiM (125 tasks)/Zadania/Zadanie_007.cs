using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_007 : IZadanie
    {
        public int ID { get; set; } = 7;
        public string Text { get; set; } = "7. Opisz krotki i ich cechy.  ";
        public void Execute()
        {
            (int, string, bool) KrotkaA = (1, "Tytus", true);
            var KrotkaB = (Id: 2, Name: "Romek", IsActive: false);
            //Tuple KrotkaC = (1, 2, 3, 4, 5, 6, 7, 8, 9) // za dużo elementów
            Tuple<int, int, int> KrotkaD = Tuple.Create(1, 2, 3); // można użyć klasy Tuple

            Console.WriteLine(KrotkaA.Item1);
            Console.WriteLine(KrotkaB.Id);

            Console.WriteLine();

            Console.WriteLine(@"Krotki to niemutowalny zestaw wartości, podobny do array,
W przeciwieństwie do array:
    używa innych nawiasów do deklaracji: () zamiast []
    może przechowywać on różne typy wartości (np. string i int jednocześnie)
    może mieć Wartości nazwane (Id: 1, Nazwa: 'Tytus')

Krotki są ograniczone do 8 wartości i zamiast uzyskać wartość używając:
KrotkaA[0], Trzeba użyć: KrotkaA.Item1

Krotki można również tworzyć używając klasy Tuple:
Tuple<int, int, int> Krotka = Tuple.Create(1, 2, 3);");
        }
    }
}