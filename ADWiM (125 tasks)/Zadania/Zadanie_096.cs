using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_096 : IZadanie
    {
        public int ID { get; set; } = 96;
        public string Text { get; set; } = "96. Znaczenie operatorów kończących w LINQ – jakie są pułapki związane z ich niezastosowaniem? Na co trzeba uważać?  ";
        public void Execute()
        {
            Console.WriteLine(@"Ponieważ LINQ działa leniwie, czyli nie wykona zapytania dopóki nie zostanie wykonana próba uzyskania wyniku,
to jeżeli nie wykona się operatora kończącego, to zamiast wykonania zapytania, zadeklarujesz je.

Jest to pułapka która może być kosztowna wydajnościowo, jeżeli się zadeklaruje zapytanie bez zakończenia go,
to każde uzyskiwanie wyniku spowoduję ponownę wykonanie zapytania po raz kolejny.");
        }
    }
}