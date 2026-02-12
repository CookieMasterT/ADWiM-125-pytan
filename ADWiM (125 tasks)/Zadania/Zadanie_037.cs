using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_037 : IZadanie
    {
        public int ID { get; set; } = 37;
        public string Text { get; set; } = "37. Czym jest enkapsulacja (hermetyzacja) w rozumieniu programowania obiektowego?  ";
        public void Execute()
        {
            Console.WriteLine(@"Jest to ukrycie i zabezpieczenie detalów implementacji danej funkcjonalności przed światem zewnętrznym,
Pozwalając na dostęp do niej jedynie poprzez jasno zdefiniowane sposoby (właściwości, metody etc.)
Pozwala to na zapewnienie niezawodności kodu, lepszą kontrolę stanu, i większą przewidywalność funkcjonowania danego modułu.");
        }
    }
}