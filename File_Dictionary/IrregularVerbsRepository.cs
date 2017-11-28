using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Dictionary
{
    class IrregularVerbsRepository
    {

        private static readonly string currentDir = Directory.GetCurrentDirectory();
        private static string newPath = Path.Combine(currentDir, "Data.txt");
        FileInfo fi = new FileInfo(newPath);
        FileStream s = null;
        public  string Data { get; set; }
      public IrregularVerbsRepository()
        {
           if (!fi.Exists)
            {
            try { s = fi.Create(); }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { s?.Close(); }
            using (StreamWriter strReader = fi.CreateText())
            {
                strReader.WriteLine(@"be   was / were  been    быть
                                      beat    beat    beaten  бить
                                      become  became  become  становиться
                                      begin   began   begun   начинать
                                      break   broke broken  ломать
                                      bring   brought brought приносить
                                      build   built built   строить
                                      burn    burnt burnt   гореть
                                      burst   burst burst   взрываться
                                      buy bought bought  покупать
                                      can could - мочь, уметь
                                      catch   caught caught  ловить, хватать
                                      choose  chose chosen  выбирать
                                      come    came come    приходить
                                      cost    cost cost    cтоить
                                      cut cut cut резать
                                      do did done    делать
                                      draw drew    drawn рисовать (карандашом)
                                      drink   drank   drunk   пить
                                      drive   drove   driven  водить(машину)
                                      eat ate eaten   кушать, есть
                                      fall    fell    fallen  падать
                                      feel    felt    felt    чувствовать
                                    fight   fought  fought  сражаться
                                    find    found   found   находить
                                    fly flew    flown   летать
                                    forget  forgot  forgotten   забывать
                                    get got got получать, становиться
                                    give    gave    given   давать
                                    go  went    gone    идти
                                    grow    grew    grown   расти, выращивать
                                    hang    hung    hung    висеть, вешать
                                    have    had had иметь
                                    hear    heard   heard   слышать
                                    hide    hid hidden  прятать
                                    hit hit hit ударять, попадать
                                    hold    held    held    держать
                                    hurt    hurt    hurt    причинять боль
                                    keep    kept    kept    хранить; продолжать делать
                                    know knew    known знать
                                    learn learnt  learnt учить(-ся)
                                    leave   left    left    уезжать, покидать
                                    let let let позволять
                                    lie lay lain    лежать
                                    lose    lost    lost    терять
                                    make    made    made    делать, изготовлять
                                    mean    meant   meant   иметь в виду
                                    meet    met met встречать; знакомиться
                                    pay paid paid    платить
                                    prove   proved proven  доказывать
                                    put put put класть, положить
                                    read    read read    читать
                                    ring    rang rung    звонить
                                    run ran run бегать
                                    say said said    сказать
                                    see saw seen    видеть
                                    set set set cтавить
                                    sew sewed sewn    шить
                                    sell    sold sold    продавать
                                    send    sent sent    отправлять, посылать
                                    shine   shone shone   светить
                                    show    showed shown   показывать
                                    shut    shut shut    закрывать, захлопывать
                                    sing    sang sung    петь
                                    sit sat sat сидеть
                                    sleep   slept slept   спать
                                    speak   spoke spoken  говорить
                                    spend   spent spent   проводить(время)
                                    spoil spoilt  spoilt портить
                                    spread spread  spread расстилать
                                    spring sprang  sprung прыгать
                                    stand stood   stood стоять
                                    steal stole   stolen красть, воровать
                                    swim swam    swum плавать
                                    take took    taken брать
                                    teach taught  taught преподавать, учить
                                    tell told    told сказать (кому - л.)
                                    think   thought thought думать
                                    throw threw   thrown бросать
                                    understand understood  understood понимать
                                    wake woke    woken просыпаться, будить
                                    wear wore    worn носить (одежду)
                                    weep    wept    wept    плакать
                                    win won won побеждать
                                    write   wrote   written писать");
            }
            }
           
        }
       //static void WriteFile()
       // {
            
       // }



        //Todo: Вместо этой константы использовать данные из файла
       // private const string _Data {get;set}

        /// <summary>
        /// Разбивает текст на строки.
        /// Разделитель - символ перевода строки
        /// </summary>
        /// <returns>Массив строк</returns>
        private string[] GetRows()
        {
            using (StreamReader strReader = fi.OpenText())
            {
                   Data = strReader.ReadToEnd();
                return Data.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }
             
                
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
