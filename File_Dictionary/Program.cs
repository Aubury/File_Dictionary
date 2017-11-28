using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример использования репозитария
            IrregularVerbsRepository repo = new IrregularVerbsRepository();
            var verbs = repo.GetWords();

            Dictionary<string, Irregular_verbs> row_verbs = new Dictionary<string, Irregular_verbs>();
            foreach (var i in verbs)
            {
                row_verbs.Add(i[0], new Irregular_verbs(i[0], i[1], i[2], i[3]));
            }
            foreach (var i in row_verbs)
            {
                Console.WriteLine($"{i.ToString()}\n");
            }


            do
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Input verb : \n");
                var value = Console.ReadLine();

                if (row_verbs.ContainsKey(value))
                {
                    Console.WriteLine($"{ row_verbs[value]}");
                }
                else
                {
                    Console.WriteLine($"Key = \\ {value} \\ is not found.");
                }

            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
    }
}
