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
        static SQLiteConnection connection;
        static SQLiteCommand command;
        static SQLiteCommand commandForWord;
        static SQLiteCommand commandForTranslation;
        static SQLiteCommand commandForGroup;

        public void SaveData(WordListClass Data)
        {
            
        }

        public WordListClass LoadData() 
        {
            WordListClass WordList = new WordListClass();


            try
            {
                connection = new SQLiteConnection("Data Source=..\\..\\Resources\\Database\\NewExamTranslatorDB.db;Version=3; FailIfMissing=False");
                connection.Open();
                command = new SQLiteCommand(connection)
                {
                    CommandText = "SELECT * FROM \"WordsAndTranslations\";"
                };
                DataTable data = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(data);
                //Console.WriteLine($"Прочитано {data.Rows.Count} записей из таблицы БД");
                foreach (DataRow row in data.Rows)
                {
                    WordList.AddWord(row.Field<Int64>("word").ToString(), row.Field<Int64>("translation").ToString(), row.Field<Int64>("group").ToString());
                }
                return WordList;
            }
            catch
            {
                return new WordListClass();
            }
        }
    }

}
