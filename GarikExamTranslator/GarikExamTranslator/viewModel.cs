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
        private List<WordClass> wordList;
        public WordClass workinWithWord;

        public viewModel() 
        {
            wordList = new List<WordClass>();
        }

        public void AddWord(string word, string translation) 
        {
            wordList.Add(new WordClass(word,translation, wordList.Count));
        }

        public string GenerateWordList()
        {
            string wordListString = "";
            foreach (WordClass word in wordList) 
            {
                wordListString += (word.Index).ToString() + ") " + word.Word + " - " + word.Translation + "\n";
            }
            return wordListString;
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

        public void ClearWorkinWithWord()
        {
            workinWithWord = new WordClass();
        }
    }
}
