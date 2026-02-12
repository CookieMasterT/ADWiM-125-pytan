using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_078 : IZadanie
    {
        public int ID { get; set; } = 78;
        public string Text { get; set; } = "78. Jak działa pętla foreach?  ";
        public void Execute()
        {
            Console.WriteLine(@"Pętla foreach działa na podstawie interfejsu IEnumerable.
    1. Odbiera on używając IEnumerable enumerator.
    2. Używa pętli while używając enumerator.MoveNext() jako warunek
    3. Zapisuje do wartości zdefiniowanej w deklaracji foreach enumerator.Current()
    4. Wykonuje swój blok kodu.
    5. Powtarza aż pętla while się zakończy.");
        }
    }
}