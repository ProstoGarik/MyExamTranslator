using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTranslatorClassLibrary
{
    public class UserDataClass
    {
        private string username;
        private int wordsAdded;
        private int completedTests;
        private int perfectTests;

        public UserDataClass()
        {
            Username = "Пользователь";
            WordsAdded = 0;
            CompletedTests = 0;
            PerfectTests = 0;
        }

        public void EditData(string newUsername, int newWordsAdded, int newCompletedTests, int newPerfectTests)
        {
            this.username = newUsername;
            this.wordsAdded = newWordsAdded;
            this.completedTests = newCompletedTests;
            this.PerfectTests = newPerfectTests;
        }
        public string Username { get => username; set => username = value; }
        public int WordsAdded { get => wordsAdded; set => wordsAdded = value; }
        public int CompletedTests { get => completedTests; set => completedTests = value; }
        public int PerfectTests { get => perfectTests; set => perfectTests = value; }
    }
}
