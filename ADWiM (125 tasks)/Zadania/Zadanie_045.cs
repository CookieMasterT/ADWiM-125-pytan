using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_045 : IZadanie
    {
        public int ID { get; set; } = 45;
        public string Text { get; set; } = "45. Podaj sposobu rzutowania obiektów – kiedy można rzutować obiekt, jakie są sposoby i czym się od siebie różnią? – zwykłe rzutowanie, as, is.  ";
        
        private class KlasaBazowa 
        {
            public string DoSomething() 
            {
                return "KlasaBazowa";
            }
        }

        private class KlasaPochodna : KlasaBazowa
        {
            public new string DoSomething()
            {
                return "KlasaPochodna";
            }
        }

        public void Execute()
        {
            KlasaBazowa KBazowaBazowa = new KlasaBazowa();
            KlasaBazowa KBazowaPochodna = new KlasaPochodna();
            KlasaPochodna KPochodna = new KlasaPochodna();

            // DownCasting

            // Console.WriteLine(((KlasaPochodna)KBazowaBazowa).DoSomething()); // invalid cast exception
            Console.WriteLine(((KlasaPochodna)KBazowaPochodna).DoSomething());
            Console.WriteLine(KBazowaBazowa is KlasaPochodna); // false
            Console.WriteLine(KBazowaPochodna is KlasaPochodna); // true
            Console.WriteLine((KBazowaBazowa as KlasaPochodna)?.DoSomething()); // null
            Console.WriteLine((KBazowaPochodna as KlasaPochodna)?.DoSomething());

            // UpCasting

            Console.WriteLine(((KlasaBazowa)KPochodna).DoSomething());
            Console.WriteLine(KPochodna is KlasaBazowa); // true
            Console.WriteLine((KPochodna as KlasaBazowa)?.DoSomething());

            Console.WriteLine();

            Console.WriteLine(@"Rzutowanie obiektów to konwersja obiektu na inny typ.
Można rzutować w dwie strony, według hierarchi dziedziczenia, w górę np. od kota do zwierzęcia, lub w dół np. od zwierzęcia do kota.

Istnieją 3 sposoby rzutowania:
    - Zwykłe: (Typ)Obiekt, który próbuje zakonwertować obiekt, jeżeli jest to niemożliwe to wyrzuca InvalidCastException.
    - Is: Sprawdzające, sprawdza czy dany obiekt należy do typu. Zwraca jedynie bool True / False
    - As: Bezpieczne rzutowanie, jeżeli się nie uda, to zwracany jest null,
    nie można rzutować w ten sposób na typy które nie są nullable");
        }
    }
}