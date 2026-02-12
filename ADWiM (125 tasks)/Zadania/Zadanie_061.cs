using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_061 : IZadanie
    {
        public int ID { get; set; } = 61;
        public string Text { get; set; } = "61. W jaki sposób obsłużyć wyjątki?  ";
        public void Execute()
        {
            try
            {
                int n = 5 - 5;
                int a = 10 / n;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine();

            Console.WriteLine(@"Wyjątki obsługuje się używając bloku try {} catch () {}.
W bloku try znajduje się kod który może wywołać wyjątek, a bloki catch ten wyjątek będą wyłapywały i wtedy wykonają kod w sobie zawarty.

Można użyć kilka bloków catch, ale muszą one wyłapywać różne wyjątki, definiując do tego typ.
Jest dopuszczalne wyłapanie ogólnego wzorca Exception.

Przy obsłudze wyjątków powinno się przekazać (zazwyczaj używająć throw, lub innego debugu) informację o wyjątku do programisty i użytkownika.");
        }
    }
}