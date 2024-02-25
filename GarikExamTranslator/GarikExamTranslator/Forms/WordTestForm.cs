using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarikExamTranslator.Forms
{
    public partial class WordTestForm : Form
    {
        private viewModel viewModel;
        private WordListForm returnForm;
        int wordCounter = 1;
        int correctAnswerCounter = 0;

        public WordTestForm(WordListForm returnForm, viewModel viewModel)
        {
            InitializeComponent();
            this.returnForm = returnForm;
            this.viewModel = viewModel;
        }

        private void WordTestForm_Load(object sender, EventArgs e)
        {
            UpdateCounters();
            TestResultLabel.Text = "";
        }

        private void UpdateCounters()
        {
            try
            {
                if (viewModel.CompareWords(TranslationInputTextBox.Text, viewModel.GetWordByIndex(wordCounter, true).Translation))
                {
                    correctAnswerCounter++;
                }
                TestCounterLabel.Text = wordCounter.ToString() + " из " + viewModel.GetWordListCount().ToString();
                MainWordLabel.Text = viewModel.GetWordByIndex(wordCounter, true).Word;
                wordCounter++;
                
            }
            catch
            {
                TestResultLabel.Text = "Ваш результат:\n" + correctAnswerCounter.ToString() + " правильных ответов";
                TestCounterLabel.Text = (wordCounter-1).ToString() + " из " + viewModel.GetWordListCount().ToString();
                MainWordLabel.Text = "";
                AnswerButton.Enabled = false;
                TranslationInputTextBox.Enabled = false;
            }
            


        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            UpdateCounters();
            TranslationInputTextBox.Text = "";
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            viewModel.FormResizeCloseOpen(this, returnForm, true);
        }
    }
}
