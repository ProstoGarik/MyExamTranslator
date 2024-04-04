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
        List<string> Wordlist;
        List<string> Translationlist;
        List<string> Grouplist;
        string wordToAdd;



        public void SaveData(WordListClass Data)
        {
            currentList= new List<string>();
            Wordlist = new List<string>();
            Translationlist = new List<string>();
            Grouplist = new List<string>();
            for (int i = 1; i < Data.GetWordListCount()+1; i++)
            {
                WordClass ZWord = Data.GetWordByIndex(i);
                currentList.Add(ZWord.Word);
                currentList.Add(ZWord.Translation);
                currentList.Add(ZWord.Group);
            }

            connection.Open();

            command = new SQLiteCommand(connection)
            {
                CommandText = "DELETE FROM \"WordsAndTranslations\""
            };
            command.ExecuteNonQuery();


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

            for (int i = 1; i < currentList.Count(); i += 3)
            {
                wordToAdd = currentList[i];
                command = new SQLiteCommand(connection)
                {
                    CommandText = "INSERT OR IGNORE INTO \"Translations\"(\"translation\") VALUES(\"" + wordToAdd + "\")"
                };
                command.ExecuteNonQuery();
                indexlist2.Add(i);
            }

            for (int i = 2; i < currentList.Count(); i += 3)
            {
                wordToAdd = currentList[i];
                command = new SQLiteCommand(connection)
                {
                    CommandText = "INSERT OR IGNORE INTO \"Groups\"(\"group\") VALUES(\"" + wordToAdd + "\")"
                };
                command.ExecuteNonQuery();
                indexlist3.Add(i);
            }


            for (int i = 0; i < indexlist1.Count(); i++)
            {
                int index1 = 1 + ((indexlist1[i]+1)/3); //=0+1
                int index2 = 1 + (indexlist2[i] / 3); //=1
                int index3 = 1 + ((indexlist3[i]-1) / 3);//=2-1
                command = new SQLiteCommand(connection)
                {
                    CommandText = "INSERT INTO \"WordsAndTranslations\"(\"Word\", \"Translation\", \"Group\") VALUES(\""+index1+"\",\""+index2+"\",\""+index3+"\")"
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
