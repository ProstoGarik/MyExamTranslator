using ExamTranslatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarikTranslatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextToSpeech textToSpeech = new TextToSpeech();
            Console.WriteLine(textToSpeech.GetVoices());
            try
            {
                textToSpeech.Say("Banana");
            }
            catch
            {

                Console.WriteLine("error");
            }
            
            Console.ReadLine();
        }
    }
}
