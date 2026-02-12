using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_055 : IZadanie
    {
        public int ID { get; set; } = 55;
        public string Text { get; set; } = "55. Kiedy korzystać z rekordów, a kiedy klas?  ";
        public void Execute()
        {
            Console.WriteLine(@"Klasy powinny być używane kiedy:
    - Mamy złożony obiekt, potrzebuje on zmieniać własne wartości lub formę.
    - Potrzebujemy np. serwisu, czyli chcemy utworzyć tylko 1 statyczną klasę, służącą jako stała część programu.
    - Potrzebujemy obiekt który będzie dostępny w wielu miejscach.
    - obiekt jest duży lub złożony (kopiowanie i trzymanie wielu kopii dużego obiektu jest mało wydajne).
    - Potrzebujemy finalizatory / destruktory.
Rekordy powinny natomiast być używane kiedy:
    - Obiekt reprezentuje małą część danych, która powinna być zgrupowana (wektor, kolor, etc.)
    - Obiekt nie będzie się zmieniał, wartości w rekordach nie można nadpisywać, trudno się je zmiena.
    - Praca na danych musi być szybka i wygodna, rekordy automatycznie definiują metody przyrównawcze.");
        }
    }
}