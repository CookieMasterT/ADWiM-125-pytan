using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_031 : IZadanie
    {
        public int ID { get; set; } = 31;
        public string Text { get; set; } = "31. Słowo kluczowe this – jak działa, kiedy używamy?  ";

        private class Przyklad
        {
            private int wartosc;
            public Przyklad(int wartosc)
            {
                this.wartosc = wartosc; // użycie this aby odróżnić pole od parametru
            }
            public void ZmianaWartosci()
            {
                this.wartosc = 10; // użycie this aby zaznaczyć że zmieniana jest wartość pola tej instancji
            }
            public Przyklad() : this(0) // użycie this aby wywołać inny konstruktor tej samej klasy
            {
            }
        }

        public void Execute()
        {
            Console.WriteLine(@"Słowo kluczowe this odwołuje się do aktualnej instancji danej klasy,
z tego powodu nie można użyć this w klasie statycznej.

np.: this.pole = 10;

Pozwala ono instancji klasy zmienić wartość pola w samej sobie, podczas działania metody lub konstruktora.
Słowo kluczowe this można również użyć aby wywołać konstruktor własnej klasy,
np. jeżeli chce się zaimplementować domyślne parametry do konstruktora, wywoływane przy użyciu konstruktora bez parametrowego

np.: public Klasa() : this(1) {}");
        }
    }
}