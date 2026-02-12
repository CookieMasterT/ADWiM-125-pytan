using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_041 : IZadanie
    {
        public int ID { get; set; } = 41;
        public string Text { get; set; } = "41. Opisz rolę i słowa kluczowego base.  ";

        private class KlasaBazowa
        {
            public int Field;
            public static int StaticField;
            public int PresetField = 10;

            public int Property { get; set; } = 15;
            private void PrivateMethod()
            {
                Console.WriteLine("Lorem ipsum dolor sit");
            }
            public void PublicMethod()
            {
                Console.WriteLine("Lorem ipsum dolor sit");
            }
        }

        private class KlasaPochodna : KlasaBazowa
        {
            public new int Field = 999;
            public static new int StaticField = 999;
            public new int PresetField = 999;

            public new int Property { get; set; } = 999;
            public new void PublicMethod()
            {
                Console.WriteLine("##########################");
            }
            public void UseBaseMembers()
            {
                Console.WriteLine(base.Field); // 0, default value for int
                // Console.WriteLine(base.StaticField); // cannot use base for static members.
                Console.WriteLine(KlasaBazowa.StaticField); // 5, which was set in Execute method
                Console.WriteLine(base.PresetField); // 10, preset value
                Console.WriteLine(base.Property); // 15, preset value

                base.PublicMethod();
                // base.PrivateMethod(); // cannot access private method using base
            }
        }

        public void Execute()
        {
            KlasaBazowa KB = new KlasaBazowa();
            KlasaBazowa.StaticField = 5;
            KB.Field = 123;

            KlasaPochodna KP = new KlasaPochodna();
            KP.UseBaseMembers();

            Console.WriteLine();

            Console.WriteLine(@"Słowo kluczowe base pozwala klasie pochodnej uzyskać dostęp do pól, właściwości, metod lub konstruktorów,
Pochodzących z klasy bazowej. Pozwala to na ponowne użycie kodu nie zatrzymując dodania dodatkowych zachowań.

Klasa pochodna dzięki słowu kluczowemu base może:
    - Używać wartości domyślnych pól lub właściwości klasy bazowej.
    - Uzyskać dostęp do pól i właściwości statycznych od klasy bazowej.
    - Użyć konstruktora z klasy bazowej, również mogąc przekazać mu część parametrów, i potem nadal mieć własny konstruktor.
    - Wywołać metode z klasy bazowej, która została przez klasę pochodną ukryta.");
        }
    }
}