using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExamTranslatorClassLibrary
{
    public class WordClass
    {
        private string word;
        private string translation;
        private int index;
        private string group;
        public WordClass(string _word, string _translation, int _index, string _group) { Word = _word; Translation = _translation; Index = _index; Group = _group; }
        public WordClass() { Word = ""; Translation = ""; Index = -1; }


        public string Word { get => word; set => word = value; }
        public string Translation { get => translation; set => translation = value; }
        public int Index { get => index; set => index = value; }
        public string Group { get => group; set => group = value; }
    }
}
