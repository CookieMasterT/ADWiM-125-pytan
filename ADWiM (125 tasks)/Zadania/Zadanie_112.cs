using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_112 : IZadanie
    {
        public int ID { get; set; } = 112;
        public string Text { get; set; } = "112. Czym jest kontekst synchronizacji?  ";
        public void Execute()
        {
            Console.WriteLine(@"Jest to mechanizm który pozwala powrócenie do kodu który znajduję się po await.
Dzięki SynchronizationContext po wykonaniu zadania asynchronicznego które zostało await'owane możemy powrócić do dalszej pracy w tym samym miejscu.");
        }
    }
}