using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_033 : IZadanie
    {
        public int ID { get; set; } = 33;
        public string Text { get; set; } = "33. Czym jest klasa statyczna? Kiedy się z nich korzysta? Jakie są zasady jej projektowania?  ";

        private static class Przyklad
        {
            public static int a = 0;
            // public int b = 0; // nie można mieć pól niestatycznych w klasie statycznej
        }

        public void Execute()
        {
            // Przyklad P = new Przyklad(); // nie można tworzyć instancji klasy statycznej
            Przyklad.a = 10; // dostęp do pola statycznego klasy statycznej jest wykonywany poprzez nazwę klasy

            Console.WriteLine(@"Klasa statyczna to jest taka, która nie może posiadać instancji,
skutkiem ubocznym jest to że wszystkie pola, właściwości i metody muszą być statyczne, czyli będą należeć do klasy a nie do obiektu.

Klasa statyczna nie może dziedziczyć, implementować interfejsów i może posiadać tylko konstruktor statyczny
(zostanie on wywołany przy pierwszym użyciu klasy).

Klasa statyczna powinna istnieć jako kontener na funkcje lub dane wspólne dla całego programu i mieć ściśle określoną role.
Powinna być tworzona tylko do rzeczy globalnych i abstrakcyjnych (np. funkcje matematyczne)
W klasach statycznych powinno się unikać częstego zmieniania stanu, tymbardziej z wielu źródeł.");
        }
    }
}