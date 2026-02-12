using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_005 : IZadanie
    {
        public int ID { get; set; } = 5;
        public string Text { get; set; } = "5. Opisz różnicę między float, double i decimal.  ";
        public void Execute()
        {
            float floatVar = 0.1f;
            double doubleVar = 0.12d;
            decimal decimalVar = 0.123m;
            Console.WriteLine("Wielkość float: " + sizeof(float));   // 4 bytes
            Console.WriteLine("Wielkość double: " + sizeof(double));  // 8 bytes
            Console.WriteLine("Wielkość decimal: " + sizeof(decimal)); // 16 bytes
            Console.WriteLine($"0,1f + 0,2f = {0.1f + 0.2f}f");
            Console.WriteLine($"0,1d + 0,2d = {0.1d + 0.2d}d");
            Console.WriteLine($"0,1m + 0,2m = {0.1m + 0.2m}m");
            Console.WriteLine(@"float, double i decimal służą do przechowywania zmiennych zmienno przecinkowych,
różnią się jednak:
1. Wielkością
    float: 4 bajty = 32 bity.
    double: 8 bajtów = 64 bity - pozwala to na zwiększoną precyzję w porównaniu do float.
    decimal: 16 bajtów = 128 bitów
2. Sposobem przechowywania:
    float i double są typami binarnymi czyli przechowują liczbę jako wielokrotność 2
    może to powodować problemy z precyzją operacji zmienno przecinkowych
    0.1 + 0.2 = 0.30[...]01
    ponieważ część liczb nie zawsze da się dokładnie przedstawić w systemie binarnym.
    decimal jest jednak typem dziesiętnym opartym na potęgach 10.
3. Sufiksem
    float: 0.1f
    double: 0.12d
    decimal: 0.123m");
        }
    }
}