using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExamTranslatorClassLibrary
{
    public class FileManagerDB : IFileManager
    {
        static SQLiteConnection connection = new SQLiteConnection("Data Source=..\\..\\Resources\\Database\\NewExamTranslatorDB.db;" +
                "Version=3; FailIfMissing=False");
        static SQLiteCommand command;

        List<string> currentList;
        List<int> indexlist1;
        List<int> indexlist2;
        List<int> indexlist3;
        string wordToAdd;


        public void SaveData(WordListClass Data)
        {
            currentList= new List<string>();
            indexlist1 = new List<int>();
            indexlist2 = new List<int>();
            indexlist3 = new List<int>();
            for (int i = 1; i < Data.GetWordListCount()+1; i++)
            {
                WordClass ZWord = Data.GetWordByIndex(i);
                currentList.Add(ZWord.Word);
                currentList.Add(ZWord.Translation);
                currentList.Add(ZWord.Group);
            }

            connection.Open();


            for (int i = 0; i < currentList.Count; i+= 3)
            {
                wordToAdd = currentList[i];
                command = new SQLiteCommand(connection)
                {
                    CommandText = "INSERT OR IGNORE INTO \"Words\"(\"word\") VALUES(\"" + wordToAdd + "\")"
                };
                command.ExecuteNonQuery();
                indexlist1.Add(i);
            }

            for (int i = 1; i < currentList.Count + 1; i += 3)
            {
                wordToAdd = currentList[i];
                command = new SQLiteCommand(connection)
                {
                    CommandText = "INSERT OR IGNORE INTO \"Translations\"(\"translation\") VALUES(\"" + wordToAdd + "\")"
                };
                command.ExecuteNonQuery();
                indexlist2.Add(i);
            }

            for (int i = 2; i < currentList.Count + 1; i += 3)
            {
                wordToAdd = currentList[i];
                command = new SQLiteCommand(connection)
                {
                    CommandText = "INSERT OR IGNORE INTO \"Groups\"(\"group\") VALUES(\"" + wordToAdd + "\")"
                };
                command.ExecuteNonQuery();
                indexlist3.Add(i);
            }

            for (int i = 0; i < currentList.Count / 3; i += 3)
            {
                int index1 = indexlist1[i];
                int index2 = indexlist2[i];
                int index3 = indexlist3[i];
                command = new SQLiteCommand(connection)
                {
                    CommandText = "INSERT OR IGNORE INTO \"WordsAndTranslations\"(\"Word\", \"Translation\", \"Group\") VALUES(\""+index1+1+"\",\""+index2+1+"\",\""+index3+1+"\")"
                };
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
