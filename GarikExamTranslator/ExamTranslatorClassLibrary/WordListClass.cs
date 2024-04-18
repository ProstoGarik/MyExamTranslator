using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ExamTranslatorClassLibrary
{
    public class WordListClass
    {
        private List<WordClass> wordList;
        private string wordListString; //Тот же wordList, только в виде строки
        private WordClass targetWord; //"Отмеченное" слово, с которым в дальнейшем происходит редактирование 
        private List<string> wordGroups;
        private bool isEdited;

        [NonSerialized]
        private Random random;

        public WordListClass() {
            WordList = new List<WordClass> { };
            WordListString = "";
            Random = new Random();
            WordGroups = new List<string>();
        }
        private string MakeFirstUpperCase(string str) // Делает первую букву строки большой, 
        {
            str.ToUpper();
            try
            {
                str = str.Insert(0, Char.ToUpper(Convert.ToChar(str[0])).ToString());
                str = str.Remove(1, 1);
                return str;
            }
            catch { return str; } // Если не получается, то возвращает изначальное слово
        }

        public void AddWord(string word, string translation, string group)
        {
            word = word.Trim();
            translation = translation.Trim();
            if (word != "" && translation != "")
            {
                word = MakeFirstUpperCase(word);
                translation = MakeFirstUpperCase(translation);
                WordClass addedWord = new WordClass(word, translation, wordList.Count(), group);
                if (!WordGroups.Contains(group))
                {
                    WordGroups.Add(group);
                }
                wordList.Add(addedWord);
            }

            
        }
        

        public void DeleteWord()
        {
            wordList.RemoveAt(targetWord.Index);
            for (int i = 0; i < wordList.Count; i++)
            {
                wordList[i].Index = i;
            }
            isEdited = true;
        }

        public void EditWord(string newWord, string newTranslation, string newGroup)
        {
            wordList[targetWord.Index] = new WordClass(newWord, newTranslation, targetWord.Index, newGroup);
            if (!WordGroups.Contains(newGroup))
            {
                WordGroups.Add(newGroup);
            }
            isEdited = true;
        }

        public void TargetWordByIndex(int index)
        {
            TargetWord = wordList[index-1];
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

        public string GetWordGroupByIndex(int index)
        {
            return WordGroups[index];
        }
        public int GetWordGroupsCount()
        {
            return WordGroups.Count();
        }



        public List<WordClass> WordList { get => wordList; set => wordList = value; }
        public string WordListString { get => wordListString; set => wordListString = value; }
        public WordClass TargetWord { get => targetWord; set => targetWord = value; }
        public Random Random { get => random; set => random = value; }
        public List<string> WordGroups { get => wordGroups; set => wordGroups = value; }
        public bool IsEdited { get => isEdited; set => isEdited = value; }
    }
}
