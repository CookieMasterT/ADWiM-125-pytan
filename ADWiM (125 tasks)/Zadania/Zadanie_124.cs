using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_124 : IZadanie
    {
        public int ID { get; set; } = 124;
        public string Text { get; set; } = "124. Opisz rolę operacji atomowych w kodzie równoległym.  ";
        public void Execute()
        {
            Console.WriteLine(@"Operacja atomowe to są najbardziej podstawowe operację, wykonywane w jednym kroku CPU.
Ponieważ są wykonywane w jednym kroku to są one bezpieczne wątkowo, nie ma możliwości aby kilka wątków mogło interweniować w ich wykonywaniu.

Operacjami atomowymi są podstawowe zapisy i odczyty: referencji, lub prostych typów wartościowych (int, double, bool).

Używanie jedynie operacji atomowych pozwala uniknąć potrzeby synchronizacji wątków wykonywanych równolegle.");
        }
    }
}