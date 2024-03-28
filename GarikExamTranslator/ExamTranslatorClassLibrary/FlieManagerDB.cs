using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTranslatorClassLibrary
{
    public class FileManagerDB : IFileManager
    {
        static SQLiteConnection connection = new SQLiteConnection("Data Source=..\\..\\Resources\\Database\\NewExamTranslatorDB.db;" +
                "Version=3; FailIfMissing=False");
        static SQLiteCommand command;

        List<string> currentWordList;
        List<string> currentTranslationList;
        List<string> currentGroupList;
        string wordToAdd;


        public void SaveData(WordListClass Data)
        {
            currentWordList = new List<string>();
            currentTranslationList = new List<string>();
            currentGroupList = new List<string>();
            for (int i = 1; i < Data.GetWordListCount(); i++)
            {
                WordClass ZWord = Data.GetWordByIndex(i);
                currentWordList.Add(ZWord.Word);
                currentTranslationList.Add(ZWord.Translation);
                currentGroupList.Add(ZWord.Group);
            }

            connection.Open();

            command = new SQLiteCommand(connection)
            {
                CommandText = "INSERT OR IGNORE INTO \"Words\"(\"word\") VALUES(\" " + wordToAdd + " \") "
            };
            foreach (string word in currentWordList)
            {
                wordToAdd = word;
                command.ExecuteNonQuery();
            }

            command = new SQLiteCommand(connection)
            {
                CommandText = "INSERT OR IGNORE INTO \"Translations\"(\"translation\") VALUES(\"" + wordToAdd + "\")"
            };
            foreach (string word in currentTranslationList)
            {
                wordToAdd = word;
                command.ExecuteNonQuery();
            }

            command = new SQLiteCommand(connection)
            {
                CommandText = "INSERT OR IGNORE INTO \"Groups\"(\"group\") VALUES(\"" + wordToAdd + "\")"
            };
            foreach (string word in currentGroupList)
            {
                wordToAdd = word;
                command.ExecuteNonQuery();
            }

            connection.Close();

        }

        public WordListClass LoadData() 
        {
            WordListClass WordList = new WordListClass();

            connection.Open();

            command = new SQLiteCommand(connection)
            {
                CommandText = "SELECT \"Words\".\"word\", \"Translations\".\"translation\", \"Groups\".\"group\" FROM WordsAndTranslations\r\n" +
                "LEFT JOIN \"Words\" ON \"Words\".\"id\" = \"WordsAndTranslations\".\"Word\"\r\n" +
                "LEFT JOIN \"Translations\" ON \"Translations\".\"id\" = \"WordsAndTranslations\".\"translation\"\r\n" +
                "LEFT JOIN \"Groups\" ON \"Groups\".\"id\" = \"WordsAndTranslations\".\"group\";"
            };
            DataTable data = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(data);
            foreach (DataRow row in data.Rows)
            {
                WordList.AddWord(row.Field<String>("word"), row.Field<String>("translation"), row.Field<String>("group"));
            }

            connection.Close();
            return WordList;
        }
    }

}
