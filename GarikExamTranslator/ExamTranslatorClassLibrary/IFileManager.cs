﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTranslatorClassLibrary
{
    public interface IFileManager
    {
        void SaveData(WordListClass data);
        WordListClass LoadData();
    }
}
