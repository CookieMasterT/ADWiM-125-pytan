using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_052 : IZadanie
    {
        public int ID { get; set; } = 52;
        public string Text { get; set; } = "52. Kiedy używać struktury, a kiedy klasy?  ";
        public void Execute()
        {
            Console.WriteLine(@"Klasy powinny być używane kiedy:
    - Mamy złożony obiekt, potrzebuje on polimorfizmu lub dziedziczenia.
    - Potrzebujemy np. serwisu, czyli chcemy utworzyć tylko 1 statyczną klasę, służącą jako stała część programu.
    - Potrzebujemy obiekt który będzie dostępny w wielu miejscach.
    - obiekt jest duży lub złożony (kopiowanie i trzymanie wielu kopii dużego obiektu jest mało wydajne).
    - Potrzebujemy finalizatory / destruktory.
Struktury powinny natomiast być używane kiedy:
    - Obiekt reprezentuje małą część danych, która powinna być zgrupowana (wektor, kolor, etc.)
    - Obiekt będzie nie będzie wymagał częstych zmian danych, dynamiczność nie będzie jego częścią.
    - Tworzenie kopii ma być łatwe i szybkie, potrzebna jest niezależność kopii od siebie.");
        }
    }
}