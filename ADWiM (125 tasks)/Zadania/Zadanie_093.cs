using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_093 : IZadanie
    {
        public int ID { get; set; } = 93;
        public string Text { get; set; } = "93. Opisz istotę refleksji – możliwe zastosowania, ryzyka, ograniczenia związane z refleksją. Jaki powoduje ona narzut obliczeniowy?  ";
        public void Execute()
        {
            Console.WriteLine(@"Refleksja to jest mechanizm który pozwala programowi pracować na detalach własnej implementacji.
Pozwala to uzyskać informację dostępne samemu programowi zamiast informacji dostępnych z perspektywy metody.

Najczęściej się używa refleksji w narzędziach do analizy i generowania kodu.
Można również użyć refleksji aby znajdywać klasy w projekcie lub odczytywać atrybuty.

Kod który używa refleksję zazwyczaj jest trudniejszy do debugowania.
Refleksja omija mechanizmy bezpieczeństwa związane z hermetyzacją i działa poza typami.

Posiada ona również duży narzut obliczeniowy - kod może być od 10 do 100 razy wolniejszy niż zwykły dostęp.");
        }
    }
}