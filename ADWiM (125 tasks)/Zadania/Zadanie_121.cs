using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_121 : IZadanie
    {
        public int ID { get; set; } = 121;
        public string Text { get; set; } = "121. Opisz rolę synchronizacji kodu równoległego – dlaczego jest ona potrzebna, kiedy z niej skorzystać, kiedy można przesadzić?  ";
        public void Execute()
        {
            Console.WriteLine(@"Synchronizacja kodu równoległego jest techniką która ma na celu zapobiec nieprzewidywalności związanej z równoległością.
Potrzebna jest ona kiedy wiele wątków operuje na wspólnym elemencie, np. kolekcja, plik czy zmienna.
Gdyby nie zastosowano synchronizacji to taki element może się znaleźć w nieprzewidywalnym stanie z powodu spierania się o wspólny zasób.

Korzysta się z synchronizacji kiedy jest potrzebne zagwarantowanie kolejności działania wątków lub ich wyłączności przy operowaniu na danym elemencie.
Jednak nie jest to potrzebne (traci wydajność) kiedy wątki działają na niezależnych od siebie elementach lub kiedy korzystamy na rzeczach bezpiecznych wątkowo");
        }
    }
}