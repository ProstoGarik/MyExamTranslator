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
                "Version=3; FailIfMissing=False;");
        static SQLiteCommand command;

        List<string> currentWordList;
        List<string> currentTranslationList;
        List<string> currentGroupList;
        List<int> wordIndexList;
        List<int> translationIndexList;
        List<int> groupIndexList;
        string wordToAdd;

        public void SaveData(WordListClass Data)
        {
            wordIndexList = new List<int>();
            translationIndexList = new List<int>();
            groupIndexList = new List<int>();
            currentWordList= new List<string>();
            currentTranslationList = new List<string>();
            currentGroupList = new List<string>();
            for (int i = 1; i < Data.GetWordListCount()+1; i++)
            {
                WordClass ZWord = Data.GetWordByIndex(i);
                currentWordList.Add(ZWord.Word);
                currentTranslationList.Add(ZWord.Translation);
                currentGroupList.Add(ZWord.Group);
            }

            connection.Open();

            for (int i = 0; i < currentWordList.Count; i++)
            {
                command = new SQLiteCommand(connection)
                {
                    CommandText = "SELECT * FROM \"Words\""
                };
                DataTable data = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(data);
                foreach (DataRow row in data.Rows)
                {
                    string wordToDelete = row.Field<string>("word");
                    if ( !(currentWordList.Contains(wordToDelete)) )
                    {
                        command = new SQLiteCommand(connection)
                        {
                            CommandText = "PRAGMA foreign_keys=ON"
                        };
                        command.ExecuteNonQuery();
                        command.CommandText = "DELETE FROM \"Words\" WHERE \"word\" = \"" + wordToDelete + "\"";
                        command.ExecuteNonQuery();
                        currentWordList.Remove(wordToDelete);
                    }
                }
            }

            for (int i = 0; i < currentTranslationList.Count; i++)
            {
                command = new SQLiteCommand(connection)
                {
                    CommandText = "SELECT * FROM \"Translations\""
                };
                DataTable data = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(data);
                foreach (DataRow row in data.Rows)
                {
                    string translationToDelete = row.Field<string>("translation");
                    if (!(currentTranslationList.Contains(translationToDelete)))
                    {
                        command = new SQLiteCommand(connection)
                        {
                            CommandText = "PRAGMA foreign_keys=ON"
                        };
                        command.ExecuteNonQuery();
                        command.CommandText = "DELETE FROM \"Translations\" WHERE \"translation\" = \"" + translationToDelete + "\"";
                        command.ExecuteNonQuery();
                        currentTranslationList.Remove(translationToDelete);
                    }
                }
            }
            for (int i = 0; i < currentGroupList.Count; i++)
            {
                command = new SQLiteCommand(connection)
                { 
                    CommandText = "SELECT * FROM \"Groups\""
                };
                DataTable data = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(data);
                foreach (DataRow row in data.Rows)
                {
                    string groupToDelete = row.Field<string>("group");
                    if (!(currentGroupList.Contains(groupToDelete)))
                    {
                        command = new SQLiteCommand(connection)
                        {
                            CommandText = "PRAGMA foreign_keys=ON"
                        };
                        command.ExecuteNonQuery();
                        command.CommandText = "DELETE FROM \"Groups\" WHERE \"group\" = \"" + groupToDelete + "\"";
                        command.ExecuteNonQuery();
                        currentGroupList.Remove(groupToDelete);
                    }
                }
            }

            for (int i = 0; i < currentWordList.Count; i++)
            {
                wordToAdd = currentWordList[i];
                command = new SQLiteCommand(connection)
                {
                    CommandText = "INSERT OR IGNORE INTO \"Words\"(\"word\") VALUES(\"" + wordToAdd + "\")"
                };
                command.ExecuteNonQuery();
                command = new SQLiteCommand(connection)
                {
                    CommandText = "SELECT * FROM \"Words\""
                };
                DataTable data = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(data);
                foreach (DataRow row in data.Rows)
                {
                    if(wordToAdd == row.Field<string>("word"))
                    {
                        wordIndexList.Add(Convert.ToInt32(row.Field<long>("id")));
                    }
                }
            }



            for (int i = 0; i < currentTranslationList.Count(); i ++)
            {
                wordToAdd = currentTranslationList[i];
                command = new SQLiteCommand(connection)
                {
                    CommandText = "INSERT OR IGNORE INTO \"Translations\"(\"translation\") VALUES(\"" + wordToAdd + "\")"
                };
                command.ExecuteNonQuery();
                command = new SQLiteCommand(connection)
                {
                    CommandText = "SELECT * FROM \"Translations\""
                };
                DataTable data = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(data);
                foreach (DataRow row in data.Rows)
                {
                    if(wordToAdd == row.Field<string>("translation"))
                    {
                        translationIndexList.Add(Convert.ToInt32(row.Field<long>("id")));
                    }
                }
            }

            for (int i = 0; i < currentGroupList.Count(); i ++)
            {
                wordToAdd = currentGroupList[i];
                command = new SQLiteCommand(connection)
                {
                    CommandText = "INSERT OR IGNORE INTO \"Groups\"(\"group\") VALUES(\"" + wordToAdd + "\")"
                };
                command.ExecuteNonQuery();
                command = new SQLiteCommand(connection)
                {
                    CommandText = "SELECT * FROM \"Groups\""
                };
                DataTable data = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(data);
                foreach (DataRow row in data.Rows)
                {
                    if (wordToAdd == row.Field<string>("group"))
                    {
                        groupIndexList.Add(Convert.ToInt32(row.Field<long>("id")));
                    }
                }

            }

            for (int i = 0; i < wordIndexList.Count(); i++)
            {
                int word = wordIndexList[i];
                int translation = translationIndexList[i];
                int group = groupIndexList[i];

                command = new SQLiteCommand(connection)
                {
                    CommandText = "INSERT OR IGNORE INTO \"WordsAndTranslations\"(\"Word\", \"Translation\", \"Group\") VALUES(\"" + word + "\", \"" + translation + "\", \"" + group + "\")"
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
