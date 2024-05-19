using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using Microsoft.SqlServer.Server;
using System.CodeDom.Compiler;

namespace ExamTranslatorClassLibrary
{
    public class TextToSpeech
    {
        private string text;
        private int volume;
        private int rate;

        public TextToSpeech() { Text = "OOOOOO"; Volume = 100; Rate = 0; }

        public void Say(string text)
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                synth.Volume = volume;
                synth.Rate = rate;
                synth.SelectVoice("Microsoft Zira Desktop");
                synth.Speak(text);
            }
        }

        public string GetVoices()
        {
            string temp = "";
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                
                foreach (InstalledVoice voice in synth.GetInstalledVoices())
                {
                    temp += voice.VoiceInfo.Name + "\n";
                }
            }
            return temp;
        }





        public string Text { get => text; set => text = value; }
        public int Volume { get => volume; set => volume = value; }
        public int Rate { get => rate; set => rate = value; }
    }
}
