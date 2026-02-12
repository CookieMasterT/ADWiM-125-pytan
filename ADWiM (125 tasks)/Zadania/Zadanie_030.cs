using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_030 : IZadanie
    {
        public int ID { get; set; } = 30;
        public string Text { get; set; } = "30. Wyjaśnij cel tworzenia prywatnych konstruktorów.  ";

        private class Przyklad
        {
            private Przyklad()
            {
                // Prywatny konstruktor
            }
        }

        // private class Dziedziczenie : Przyklad // nie można dziedziczyć po klasie z konstruktorami prywatnymi
        //{

        //}

        public void Execute()
        {
            Console.WriteLine(@"Prywatne konstruktory służą aby nie pozwolić na tworzenie instancji klasy z zewnątrz (w nie kontrolowany sposób).
Mogą również być użyte aby zapobiec dziedziczenia (jeżeli klasa ma tylko konstruktory prywatne, nie można po niej dziedziczyć)

Ścisła kontrola nad tworzeniem instancji klasów może mieć różne cele:
    - jeżeli klasa ma tylko rzeczy statyczne, nie ma sensu tworzyć jej obiektów
    (klasa statyczna jest bardziej restrykcyjna, nie może np. implementować interfejsów czy dziedziczyć)
    - Wzorzec Singleton, czyli jeżeli chce się upewnić że będzie istniała dokładnie 1 instancja klasy.
    - Wymuszenie użycia metod tworzących (fabrykujących) zamiast konstruktora");
        }
    }
}