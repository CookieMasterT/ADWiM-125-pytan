using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_044 : IZadanie
    {
        public int ID { get; set; } = 44;
        public string Text { get; set; } = "44. Czym jest (i kiedy jest możliwe), jak działa nadpisywanie metod?  ";

        private class KlasaBazowa
        {
            public void MetodaZwykla() { }
            public virtual void MetodaWirtualna() 
            {
                Console.WriteLine("Metoda wirtualna z klasy bazowej");
            }
        }

        private class KlasaPochodna : KlasaBazowa
        {
            // public override void MetodaZwykła() { } // you can't override a normal method
            public override void MetodaWirtualna() // if override keyword is omitted, it is not overriding but hiding the base method
            {
                Console.WriteLine("Metoda wirtualna z klasy pochodnej");
            } 
            public void Bonus() 
            {
                Console.WriteLine("AAAA");
            }
        }
        public void Execute()
        {
            KlasaBazowa KBazowaBazowa = new KlasaBazowa();
            KlasaBazowa KBazowaPochodna = new KlasaPochodna(); // Base class that is an instance of the derived class
            KlasaPochodna KPochodna = new KlasaPochodna();
            KBazowaBazowa.MetodaWirtualna();
            KBazowaPochodna.MetodaWirtualna(); // if the method was shadowed instead of overridden, this would call the base class method
            // KBazowaPochodna.Bonus(); // nie ma dostępu do metody Bonus, bo obiekt jest traktowany jako KlasaBazowa
            KPochodna.MetodaWirtualna();

            Console.WriteLine(@"Nadpisywanie metod to jest dostarczenie przez klasę pochodną nowej implementacji dla metody z klasy bazowej.
Można nadpisywać jedynie metody oznaczone jako virtual lub abstract, robi się to poprzez użycie słowa kluczowego ""override"".

Nadpisywanie, w przeciwieństwie do przysłaniania, modyfikuje działanie instniejącej metody w ramach polimorfizmu
Mimo tego że klasa bazowa sama w sobie jest niezmieniona, to utworzenie klasy bazowej jako instancja klasy pochodnej (polimorfizm),
spowoduje że klasa bazowa będzie używała metody nadpisanej, (nie jest ona klasą pochodną i nie ma dostępu do jej metod)");
        }
    }
}