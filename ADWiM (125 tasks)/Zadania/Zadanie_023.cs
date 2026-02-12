using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_023 : IZadanie
    {
        public int ID { get; set; } = 23;
        public string Text { get; set; } = "23. Jak działa słowo kluczowe default?  ";
        public void Execute()
        {
            Console.WriteLine(@"Słowo kluczowe default może się pojawić w 3 kontekstach:
1. jako operator: Default(T), który podaje wartość domyślną typu np.: Default(int), równa się wtedy 0 
2. jako literal: default, skrótowy zapis kiedy kompilator może typ wywnioskować np: int x = default
3. jako część instrukcji switch, jest wykonywany kiedy żaden blok case, nie jest wybrany.");
        }
    }
}