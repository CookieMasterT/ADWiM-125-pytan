using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_067 : IZadanie
    {
        public int ID { get; set; } = 67;
        public string Text { get; set; } = "67. W jaki sposób rzucić wyjątek? – użycie słowa kluczowego throw.  ";
        public void Execute()
        {
            Console.WriteLine(@"Aby rzucić (wywołać) wyjątek trzeba użyć słowa kluczowego throw wraz z obiektem Exception.
Obiekt Exception może zostać utworzony poprzez konstruktor wraz z new lub zostać wyłapany w try catch.

Rzucanie wyjątku bezpośrednio z try catch jednak zgubi nam stacktrace ponieważ zostanie utworzony nowy wyjątek.");
        }
    }
}