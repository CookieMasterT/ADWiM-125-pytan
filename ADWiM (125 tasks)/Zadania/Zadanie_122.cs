using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_122 : IZadanie
    {
        public int ID { get; set; } = 122;
        public string Text { get; set; } = "122. Wymień sposoby synchronizacji kodu – lock, semafory, kolekcje bezpieczne wątkowo – nie zapomnij że lock to ryzyko deadlock, kiedy?.  ";
        public void Execute()
        {
            Console.WriteLine(@"Mechanizmy synchronizacji kodu to:
    - Lock, blok kodu który jest zablokowany obiektem Lock, może być trzymany tylko poprzez jeden wątek który ten Lock trzyma.
    Dowolny wątek spróbuje wejść do kodu z lock, i jeżeli mu się to uda to zajmie lock i zwolni tylko po wyjściu z bloku kodu.

    Deadlock to jest sytuacja w której wątek oczekuję na operację która by została wykonana przez drugi wątek,
    ale drugi wątek aby zakończyć tą operacją musi poczekać na operację która by została wykonana przez pierwszy wątek,
    powoduje to zamrożenie obu wątków, dzieje się tak jeżeli się spróbuje zwolnić wątek trzymający Lock,
    poprzez użycia await w bloku zabezpieczonym przez Lock.

    - Semafor, jest to mechanizm który ogranicza ilość wątków które mogą wejść do danego bloku kodu,
    w przeciwieństwie do lock jest on bezpieczny wraz z operacjami asynchronicznymi ponieważ zamiast być obiektem który będzie trzymany przez wątek,
    to działa na zasadzie liczników, które liczą ilość wątków operujących w bloku kodu.

    - Kolekcje bezpieczne wątkowo, są to kolekcje które pozwalają na operację z wielu wątków jednocześnie,
    z powodu posiadania synchronizacji, są one bardziej wymagające obliczeniowo.");
        }
    }
}