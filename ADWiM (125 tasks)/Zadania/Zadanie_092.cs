using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_092 : IZadanie
    {
        public int ID { get; set; } = 92;
        public string Text { get; set; } = "92. Jak i kiedy tworzymy własne atrybuty?  ";

        [AttributeUsage(AttributeTargets.Class)]
        private class MyExampleAttribute : Attribute
        {
            public string Info { get; }
            public MyExampleAttribute(string info)
            {
                Info = info;
            }
        }

        [MyExampleAttribute("To jest przykład użycia atrybutu")]
        private class Example { }

        public void Execute()
        {
            Console.WriteLine(@"Aby utworzyć własny atrybut trzeba:
    - Utworzyć klasę dziedziczącą po Attribute.
    - Nadać jej informację (właściwości, pola) i konstruktor (inaczej nie można tych informacji nadać)
    - Użyc AttributeUsage aby zadeklarować gdzie można użyć tego atrybutu
        - Aby to zrobić trzeba w nawiasach kwadratowych wywołać AttributeUsage i podać jej AttributeTargets.[...] jako parametry
        - Domyślna wartość to jest możliwość dopisania atrybutu do dowolnego celu.");
        }
    }
}