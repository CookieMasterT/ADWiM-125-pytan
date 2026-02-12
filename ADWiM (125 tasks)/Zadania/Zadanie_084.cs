using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_084 : IZadanie
    {
        public int ID { get; set; } = 84;
        public string Text { get; set; } = "84. Czym są delegaty? Opisz ich rolę i zastosowania.  ";
        public void Execute()
        {
            Console.WriteLine(@"Delegat to jest typ dla zmiennej, która przechowuje funkcję.
Jest to typ wskaźnikowy, co oznacza że nie zawiera funkcji w samej sobie, posiada do niej tylko odwołanie.

Dzięki delegatom można:
    - Przechowywać funkcję tymczasowe np. funkcję lambda lub LINQ
    - Przekazywać funkcję jako typ zwracany lub przechowywać je jako zmienna lub pole.
    - Można używać callback'ów, reagować na eventy, tworzyć pluginy.");
        }
    }
}