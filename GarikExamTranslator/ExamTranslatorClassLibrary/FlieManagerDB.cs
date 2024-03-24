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


        public void SaveData(WordListClass Data)
        {
            connection.Open();

            command = new SQLiteCommand(connection) // ID 
            {
                CommandText = ""
            };
        }

        public WordListClass LoadData() 
        {
            WordListClass WordList = new WordListClass();

            connection.Open();

            command = new SQLiteCommand(connection) // ID 
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

            return WordList;
        }
    }

}
