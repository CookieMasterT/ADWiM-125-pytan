using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_018 : IZadanie
    {
        public int ID { get; set; } = 18;
        public string Text { get; set; } = "18. Jak działa instrukcja switch? Jak zaimplementować możliwość użycia kilku casów – jeden pod drugim / or.  ";
        public void Execute()
        {
            int number = 1;

            switch (number)
            {
                /*case -1:
                    Console.WriteLine("Liczba jest równa -1");*/ // ten case jest niepoprawny ponieważ nie ma w nim break;
                case 0:
                    Console.WriteLine("Liczba jest równa 0");
                    break;
                case 1:
                    Console.WriteLine("Liczba jest równa 1");
                    break;
                case 2 or 3: // zauważ że w c# logiczne or to "||" a nie "or"
                    Console.WriteLine("Liczba jest równa 2 lub 3");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Liczba jest równa 4 lub 5");
                    break;
                case > 3:
                    Console.WriteLine("Liczba jest większa niż 3");
                    break;
                default:
                    Console.WriteLine("Liczba jest mniejsza niż 0");
                    break;
            }

            Console.WriteLine(@"switch to jest przyrównanie danej liczby do jednego z możliwości na podstawie wielu warunków
instrukcję switch się zaczyna: switch(zmienne) {} i potem w niej się zapisuje listę casów jako warunek wykonania kodu
Dopuszczalne jest przekazanie kilku zmiennych i kilku różnych typów danych do switch'a

w c# fall-through czyli wykonanie kodu kilku casów w jednym dokonaniu instrukcji switch jest niemożliwe,
wszystkie case muszą mieć w sobie goto; return; lub break;
Jeżeli chce się tą zasadę obejść to można użyć instrukcji goto case x; która przenosi wykonanie do innego case'a (bez sprawdzenia warunku)

Również istnieje instrukcja default która zawsze jest wykonywana jeżeli żaden inny warunek nie jest spełniony
(jej miejsce w kolejności nie ma znaczenia, może być na początku lub na końcu)

Sposoby użycia Case:
    - Case x:, gdzie jest sprawdzane czy: zmienna == x
    - Case x or y:, gdzie jest sprawdzane czy: zmienna == x || zmienna == y
    - Case x and y:, gdzie jest sprawdzane czy: zmienna == x && zmienna == y
    - Można zastosować when do przypisania zmiennej do zmiennej tymczasowej, np.:
        case int n when n > 0:
            //kod//; break;
    - Zestaw kilku case'ów pod sobą
        case x:
        case y:
            //kod//; break;
    Sprawdza on wszystkie case'y po kolei (jeżeli jeden z nich jest prawdziwy to wykonywany jest kod)
    - case > x:, który dokonuje daną operacje logiczną (>, <, >=, <=) na zmiennej");
        }
    }
}