using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Dictionary
{
    class IrregularVerbsRepository
    {
        //Todo: Вместо этой константы использовать данные из файла
        private const string Data = "";

        /// <summary>
        /// Разбивает текст на строки.
        /// Разделитель - символ перевода строки
        /// </summary>
        /// <returns>Массив строк</returns>
        private string[] GetRows()
        {
            return Data.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Преобразует каждую строку в массив слов, разделенных симв. табуляции
        /// </summary>
        /// <returns>Массив массивов</returns>
        public string[][] GetWords()
        {
            var rows = GetRows();
            string[][] words = new string[rows.Length][];

            for (int i = 0; i < rows.Length; i++)
            {
                words[i] = rows[i].Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
            }

            return words;
        }
    }
}
