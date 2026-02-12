using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_034 : IZadanie
    {
        public int ID { get; set; } = 34;
        public string Text { get; set; } = "34. Czym są statyczne konstruktory, właściwości statyczne i metody statyczne? Jaka jest różnica między nimi, a odpowiednikami instancyjnymi?  ";
        
        public void Execute()
        {
            Console.WriteLine(@"Statyczne konstruktory, właściwości i metody zamiast należeć do instancji klasy, należą do samej klasy.

Statyczne konstruktory, są wywoływane przez system przy pierwszym utworzeniu instancji klasy, lub odniesienia się do dowolnego statycznego składnika.
Powoduje to że nie mogą mieć modyfikatorów dostępu, ani parametrów. Są wykonywane tylko 1 raz, zamiast przy każdym utworzeniu obiektu.

Właściwości statyczne należą do samej klasy a nie do żadnej z instancji, dlatego w programie istnieją tylko 1 raz.

Metody statyczne mogą być wywoływane przy odwołaniu do klasy zamiast w odwołaniu do instancji klasy (obiektu).
Metody instancyjne mogą zmieniać właściwości statyczne i instancyjne, a metody statyczne mogą zmieniać tylko właściwości statyczne.");
        }
    }
}