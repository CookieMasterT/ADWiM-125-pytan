using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_016 : IZadanie
    {
        public int ID { get; set; } = 16;
        public string Text { get; set; } = "16. Czym jest i jak działa dynamic?  ";
        public void Execute()
        {
            dynamic example = 123;
            example = "abcd"; // now it is a different type
            example = example.ToUpper(); // this will work at runtime

            object example2 = 123;
            example2 = "123"; // we can still reasign it
            //example2.ToUpper(); // but this will cause a compile-time error
            example2 = ((string)example2).ToUpper(); // we need to cast it first

            dynamic variable; // we can declare a dynamic variable without initializing it
            bool condition = true;
            if (condition) {
                variable = 42;
            } else {
                variable = "A dynamic string";
            }

            Console.WriteLine(@"dynamic to typ niezdefiniowany który automatycznie przybiera typ zmiennych do niej przypisanych
(uzyskuje on funkcjonalność metod wynikających z bycia daną zmiennon np. ToUpper() od string)

Ponieważ typ jest wybierany dynamicznie (wybierany podczas działania, nie kompilacji)
można zdefiniować zmienną bez przypisanie jej wartości ani typu
dynamic zezwala na przypisanie do niego wartości innego typu (np. przypisanie liczby do string) tak samo jak object
ale nie wymaga on rzutowania aby móc używać metod");
        }
    }
}