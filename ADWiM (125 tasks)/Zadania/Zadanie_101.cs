using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_101 : IZadanie
    {
        public int ID { get; set; } = 101;
        public string Text { get; set; } = "101. Opisz znaczenie wątku UI.  ";
        public void Execute()
        {
            Console.WriteLine(@"Wątek UI ma za zadanie zapewnić aktywność każdej części frontend'u.
Obsługuje on akcje użytkownika (wpisywany tekst, kliknięcia, sterowanie) jak i renderowanie,
czyli graficzną reprezentację widoczną dla użytkownika.

Jest on ważny ponieważ zatrzymanie lub spowolnienie go automatycznie spowoduje zatrzymanie aplikacji z perspektywy użytkownika.");
        }
    }
}