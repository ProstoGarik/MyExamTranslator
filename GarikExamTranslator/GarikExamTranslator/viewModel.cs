using ExamTranslatorClassLibrary;
using GarikExamTranslator.Custom;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
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

        private PrivateFontCollection fontCollection;
        public IFileManager fileManager;
        private WordListClass wordList;
        private WordListClass wordListForTest;
        public viewModel() 
        {
            fileManager = new FileManagerDB();
            wordList = new WordListClass();
            wordListForTest = new WordListClass();
            Load();
            wordList.ResetTargetWord();
            fontCollection = new PrivateFontCollection();
            fontCollection.AddFontFile("..\\..\\Resources\\Fonts\\vivid_snas\\VividSans-Regular.ttf");
            
        }

        public void AddWord(string word, string translation, string group)
        {
            wordList.AddWord(word, translation, group);
        }

        public void EditWord(string newWord, string newTranslation, string newGroup)
        {
            wordList.EditWord(newWord, newTranslation, newGroup);
            Save();
        }

        public void DeleteWord()
        {
            wordList.DeleteWord();
            Save();
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
            wordList.TargetWordByIndex(index);
        }

        public WordClass GetTargetWord()
        {
            return wordList.GetTargetWord();
        }

        public WordClass GetWordByIndex(int index)
        {
            return wordList.GetWordByIndex(index);
        }

        public int GetWordListCount()
        {
            return wordList.GetWordListCount();
        }

        public void ResetChosenWord()
        {
            wordList.ResetTargetWord();
        }

        public int GetWordGroupsCount()
        {
            return wordList.GetWordGroupsCount();
        }

        public string GetWordGroupNameByIndex(int index) 
        {
            return wordList.GetWordGroupByIndex(index);
        }

        public void CreateTestList()
        {
            wordListForTest = wordList;
            wordListForTest.RandomizeList();
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
            return MakeFirstUpperCase(word1) == MakeFirstUpperCase(word2);
        }

        public void Save()
        {
            fileManager.SaveData(wordList);
        }

        public void Load()
        {
            wordList = fileManager.LoadData();
        }

        public void ApplyFont(Control control)
        {
            control.Font = new System.Drawing.Font(fontCollection.Families[0], control.Font.Size);
        }

        public void DeleteGroup(string group)
        {
            wordList.DeleteGroup(group);
            Save();
        }

        public void MoveLabelButtons(Button editButton, Button deleteButton, MyWordLabel label)
        {
            editButton.Enabled = true;
            editButton.Show();
            deleteButton.Show();
            deleteButton.Enabled = true;
            editButton.Location = new Point(420, label.Location.Y+22);
            deleteButton.Location = new Point(535, label.Location.Y + 22);
        }
    }
}
