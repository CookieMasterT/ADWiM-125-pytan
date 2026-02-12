using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_025 : IZadanie
    {
        public int ID { get; set; } = 25;
        public string Text { get; set; } = "25. Czym jest przeciążanie metod?  ";
        public int Dodaj(int a, int b)
        {
            return a + b;
        }
        //public double Dodaj(int a, int b) // Niedozwolone, ponieważ jedyną różnicą jest typ zwracany.
        //{
        //    return a + b; 
        //}
        public double Dodaj(double a, double b)
        {
            return a + b;
        }
        public int Dodaj(int a, int b, int c)
        {
            return a + b + c;
        }
        public void Execute()
        {
            Console.WriteLine(@"Przeciążanie metod to jest utworzenie kilku metod z tą samą nazwą, ale inną sygnaturą.
Sygnatura to jest zestaw typów i ilości parametrów.
Można utworzyć kilka funkcji o tej samej nazwie ale innej ilości argumentów lub ich różnych typach
Typ zwracany nie jest częścią sygnatury.");
        }
    }
}