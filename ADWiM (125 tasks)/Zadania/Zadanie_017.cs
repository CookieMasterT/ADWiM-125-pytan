using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_017 : IZadanie
    {
        public int ID { get; set; } = 17;
        public string Text { get; set; } = "17. Opisz pętle w C#.  ";
        public void Execute()
        {
            bool warunek = false;

            for (int i = 0; i < 5; i++)
            {
                
            }

            while (warunek)
            {
            }

            do
            {
                
            }
            while (warunek);

            int[] array = new int[5];
            foreach (var item in array)
            {

            }


            Console.WriteLine(@"W c# (bez bibliotek) znajdują się 4 podstawowe pętle:

- Pętla for
    działa na podstawie: for (inicjalizacja, warunek, zmiana) { kod }
    inicjalizacja wykonuje się przed rozpoczęciem pętli
    warunek jest sprawdzany przed każdą iteracją
    zmiana jest wykonywana po każdej iteracji

    Najczęstszym użyciem pętli for jest iterowanie x razy czyli np.:
    for (int i = 0; i < 5; i++) {}

- Pętla while
    działa według: while (warunek) { kod }
    warunek jest sprawdzany przed każdym wykonaniem kodu.
    
    czasami się używa while (true) {} aby zdefiniować pętle która działa bez końca

- Pętla do while
    działa według: do { kod } while (warunek);
    Identyczna do pętli while ale warunek jest sprawdzany po wykonaniu kodu zamiast przed jego wykonaniem
    Jedynym skutkiem ubocznym tego jest to że pętla zawsze będzie wykonana conajmniej 1 raz

- Pętla for each
    działa według: foreach (typ zmienna in kolekcja) { kod }
    Iteruje po każdym elemencie w kolekcji.
    W każdej iteracji zmiennna przyjmuje wartość kolejnego elementu z kolekcji.
    Podczas działania pętli nie można zmieniać kolekcji po której się iteruje.
    ");
        }
    }
}