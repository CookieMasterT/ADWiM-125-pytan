using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_012 : IZadanie
    {
        public int ID { get; set; } = 12;
        public string Text { get; set; } = "12. Czym jest boxing i unboxing?  ";
        public void Execute()
        {
            Console.WriteLine(@"Boxing i unboxing to są mechanizmy konwertowania typów wartościowych na referencyjne i spowrotem
Przykładem boxingu to jest przypisanie wartości int (wartościowej) do object (referencyjnej)
Unboxing to jest rzutowanie danego boxowanego obiektu spowrotem na swój typ");
        }
    }
}