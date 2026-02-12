using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_002 : IZadanie
    {
        public int ID { get; set; } = 2;
        public string Text { get; set; } = "2. Opisz różnicę między typami wartościowymi i referencyjnymi – wymień po 5 przykładów typów, z każdej z kategorii.  ";
        public void Execute()
        {
            Console.WriteLine(
               @"Typy wartościowe przechowują dane bezpośrednio jako część zmiennej,
Typy referencyjne jednak przechowują odniesienie do obiektu w pamięci.

Powoduje to różnice w kopiowaniu danych, w typach wartościowych wartości są przepisywane,
lecz w typach referencyjnych można przechować kilka odniesień do jednego miejsca w pamięci

Przykłady typów wartościowych: int, bool, float, double, char
Przykłady typów referencyjnych: class, string, object, array, delegate"
                );
        }
    }
}