import re
import os


def split_tasks(input_file):
    # Read the content of Tasks.txt
    try:
        with open(input_file, 'r', encoding='UTF-8') as f:
            content = f.read()
    except FileNotFoundError:
        print(f"Error: {input_file} not found.")
        return

    # Use regex to find all tasks.
    # It looks for a number, a dot, then everything until the next number/dot.
    # Pattern: (\d+)\.\s*(.*?)(?=\s*\d+\.|$|$)
    tasks = re.findall(r'\d+\.\s*(.*?)(?=\s*\d+\.|$)', content, flags=re.DOTALL)

    # Create the output files
    for i, task_text in enumerate(tasks, start=1):
        filename = f"Zadanie_{i:03d}.cs"
        with open("Zadania\\" + filename, 'w', encoding="UTF-8") as f:
            f.write(
"""using System;
using System.Collections.Generic;
using System.Text;

namespace ADWiM__125_tasks_.Zadania
{
    public class """ + f"Zadanie_{i:03d}" + """ : IZadanie
    {
        public int ID { get; set; } = """ + str(i) + """;
        public string Text { get; set; } = \"""" + str(i) + ". " + task_text.strip() + """  ";
        public void Execute()
        {
            Console.WriteLine(@"");
        }
    }
}""")
        print(f"Created: {filename}")


if __name__ == "__main__":
    print("a")
    split_tasks("Zadania.txt")
