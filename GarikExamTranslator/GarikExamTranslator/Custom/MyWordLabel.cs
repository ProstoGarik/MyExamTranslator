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
        private int queueNum;
        AddAndEditWordForm addAndEditWordForm;
        Form thisForm;


        public MyWordLabel(int wordIndex, int queueNum, viewModel viewModel, AddAndEditWordForm addAndEditWordForm, Form thisForm)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            this.wordIndex = wordIndex;
            this.queueNum = queueNum;
            this.word = viewModel.GetWordByIndex(wordIndex).Word;
            this.translation = viewModel.GetWordByIndex(wordIndex).Translation;
            this.MaximumSize = new Size(350, 500);
            this.addAndEditWordForm = addAndEditWordForm;
            this.thisForm = thisForm;
            this.ForeColor = Color.White;

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            viewModel.ApplyFont(this);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Font = new Font("", 18, FontStyle.Regular);
            this.Text = (queueNum).ToString() + ") " + word + " - " + translation;
            this.AutoSize = true;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            viewModel.ChooseWordByIndex(this.wordIndex);
            viewModel.FormResizeCloseOpen(thisForm, addAndEditWordForm);
        }
    }
}
