using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_050 : IZadanie
    {
        public int ID { get; set; } = 50;
        public string Text { get; set; } = "50. Opisz sens stosowania interfejsu IEquatable<T>, dlaczego samo Equals() to mało?  ";

        // IEquatable<T> wymaga: bool Equals(T? other);
        private class Przykład : IEquatable<Przykład>
        {
            public int Wartość;
            public bool Equals(Przykład? other)
            {
                if (other is null) return false;
                return this.Wartość == other.Wartość;
            }
        }

        public void Execute()
        {
            Console.WriteLine(@"Interfejs IEquatable<T> Wymaga metodę ""bool Equals (T? other)"".
Różni się to od zwyczajnej metody Equals() typem argumentu, Equals() wymaga typu object,
powoduje to overhead związany z rzutowaniem.

Equals(T? other) z interfejsu IEquatable<T> jest mniej ogólny,
ale będzie on bardziej wydajny jeżeli wiemy że typ obu obiektów jest taki sam.");
        }
    }
}