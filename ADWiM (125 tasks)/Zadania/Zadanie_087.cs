using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_087 : IZadanie
    {
        public int ID { get; set; } = 87;
        public string Text { get; set; } = "87. Czym są oraz w jaki sposób są konstruowane wyrażenia lambda?  ";
        public void Execute()
        {
            var a = delegate (int x) { return x; };
            Func<int, int> b = x => x;

            Console.WriteLine(@"Funkcje lambda to jest szybszy syntax do zadeklarowania typów zwracanych i ciała funkcji.
Zamiast:
    delegate(int x) { return x; }
Można zamienić to na funkcję lambda:
    x => x
gdzie typ zwracany jest wywnioskowany z kontekstu (np. zadeklarowanych typach w delegacie)
i => to jest operator funkcji lambda, jeżeli zadeklarowany blok zwraca typ będzie on skrótem do return.
W funkcjach lambda nadal jest dozwolone zadeklarowanie bloku w nawiasach klamrowych {}.");
        }
    }
}