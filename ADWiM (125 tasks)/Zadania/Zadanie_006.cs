using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    // Poprawne miejsce na definicję typu wyliczeniowego (enum) to poziom klasy lub przestrzeni nazw, nie wewnątrz metody.
    public enum DniTygodnia
    {
        poniedziałek,
        wtorek,
        środa,
        czwartek,
        piątek,
        sobota,
        niedziela = 100
    }

    public class Zadanie_006 : IZadanie
    {
        public int ID { get; set; } = 6;
        public string Text { get; set; } = "6. Czym są typy wyliczeniowe? Kiedy warto z nich skorzystać, jakie są zasady definiowania typów wyliczeniowych?  ";
        public void Execute()
        {
            Console.WriteLine("Drugi dzień tygodnia to: " + DniTygodnia.wtorek);
            Console.WriteLine("Można porównać numer dnia tygodnia: " + @"1 == (int)DniTygodnia.wtorek: " + (1 == (int)DniTygodnia.wtorek).ToString());
            Console.WriteLine("Niedziela ma wartość: " + (int)DniTygodnia.niedziela);

            Console.WriteLine();

            Console.WriteLine(@"Typy wyliczeniowe, inaczej enumeratory to specjalne typy wartościowe.
Służą do reprezentacji ściśle ograniczonego zestawu opcji.

warto z nich korzystać gdy zmienna lub parametr metody może przyjąć
tylko kilka ściśle zdefiniowanych wartości(np. Dni tygodnia)

Są alternatywą do np. tablicy magicznych stringów.
Ich użytkowanie poprawia czytelność kodu, Pozwala kompilatorowi sprawdzać poprawność,
i powoduje że IDE jest w stanie podpowiedzieć opcje.

Definiuje się je używając słowa kluczowego enum i listy wartości w nawiasach klamrowych.
np: enum DniTygodnia { poniedziałek, wtorek, [...], niedziela }
można enum definiować tylko na poziomie klasy lub przestrzeni nazw");
        }
    }
}