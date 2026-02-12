using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_003 : IZadanie
    {
        public int ID { get; set; } = 3;
        public string Text { get; set; } = "3. Jaka jest różnica między int a Int32?  ";
        public void Execute()
        {
            Console.WriteLine("Wielkość int: " + sizeof(int));
            Console.WriteLine("Wielkość int32: " + sizeof(Int32));
            Console.WriteLine(@"Int i Int32 obie są wartościami integer zajmującymi 32 bity (8 * 4 bajty),
Funkcjonalnie są identyczne
użycie int32 jest preferowane kiedy chcesz (dla czytelności kodu) podkreślić wielkość int
a użycie int kiedy chcesz utworzyć po prostu integer");
        }
    }
}