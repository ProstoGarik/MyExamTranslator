using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.CodeDom.Compiler;

namespace ExamTranslatorClassLibrary
{
    public class FileManagerDB : IFileManager
    {
        static SQLiteConnection connection = new SQLiteConnection("Data Source=..\\..\\Resources\\Database\\NewExamTranslatorDB.db;" +
                "Version=3; FailIfMissing=False");
        static SQLiteCommand command;

        List<string> currentList;
        List<int> wordIndexList;
        List<int> translationIndexList;
        List<int> groupIndexList;
        string wordToAdd;

        public void SaveData(WordListClass Data)
        {
            wordIndexList = new List<int>();
            translationIndexList = new List<int>();
            groupIndexList = new List<int>();
            currentList= new List<string>();
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
                wordIndexList.Add(i);
                command = new SQLiteCommand(connection)
                {
                    CommandText = "SELECT \"*\" FROM \"Words\""
                };
                DataTable data = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(data);
                foreach (DataRow row in data.Rows)
                {
                    if(wordToAdd == row.Field<string>("Word"))
                    {

                    }
                }
            }



            for (int i = 1; i < currentList.Count(); i += 3)
            {
                wordToAdd = currentList[i];
                command = new SQLiteCommand(connection)
                {
                    CommandText = "INSERT OR IGNORE INTO \"Translations\"(\"Translation\") VALUES(\"" + wordToAdd + "\")"
                };
                command.ExecuteNonQuery();
                translationIndexList.Add(i);
            }

            for (int i = 2; i < currentList.Count(); i += 3)
            {
                wordToAdd = currentList[i];
                command = new SQLiteCommand(connection)
                {
                    CommandText = "INSERT OR IGNORE INTO \"Groups\"(\"Group\") VALUES(\"" + wordToAdd + "\")"
                };
                command.ExecuteNonQuery();
                groupIndexList.Add(i);

            }

            for (int i = 0; i < wordIndexList.Count(); i++)
            {
                int word = wordIndexList[i] + 1;
                int translation = translationIndexList[i];
                int group = groupIndexList[i] - 1;

                command = new SQLiteCommand(connection)
                {
                    CommandText = "INSERT OR IGNORE INTO \"WordsAndTranslations\"(\"Word\", \"Translation\", \"Group\") VALUES(\""+word+"\", \""+translation+"\", \""+group+"\")"
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
