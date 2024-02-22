using ExamTranslatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarikExamTranslator
{
    public class viewModel
    {
        public WordClass workinWithWord;

        private List<WordClass> wordList;
        private string wordListString = "";

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
                try
                {             
                    word = word.Insert(0, Char.ToUpper(Convert.ToChar(word[0])).ToString());
                    translation = translation.Insert(0, Char.ToUpper(Convert.ToChar(translation[0])).ToString());
                    word = word.Remove(1, 1);
                    translation = translation.Remove(1, 1);
                }
                catch { }
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

        public WordClass GetWordByIndex(int index)
        {
            return wordList[index-1];
        }

        public void ResetChosenWord()
        {
            workinWithWord = null;
        }

        private void tryFirstCharUpper(string word, string translation)
        {

        }
    }
}
