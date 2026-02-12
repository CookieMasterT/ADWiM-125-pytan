using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_049 : IZadanie
    {
        public int ID { get; set; } = 49;
        public string Text { get; set; } = "49. Opisz cztery podstawowe metody obecne w każdym obiekcie – Equals(), GetHashCode(), ToString(), GetType(). Której z metod nie da się nadpisać? Dlaczego?  ";
        public void Execute()
        {
            string a = "Tekst";
            string b = a;
            int[] c = new int[] { 1, 2, 3 };

            Console.WriteLine(a.Equals(b));

            Console.WriteLine(a.GetHashCode());

            Console.WriteLine(c.ToString()); // domyślnie zwraca nazwę typu :)

            Console.WriteLine(a.GetType()); // zwraca nazwę typu

            Console.WriteLine(@"Cztery metody, które są dziedziczone z System.Object, czyli są w każdym obiekcie.
    1. Equals(), sprawdza czy 2 obiekty są referencją do tego samego miejsca, może zostać nadpisane aby sprawdzić czy wartości są takie same.
    2. GetHashCode(), zwraca unikatowy HashCode, czyli skrót obiektu,
    powinienen być taki sam dla identycznych obiektów, ale w każdym innym przypadku być unikatowy.
    Używane przez np. HashSet, do przyrównywania zmiennych.
    3. ToString(), domyślnie zwraca nazwę typu obiektu, może być nadpisany aby zwrócić jego tekstową reprezentację.
    4. GetType(), zwraca nazwę typu, nie można go nadpisać, ponieważ zwraca precyzyjną nazwę typu
    a to zawsze bedzię to bezpośrednie i wykonywane w ten sam sposób, nadpisanie tej metody by mogło zepsuć niektóre mechanizmy języka.");
        }
    }
}