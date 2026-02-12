using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_011 : IZadanie
    {
        public int ID { get; set; } = 11;
        public string Text { get; set; } = "11. Opisz typ object oraz jego potencjalne zastosowania.  ";
        public void Execute()
        {
            object[] items = [1, "tekst", 3.14, DateTime.Now];

            Console.WriteLine(@"Typ object to podstawowy typ po którym dziedziczy wszystko w języku c#
Udostępnia podstawowe metody (ToString, GetHashCode, Equals, GetType).

Można użyć object np. kiedy chce się użyć tablicę wielu różnych typów obiektów.");
        }
    }
}