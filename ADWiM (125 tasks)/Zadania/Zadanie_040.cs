using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_040 : IZadanie
    {
        public int ID { get; set; } = 40;
        public string Text { get; set; } = "40. Czym jest dziedziczenie? Jak działa? Kiedy warto sięgnąć po ten mechanizm?  ";

        public abstract class Animal
        {
            public void BeAlive() { }
        }

        public class Cat : Animal
        {
            public void Meow() { }
            // The cat can also use BeAlive() method from Animal class since it inherits from it.
        }

        public void Execute()
        {
            Console.WriteLine(@"Dziedziczenie to sposób aby utworzyć klasę w oparciu o inną, utworzoną wcześniej
Klasa pochodna przejmuje jej publiczne metody, pola, własciwości lub interfejsy. Może je zachować lub nadpisać.

W c#, każda klasa może dziedziczyć z maksymalnie 1 klasy, nie dozwolona jest również zależność pętlowa.

Dziedziczy się z klasy poprzez nazwanie jej po dwu kropku np.:
public class Cat : Animal {} (kot dziedziczy po zwierzęciu)

Dziedziczenia się używa jako formę abstrakcji która pozwala na uniknięcie redundancji kodu
np. kiedy się posiada wiele klas które mają tą samą funkcjonalność ale każda w innej bardziej wyspecjalizowanej formie.
(relacja klasa dziedzicząca jest klasą bazową)");
        }
    }
}