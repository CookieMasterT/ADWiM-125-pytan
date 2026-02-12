using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_117 : IZadanie
    {
        public int ID { get; set; } = 117;
        public string Text { get; set; } = "117. Opisz różnicę między new Thread() oraz Task.Run().  ";
        public void Execute()
        {
            Console.WriteLine(@"new Thread() to jest ręczne utworzenie wątku, a Task.Run() jest sposobem wykorzystania ThreadPool.
Ręczne tworzenie wątków jest niezalecane ponieważ praca na nich jest trudna i nie podlega optymylizacją .NET

Użycie ThreadPool jednak będzie używało wątki z poprzednio przechowanych wątków i będzie dynamicznie zarządzane.");
        }
    }
}