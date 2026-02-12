using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_118 : IZadanie
    {
        public int ID { get; set; } = 118;
        public string Text { get; set; } = "118. Czym jest biblioteka Parallel? Jakie metody oferuje?  ";
        public void Execute()
        {
            Console.WriteLine(@"Biblioteka Parallel pozwala wykonywać wiele funkcji równocześnie, wykorzystując wszystkie dostępne zasoby procesora.
Oferuje ona metody którę są równoległą wersją pętli:
    - Parallel.For, to pętla jest odpowiednik pętli for.
    - Paraller.ForEach, to jest odpowiednik pętli ForEach
Wszystkie elementy pętli są przetwarzane równolegle, ale kolejność ich wykonania nie jest gwarantowana.

Biblioteka Parallel wykorzystuje ThreadPool do zarządania swoimi wątkami, co wzbogaca jej wydajność.");
        }
    }
}