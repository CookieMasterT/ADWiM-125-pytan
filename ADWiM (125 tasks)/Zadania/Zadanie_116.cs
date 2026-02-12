using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_116 : IZadanie
    {
        public int ID { get; set; } = 116;
        public string Text { get; set; } = "116. Czym jest oraz jak działa ThreadPool? Jakie niesie ze sobą zalety?  ";
        public void Execute()
        {
            Console.WriteLine(@"ThreadPool to jest dynamicznie zarządzana przez mechanizmy .NET pula wątków.
Polega na automatycznym wyznaczeniu ilości potrzebnych wątków, i przekazywaniu ich do zadań które je potrzebują.
Wątki które zostały wcześniej utworzone będą ponownie użyte.

Zaletą ThreadPool jest wydajność (wątki nie są cały czas tworzone), dynamiczność (ThreadPool balansuje obciążenie i usypia nie używane wątki),
dobre wykorzystanie wszystkich rdzeni, brak ryzyka utworzenia nadmiernej ilości wątków
i łatwość w użyciu (programista nie musi tworzyć dodatkowego kodu aby zarządzać wątkami).
");
        }
    }
}