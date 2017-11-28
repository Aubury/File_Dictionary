//Задача:
//Создать интерактивный словарь неправильных глаголов.
//Пользователь должен иметь возможность вводить глаголы в 1й форме,
//в ответ на экране отображается 2я и 3я формы и перевод.
//Если слово не найдено в словаре - сообщать об этом пользователю.
//Приложение должно работать до тех пор, пога не будет введен символ или слово для завершения работы

//Особенности реализации:
//1) В качестве источника данных использовать класс IrregularVerbsRepository
//1a) Класс IrregularVerbsRepository должен получать список слов из файла..\Dictionary\Data\IrregularVerbs.txt

//2) Создать класс описывающий одну словарную статью.
//     Он должен содержать 3 свойства для каждой формы + 1 свойство для перевода
//3) Для хранения словаря и поиска по нему использовать коллекцию Dictionary<ключ, словарная_статья>,
//     где ключ - глагол в 1й форме, а словарная_статья - класс, созданный в п.2
//4) При запуске приожения заполнять Dictionary используя IrregularVerbsRepository



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

