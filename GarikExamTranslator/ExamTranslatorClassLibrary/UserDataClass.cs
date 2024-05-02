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
        private long wordsAdded;
        private long completedTests;
        private long perfectTests;
        private string imagePath;

        public UserDataClass()
        {
            Username = "Пользователь";
            WordsAdded = 0;
            CompletedTests = 0;
            PerfectTests = 0;
            imagePath = string.Empty;
        }

        public string Username { get => username; set => username = value; }
        public long WordsAdded { get => wordsAdded; set => wordsAdded = value; }
        public long CompletedTests { get => completedTests; set => completedTests = value; }
        public long PerfectTests { get => perfectTests; set => perfectTests = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }

        public void EditData(string newUsername, long newWordsAdded, long newCompletedTests, long newPerfectTests, string newImagePath)
        {
            this.Username = newUsername;
            this.WordsAdded = newWordsAdded;
            this.CompletedTests = newCompletedTests;
            this.PerfectTests = newPerfectTests;
            this.imagePath = newImagePath;
        }
    }
}
