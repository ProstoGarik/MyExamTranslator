using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarikExamTranslator.Custom
{
    public partial class MyWordLabel : Label
    {
        private viewModel viewModel;
        private string word;
        private string translation;
        private int wordIndex;


        public MyWordLabel(int wordIndex, viewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            this.wordIndex = wordIndex;
            this.word = viewModel.GetWordByIndex(wordIndex).Word;
            this.translation = viewModel.GetWordByIndex(wordIndex).Translation;
            this.MaximumSize = new Size(350, 500);


        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Font = new Font("", 14, FontStyle.Regular);
            this.Text = (wordIndex).ToString() + ") " + word + " - " + translation;
            this.AutoSize = true;
        }
    }
}
