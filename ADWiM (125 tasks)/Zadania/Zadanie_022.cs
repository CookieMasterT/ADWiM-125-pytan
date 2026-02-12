using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_022 : IZadanie
    {
        public int ID { get; set; } = 22;
        public string Text { get; set; } = "22. Jak działają parametry domyślne metod w C#?  ";
        public int Example(int x, int y = 10)
        {
            return x + y;
        }
        //public int Example2(int x = 10, int y) // Optional parameters must appear after all required parameters
        //{
        //    return x + y;
        //}
        public void Execute()
        {
            Console.WriteLine(Example(1));
            Console.WriteLine(Example(1, 5));

            Console.WriteLine();

            Console.WriteLine(@"Parametry domyślne to są parametry których wartość jest zdefiniowana przy deklarowaniu wymaganych parametrów
Podanie wartości parametru domyślnego jest opcjonalne, jeżeli nie zostanie on podany przyjmie on wartość domyślną zamiast podanej.
Definiuje się je poprzez podanie znaku równości przy deklaracji parametru czyli np.:
    public void Metoda(int x = 10) {}
Wymagane jest aby parametry domyślne były zadeklarowane jako ostatnie, po parametrach nie domyślnych");
        }
    }
}