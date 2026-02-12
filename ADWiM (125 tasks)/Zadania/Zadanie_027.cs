using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_027 : IZadanie
    {
        public int ID { get; set; } = 27;
        public string Text { get; set; } = "27. Opisz rolę oraz dostępne modyfikatory dostępu w C#.  ";
        public void Execute()
        {
            PodstawowaKlasa PK = new PodstawowaKlasa();
            PK.a = 1; // public, Dostępne
            PK.b = 2; // internal, Dostępne
            //PK.c = 3; // protected, Niedostępne
            //PK.d = 4; // private, Niedostępne

            //gdybym załadował tą klasę w innym projekcie, to internal też by był niedostępny

            Console.WriteLine(@"Modyfikatory dostępu mają za zadanie zapewnić enkapsulację kodu, czyli ukrycie implementacji.
Pozwala to napisać kod niezawodny i bardziej przewidywalny, ponieważ będzie on odporny na zewnętrzną interwencje.

Modyfikatory dostępu mogą ukrywać: metody, klasy, pola, właściwości i interfejsy.

Dostępne modyfikatory dostępu to:
    - Public, brak ograniczeń dostępu.
    - Internal, dostęp jest ograniczony do bieżącego zestawu.
    - Protected, dostęp jest ograniczony do zawierającej klasy lub typów pochodnych.
    - Private, dostęp tylko typu zawierającego.
Można je również łączyć:
    - Protected internal, dostęp jest ograniczony do bieżącego zestawu lub typów pochodnych
    - Private protected, dostęp jest ograniczony do zawierającej klasy lub typów pochodzących z zawierającej klasy w tym samym zestawie");
        }
        private class PodstawowaKlasa()
        {
            public int a = 0;
            internal int b = 0;
            protected int c = 0;
            private int d = 0;
        }
        private class DziedziczacaKlasa : PodstawowaKlasa
        {
            public void Test()
            {
                a = 1; // public, Dostępne
                b = 1; // internal, Dostępne
                c = 1; // protected, Dostępne
                //d = 1; // private, Niedostępne
            }
        }
    }
}