using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_046 : IZadanie
    {
        public int ID { get; set; } = 46;
        public string Text { get; set; } = "46. Czym są i jak działają klasy abstrakcyjne? Podaj sens ich istnienia.  ";

        private abstract class Zwierzę()
        {
            public abstract void Ukradnij();
        }

        private class Kot() : Zwierzę
        {
            public override void Ukradnij() // metoda abstrakcyjna musi być nadpisana w klasie dziedziczącej
            {
                Console.WriteLine("Kotek podbiega i zabiera wełnę c:");
            }
        }

        public void Execute()
        {
            // Zwierzę zwierzę = new Zwierzę(); // nie można utworzyć instancji klasy abstrakcyjnej
            Zwierzę kot = new Kot();

            Console.WriteLine(@"Klasy abstrakcyjne to klasy które nie mogą mieć własnych instancji, czyli nie można utworzyć na ich podstawie obiektu.
Mogą one deklarować metody abstrakcyjne, są to metody które nie mogą mieć zdefiniowanej implementacji,
ale w klasach pochodnych muszą zostać zaimplementowane (poprzez nadpisanie, sł. kl. override)

Klasy abstrakcyjne istnieją aby pozwolić na utworzenie szablonu klasy, jednocześnie nie pozwalając na utworzenie obiektu według samego szablonu.
Taki szablon pozwala na współdzielenie kodu, łatwiejszą jego rozbudowe, i utworzenie wzorca (nie można o niczym zapomnieć).");
        }
    }
}