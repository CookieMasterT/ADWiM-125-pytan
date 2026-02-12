using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_075 : IZadanie
    {
        public int ID { get; set; } = 75;
        public string Text { get; set; } = "75. Czym jest słownik? Jakie są wymagania co do klucza?  ";
        public void Execute()
        {
            Dictionary<string, int> ages = new Dictionary<string, int>
            {
                { "Alice", 30 },
                { "Bob", 25 }
            };
            
            Console.WriteLine(@"Słownik to kolekcja która zamiast używać indeksu, do znajdowania danych, używa klucza.
Charakteryzuję się szybkim znajdowaniem danych, dzięki swojemu hashowaniu kluczów i brakiem zachowania kolejności.

W słowniku każdy klucz musi być unikatowy.

Klucz musi implementować IEquatable do własnego typu (IEquatable.Equals<TKey>(Tkey key))
i musi poprawnie wykonywać metodę GetHashCode() dziedziczoną z Object, aby zapewnić dobre działanie słownika.");
        }
    }
}