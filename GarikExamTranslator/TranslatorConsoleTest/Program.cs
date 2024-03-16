using ExamTranslatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorConsoleTest
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            WordListClass myWordList = new WordListClass();
            myWordList.AddWord("TestWord", "ТестСлово");
            Console.WriteLine(myWordList.GetWordListCount());
            Console.WriteLine(myWordList.GetWordByIndex(1).Word);
            Console.WriteLine(myWordList.GetWordByIndex(1).Translation);
            myWordList.TargetWordByIndex(1);
            myWordList.EditWord("TestWordEdited", "ТестСловоРедактировано");
            Console.WriteLine(myWordList.GetWordByIndex(1).Word);
            Console.WriteLine(myWordList.GetWordByIndex(1).Translation);
            myWordList.DeleteWord();
            Console.WriteLine(myWordList.GetWordListCount());
            Console.ReadLine();



        }
    }
}
