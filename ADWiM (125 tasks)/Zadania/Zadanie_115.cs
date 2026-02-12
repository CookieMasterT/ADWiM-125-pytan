using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_115 : IZadanie
    {
        public int ID { get; set; } = 115;
        public string Text { get; set; } = "115. Opisz różnicę między równoległością a asynchronicznością.  ";
        public void Execute()
        {
            Console.WriteLine(@"Asynchroniczność to jest strategia która pozwala na zwolnienie pojedyńczego wątka, czyli nieblokowanie go.
Równoległość to jest utworzenie wielu wątków aby móc szybciej wykonać ciężką operację.");
        }
    }
}