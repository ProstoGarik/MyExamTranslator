using ExamTranslatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorConsoleTest
{
    internal class Program
    {
        static SQLiteConnection connection;
        static SQLiteCommand command;

        static void Main(string[] args)
        {
            try
            {
                connection = new SQLiteConnection("Data Source=Z:\\Database\\ExamTranslatorDB.db;Version=3; FailIfMissing=False");
                connection.Open();
                Console.WriteLine("Connected!");
                command = new SQLiteCommand(connection)
                {
                    CommandText = "SELECT * FROM \"WordList\";"
                };
                Console.WriteLine("Результат запроса:");
                DataTable data = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(data);
                Console.WriteLine($"Прочитано {data.Rows.Count} записей из таблицы БД");
                foreach (DataRow row in data.Rows)
                {
                    Console.WriteLine($"index = {row.Field<Int64>("index")} word = {row.Field<string>("word")} translation = {row.Field<string>("translation")} group = {row.Field<Int64>("group")}");
                }

            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"Ошибка доступа к базе данных. Исключение: {ex.Message}");
            }
            Console.Read();
        }
    }
}
