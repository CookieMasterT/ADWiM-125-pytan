using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_125 : IZadanie
    {
        public int ID { get; set; } = 125;
        public string Text { get; set; } = "125. Wszystkie konwencje nazewnictwa: a. Klasy, b. katalogi, przestrzenie nazw, c. pola, właściwości, d. metody, argumenty metod, e. interfejsy, typy generyczne f. klasy abstrakcyjne, g. zmienne, stałe, h. metody asynchroniczne, i. itd.  ";
        public void Execute()
        {
            Console.WriteLine(@"Konwencje nazewnictwa to:
	a. Klasy - PascalCase

	b. katalogi, przestrzenie nazw - PascalCase, struktura hierarchiczna oddzielona kropką (np. System.Collections.Generic).

	c. pola - camelCase.
       pola prywatne - _ + camelCase.
       właściwości - PascalCase.

	d. metody - PascalCase.
       argumenty metod - camelCase.

	e. interfejsy - I + PascalCase.
       typy generyczne - T + PascalCase.

	f. klasy abstrakcyjne - PascalCase.

	g. zmienne - camelCase.
       stałe - PascalCase.

	h. metody asynchroniczne - PascalCase + Async

	i. itd.
        enumeratory, zdarzenia, atrybuty, delegaty - PascalCase
");
        }
    }
}