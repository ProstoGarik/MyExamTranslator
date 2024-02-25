using ExamTranslatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarikExamTranslator
{
    public class viewModel
    {
        public WordClass workinWithWord;

        private List<WordClass> wordList;
        private List<WordClass> wordListForTest;
        private string wordListString = "";
        Random random = new Random();

        public viewModel() 
        {
            wordList = new List<WordClass>();
        }

        public void AddWord(string word, string translation) 
        {
            word = word.Trim();
            translation = translation.Trim();
            if(word != "" && translation != "")
            {
                word = MakeFirstUpperCase(word);
                translation = MakeFirstUpperCase(translation);
                wordList.Add(new WordClass(word, translation, wordList.Count));
            }
            
        }
        public void EditWord(string newWord, string newTranslation)
        {
            wordList[workinWithWord.Index] = new WordClass(newWord, newTranslation, workinWithWord.Index);
        }

        public string GenerateWordList()
        {
            wordListString = "";
            foreach (WordClass word in wordList) 
            {
                wordListString += (word.Index+1).ToString() + ") " + word.Word + " - " + word.Translation + "\n";
            }
            return wordListString;
        }

        public void PreLoadForm(Form form)
        {
            form.Show();
            form.Hide();
        }

        public void FormResizeCloseOpen(Form thisForm, Form newform, bool Close = false)
        {
            newform.Show();
            newform.Size = thisForm.Size;
            newform.Location = thisForm.Location;
            if (Close)
            {
                thisForm.Close();
            }
            else
            {
                thisForm.Hide();
            }
        }

        public void ChooseWordByIndex(int index)
        {
            workinWithWord = wordList[index - 1];
        }

        public WordClass GetWordByIndex(int index, bool isTest = false)
        {
            if(!isTest)
            {
                return wordList[index - 1];
            }
            else
            {
                return wordListForTest[index-1];
            }
        }

        public int GetWordListCount(bool isTest = false)
        {
            if (!isTest)
            {
                return wordList.Count;
            }
            else
            {
                return wordListForTest.Count;
            }
        }

        public void ResetChosenWord()
        {
            workinWithWord = null;
        }

        public void CreateTestList()
        {
            wordListForTest = wordList;
            RandomizeList(wordListForTest);
        }

        private void RandomizeList(List<WordClass> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                WordClass value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private string MakeFirstUpperCase(string str)
        {
            try
            {
                str = str.Insert(0, Char.ToUpper(Convert.ToChar(str[0])).ToString());
                str = str.Remove(1, 1);
                return str;
            }
            catch { return str; }
        }

        public bool CompareWords(string word1, string word2)
        {
            return MakeFirstUpperCase(word1) == MakeFirstUpperCase(word1);
        }




    }
}
