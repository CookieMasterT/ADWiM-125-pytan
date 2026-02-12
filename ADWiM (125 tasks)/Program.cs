using ADWiM__125_tasks_.Zadania;
using System.Reflection;

namespace ADWiM__125_tasks_
{
    internal class Program
    {
        public static int QuizModeRange = -1; // Ustaw na -1, aby wyłączyć tryb quizu
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var commands = Assembly.GetExecutingAssembly().GetTypes()
               .Where(t => typeof(IZadanie).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
               .Select(t => Activator.CreateInstance(t) as IZadanie)
               .OrderBy(t => t.ID)
               .ToList();

            for (int i = 0; i < commands.Count; i++)
            {
                Console.WriteLine($"{commands[i].Text}");
            }

            string ID = "";

            Random rng = new Random((int)DateTime.Now.Ticks);
;
            List<int> possibleQuizOptions = [];

            if (QuizModeRange == -1)
            { 
                Console.Write("\nPodaj numer zadania: ");
                ID = Console.ReadLine();
            }
            else
            {
                possibleQuizOptions = new List<int>();
                for (int i = 1; i <= QuizModeRange && i < commands.Count; i++)
                {
                    possibleQuizOptions.Add(i);
                }
            }

            do
            {
                if (possibleQuizOptions.Count > 0)
                {
                    int randomIndex = rng.Next(possibleQuizOptions.Count);
                    ID = possibleQuizOptions[randomIndex].ToString();
                    Console.WriteLine("\nNaciśnij dowolny klawisz, aby kontynuować");
                    Console.ReadKey();
                }

                if (int.TryParse(ID, out int index) && index >= 0 && index <= commands.Count)
                {
                    Console.Clear();
                    string Header = $"--- Zadanie {ID} ---";
                    Console.WriteLine(Header);
                    Console.WriteLine($"{commands[int.Parse(ID)].Text}");
                    for (int i = 0; i < Header.Length; i++) Console.Write("-");
                    Console.WriteLine("\n");
                    if (QuizModeRange != -1)
                    {
                        if (possibleQuizOptions.Count > 0)
                        {
                            possibleQuizOptions.Remove(index);
                        }
                        Console.WriteLine("Naciśnij dowolny klawisz, aby zobaczyć rozwiązanie...");
                        Console.ReadKey();
                        Console.WriteLine("\n");
                    }
                    commands[index].Execute();
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy numer zadania.");
                }
            } while (possibleQuizOptions.Count > 0);
        }
    }
}
