using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExamTranslatorClassLibrary
{
    public class FileManagerLocal : IFileManager
    {

        public const string FileName = "data.xml";

        public const string DirectoryName = "Translator";

        private readonly string _source = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public string Source => Path.Combine(SourceDirectory, FileName);

        public string SourceDirectory => Path.Combine(_source, DirectoryName);

        public void SaveData(WordListClass data, UserDataClass userData)
        {
            CreateDataSource();

            WriteWordListData(data);
        }

        public void LoadData(WordListClass Data, UserDataClass userData)
        {
            CreateDataSource();

            using (StreamReader reader = new StreamReader(Source))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(WordListClass));
                WordListClass data = (WordListClass)serializer.Deserialize(reader);
            }

            
        }

        private void CreateDataSource()
        {
            Directory.CreateDirectory(SourceDirectory);

            if (File.Exists(Source))
            {
                return;
            }

            // Пустой файл
            File.Create(Source).Close();

            // Даже если сохранять нечего
            // В любом случае мы создадим корректную xml основу
            // И пустой файл превратится в читаемый программой источник
            WriteWordListData(new WordListClass());
        }

        private void WriteWordListData(WordListClass data)
        {
            using (StreamWriter writer = new StreamWriter(Source))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(WordListClass));

                serializer.Serialize(writer, data);
            }
        }
    }
}
