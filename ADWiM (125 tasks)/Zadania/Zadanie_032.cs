using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_032 : IZadanie
    {
        public int ID { get; set; } = 32;
        public string Text { get; set; } = "32. Opisz istotę klas wewnętrznych.  ";

        private class klasaZewnętrzna()
        {
            private int i = 0;
            private class klasaWewnętrzna()
            {
                public void ZmianaZewnetrzna(klasaZewnętrzna KZ)
                {
                    KZ.i = 10; // klasa wewnętrzna ma dostęp do pól klasy zewnętrznej
                }
            }
        }

        public void Execute()
        {
            Console.WriteLine(@"Klasa wewnętrzna to jest klasa która jest zadeklarowana w innej klasie.
Ma to sens przy potrzebie użyciu klas pomocniczych, lub tworzeniu klas które mają sens tylko w kontekście innej klasy.
(np. Ręka człowieka, nie ma sensu poza człowiekiem.)
Zaletą tworzenia klasy wewnętrznej jest ukrycie jej przed innym kodem lub lepsza organizacja kodu.

Warto wspomnieć że klasa zawarta jako część innej klasy ma również dostęp do jej pól prywatnych.");
        }
    }
}