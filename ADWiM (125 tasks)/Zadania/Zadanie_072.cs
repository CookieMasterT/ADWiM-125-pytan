using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_072 : IZadanie
    {
        public int ID { get; set; } = 72;
        public string Text { get; set; } = "72. Czym są (dlaczego powstały?) kolekcje?  ";
        public void Execute()
        {
            Console.WriteLine(@"Kolekcje to pojemniki na danę. które dynamicznie rosną i posiadają metody do pracy z elementanmi.

Powstały ponieważ tablice (array) były zbyt prymitywne, miały one stały rozmiar,
nie miały metod aby móc na nich pracować,
Potrzebowały ręcznego zarządzania ich rozmiarem, były szybkie ale zbyt mało rozbudowane
(trzeba było zawsze implementować własne rozwiązania).");
        }
    }
}