using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_038 : IZadanie
    {
        public int ID { get; set; } = 38;
        public string Text { get; set; } = "38. Czym są interfejsy? Kiedy warto z nich skorzystać? Jak się je implementuje?  ";

        private interface INumberPrinter // deklaracja interfejsu
        {
            // int number; // nie można zdefiniować pola instancji w interfejsie.
            static int number;
            int Number { get; set; }
            void PrintNumber();
        }

        private class Przykład() : INumberPrinter // ta klasa, teraz musi implementować metody zdefiniowane w intefejsie.
        {
            static int number;
            public int Number { get; set; }
            public void PrintNumber()
            {
                Console.WriteLine(number);
            }
        }
        private class Przykład2() : INumberPrinter
        {
            static int number;
            public int Number { get; set; }
            public void PrintNumber()
            {
                Console.WriteLine(number * 2);
            }
        }

        public void Execute()
        {
            INumberPrinter NP = new Przykład(); // może tu również być Przykład2
            NP.PrintNumber();

            Console.WriteLine();

            Console.WriteLine(@"Interfejsy to kontrakty, mówiące o tym że klasa posiada dane metody, pola lub właściwości, służą jako szablon zachowania.
Interfejsy nie powinny zawierać informacji o sposobie implementacji obiektu.
Interfejs nie może zawierać pól instancji i elementy niepubliczne nie mogą implementować interfejsu.

Interfejsy służą aby udowodnić że dany obiekt może wykonać daną czynność, lub zawiera daną informację.
Kod może działać na klasie lub jej instancji wiedząc tylko że implementowany jest interfejs, nie interesując się detalami implementacji.

Warto je używać kiedy chce się np. otrzymać tą samą informację z wielu różnych typów obiektów,
nie ma znaczenia jak ten obiekt poda tą informację, ani co to jest za typ obiektu, wystarczy informacja że ten obiekt może tą informację podać.

Implementuje się interfejs poprzez zadeklarowanie implementacji przy deklaracji klasy np.:
public class Przykład() : IInterfejs {} 
A potem odpowiednie zadeklarowanie każdego elementu zawartego w interfejsie (jeżeli nie jest zdefiniowana wersja domyślna).

Warto wspomnieć że każda klasa może implementować dowolną ilość interfejsów.");
        }
    }
}