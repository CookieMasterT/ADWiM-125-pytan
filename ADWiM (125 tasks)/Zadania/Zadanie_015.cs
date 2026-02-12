using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class Zadanie_015 : IZadanie
    {
        public int ID { get; set; } = 15;
        public string Text { get; set; } = "15. Opisz operatory @ i $ przy tworzeniu zmiennej typu string.  ";
        public void Execute()
        {
            int someValue = 10;
            Console.WriteLine($"someValue to: {someValue}");

            Console.WriteLine(@"Operator @ to string verbatim, powoduje on dosłowną interpretację tekstu w @""""
    - Znak \ Nie jest intepretowany jako escape character
    - Można osadzić "" używając """" 
    - Można utworzyć tekst z specjalnymi znakami bez używania znaków specjalnych (np. nie potrzebujesz \n aby utworzyć koniec linijki)
Operator $ to string interpolowany, umożliwia on wstawianie wartości zmiennych lub wyrażeń bezpośrednio w tekście
    - Dowolna wartość która jest stringiem lub może do niego być wyewaluowana w nawiasach klamrowych - {}
      Staję się częścią stringa np. string imie = ""Kacper""; string wiadomość = $""Witam {imie}"";");
        }
    }
}