using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_024 : IZadanie
    {
        public int ID { get; set; } = 24;
        public string Text { get; set; } = "24. Opisz słowa kluczowe: ref, out, in.  ";
        public void ExampleRef(ref int x)
        {
            x += 10;
            x = 20;
        }
        public void ExampleOut(out int x)
        {
            //x += 10; // parametr nie istnieje, out nie deklaruje parametru x.
            x = 20; // kod jest nie opcjonalny, out wymaga przypisania zmiennej.
            x += 1;
        }
        public void ExampleIn(in int x)
        {
            //x += 10; // x nie może być przypisany, jest readonly.
            Console.WriteLine(x + 10);
        }
        public void Execute()
        {
            int x = 5;
            ExampleRef(ref x);
            ExampleOut(out x);
            ExampleIn(in x);

            Console.WriteLine();

            Console.WriteLine(@"3 słowa kluczowe: ref, out, in służą do przekazania zmiennej do funkcji, poprzez referencje.
Używa się je poprzez dodanie ich przed deklaracją parametru w definicji funkcji oraz przy wywołaniu funkcji. czyli np.:
    void Metoda(ref int x) {}
    Metoda(ref zmienna);
1. ref, podaje referencje do zmiennej, działa jak normalny parametr ale zmiana tego parametru podczas działania funkcji, zmieni wartość przekazaną.
2. out, nie jest przekazywany jako parametr, ale funkcja musi nadać wartość tej zmiennej, podczas działania funkcji.
3. in, przekazuje wartość do funkcji, ale w trybie readonly, czyli zatrzymuję funkcję przed modyfikacją parametru.
Zaletą używania in, jest uniknięcie kopiowania danych, można podać referencje, co jest szczególnie użyteczne przy dużej ilości danych.");
        }
    }
}