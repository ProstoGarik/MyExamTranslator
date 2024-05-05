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
        private long appStarted;

        public UserDataClass()
        {
            Username = "Пользователь";
            WordsAdded = 0;
            CompletedTests = 0;
            PerfectTests = 0;
            imagePath = string.Empty;
            AppStarted = 0;
        }

        public UserDataClass(string username, long wordsAdded, long completedTests, long perfectTests, string imagePath, long appStarted)
        {
            Username = username;
            WordsAdded = wordsAdded;
            CompletedTests = completedTests;
            PerfectTests = perfectTests;
            ImagePath = imagePath;
            AppStarted = appStarted;
        }

        public string Username { get => username; set => username = value; }
        public long WordsAdded { get => wordsAdded; set => wordsAdded = value; }
        public long CompletedTests { get => completedTests; set => completedTests = value; }
        public long PerfectTests { get => perfectTests; set => perfectTests = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
        public long AppStarted { get => appStarted; set => appStarted = value; }

        public void EditData(string newUsername, long newWordsAdded, long newCompletedTests, long newPerfectTests, string newImagePath, long newAppStarted)
        {
            this.Username = newUsername;
            this.WordsAdded = newWordsAdded;
            this.CompletedTests = newCompletedTests;
            this.PerfectTests = newPerfectTests;
            this.ImagePath = newImagePath;
            this.AppStarted = newAppStarted;
        }
    }
}
