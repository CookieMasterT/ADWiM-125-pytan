using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_063 : IZadanie
    {
        public int ID { get; set; } = 63;
        public string Text { get; set; } = "63. W jaki sposób obsłużyć różne typy wyjątków? – wiele bloków catch.  ";
        public void Execute()
        {
            try
            {
            }
            catch (Exception ex) when (ex is NullReferenceException or DivideByZeroException)
            {
            }
            catch (Exception)
            {
            }

            Console.WriteLine(@"Po uzyciu bloku try, można dodać dowolną ilość bloków catch każdy z własnym wzorcem.
Jedynym ograniczeniem jest to, że każdy typ wzorca może zaistnieć tylko 1 raz.

Każdy blok catch jest sprawdzany po kolei, i jeżeli wzorzec pasuje do wyjątku, to ten blok zostaje wykonany.

Dobrą praktyką jest wstawienie bloków catch z najczęstszymi błędami jako pierwsze a ogólny wzorzec Exception jako ostatni.");
        }
    }
}