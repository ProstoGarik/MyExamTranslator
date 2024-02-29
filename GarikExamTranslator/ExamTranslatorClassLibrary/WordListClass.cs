using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTranslatorClassLibrary
{
    public class WordListClass
    {
        private List<WordClass> wordList;
        private string wordListString; //Тот же wordList, только в виде строки
        private WordClass targetWord; //"Отмеченное" слово, с которым в дальнейшем происходит редактирование 

        private Random random;

        public WordListClass() {
            WordList = new List<WordClass> { };
            WordListString = "";
            Random = new Random();
        }

        private string MakeFirstUpperCase(string str) // Делает первую букву строки большой, 
        {
            try
            {
                str = str.Insert(0, Char.ToUpper(Convert.ToChar(str[0])).ToString());
                str = str.Remove(1, 1);
                return str;
            }
            catch { return str; } // Если не получается, то возвращает изначальное слово
        }

        public void AddWord(string word, string translation)
        {
            word = word.Trim();
            translation = translation.Trim();
            if (word != "" && translation != "")
            {
                word = MakeFirstUpperCase(word);
                translation = MakeFirstUpperCase(translation);
                wordList.Add(new WordClass(word, translation, wordList.Count));
            }
        }

        public void DeleteByIndex(int index)
        {
            wordList.RemoveAt(index - 1);
            for (int i = 0; i < wordList.Count; i++)
            {
                wordList[i].Index = i;
            }
        }

        public void EditWord(string newWord, string newTranslation)
        {
            wordList[targetWord.Index] = new WordClass(newWord, newTranslation, targetWord.Index);
        }

        public string GenerateWordList()
        {
            WordListString = "";
            foreach (WordClass word in wordList)
            {
                WordListString += (word.Index + 1).ToString() + ") " + word.Word + " - " + word.Translation + "\n";
                //Прибавляет 1 к индексу слова, чтобы список для пользователя не начинался с нуля
            }
            return WordListString;
        }

        public void TargetWordByIndex(int index)
        {
            TargetWord = wordList[index - 1];
        }

        public void ResetTargetWord()
        {
            TargetWord = null;
        }

        public WordClass GetTargetWord()
        {
            if(TargetWord != null)
            {
                return TargetWord;
            }
            else
            {
                return null;
            }
        }

        public WordClass GetWordByIndex(int index)
        {
            return wordList[index - 1];
        }

        public int GetWordListCount()
        {
            return wordList.Count;
        }

        public void RandomizeList()
        {
            int n = wordList.Count;
            while (n > 1)
            {
                n--;
                int k = Random.Next(n + 1);
                WordClass value = wordList[k];
                wordList[k] = wordList[n];
                wordList[n] = value;
            }
        }



        public List<WordClass> WordList { get => wordList; set => wordList = value; }
        public string WordListString { get => wordListString; set => wordListString = value; }
        public WordClass TargetWord { get => targetWord; set => targetWord = value; }
        public Random Random { get => random; set => random = value; }
    }
}
