using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_069 : IZadanie
    {
        public int ID { get; set; } = 69;
        public string Text { get; set; } = "69. Kiedy program powinien rzucać wyjątek?  ";
        public void Execute()
        {
            Console.WriteLine(@"Dopuszczalne jest rzucenie (manualne) wyjątku kiedy:
    - Jest błąd w programie który spowodował sytuację bez sensu, i musi ten błąd być jaśnie oznaczony aby móc naprawić usterkę.
    (kod typu, you shouldn't get here. default: w switch'u który powinienen obsłużyć wszystkie wypadki etc.)
    - Dane lub informację przekazane programowi są nie poprawne lub nie spójne (nie można na nich pracować)
    - Błąd ma znaczenie w innej części programu i trzeba go obsłużyć.
    - Program spróbował dokonać niemożliwej akcji np. wypłacenie ujemnej kwoty.");
        }
    }
}