using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_091 : IZadanie
    {
        public int ID { get; set; } = 91;
        public string Text { get; set; } = "91. Czym są atrybuty? Opisz ich rolę i sposób działania.  ";
        public void Execute()
        {
            Console.WriteLine(@"Atrybuty to dodatkowe informacje przechowywane przez większość elementów programu.
Deklaruje się je przy użyciu nawiasów kwadratowych, najczęściej przed danym elementem.

Wszystkie atrybute muszą być stałymi kompilacji.

Atrybuty są przeznaczone dla systemów zewnętrznych aby wiedzieć jak traktować twój kod
(np. jak nazwać polę przy generowaniu pliku JSON).
Atrybuty same w sobie nic nie robią, są tylko informacją do uzyskania przez refeksję");
        }
    }
}