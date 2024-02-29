using ExamTranslatorClassLibrary;
using GarikExamTranslator.Forms;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarikExamTranslator
{
    public partial class WordListForm : Form
    {
        private viewModel viewModel;
        private TranslatorMainForm returnForm;
        private AddAndEditWordForm addAndEditWordForm;
        private WordTestForm wordTestForm;

        public WordListForm(TranslatorMainForm returnForm, AddAndEditWordForm addAndEditWordForm, viewModel viewModel )
        {
            InitializeComponent();
            this.returnForm = returnForm;
            this.viewModel = viewModel;
            this.addAndEditWordForm = addAndEditWordForm;
        }

        private void WordListForm_Activated(object sender, EventArgs e)
        {
            WordsLabel.Text = viewModel.GenerateWordList();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            viewModel.FormResizeCloseOpen(this, returnForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                viewModel.ChooseWordByIndex(Convert.ToInt32(WordIndexInputTextBox.Text));
                viewModel.FormResizeCloseOpen(this, addAndEditWordForm);
            }
            catch
            {

            }
        }

        private void WordListForm_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            IndexInputCheckLabel.Text = "";
        }

        private void IndexInputCheckLabel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                IndexInputCheckLabel.Text = "Выбранное слово: " + 
                    viewModel.GetWordByIndex(Convert.ToInt32(WordIndexInputTextBox.Text)).Word;
                EditWordButton.Enabled = true;
                DeleteWordButton.Enabled = true;
            }
            catch
            {
                IndexInputCheckLabel.Text = "Неверный номер слова";
                EditWordButton.Enabled = false;
                DeleteWordButton.Enabled = false;
            }
        }

        private void StartTestButton_Click(object sender, EventArgs e)
        {
            wordTestForm = new WordTestForm(this, viewModel);
            viewModel.CreateTestList();
            viewModel.FormResizeCloseOpen(this, wordTestForm);
        }

        private void DeleteWordButton_Click(object sender, EventArgs e)
        {
            try
            {
                viewModel.DeleteByIndex(Convert.ToInt32(WordIndexInputTextBox.Text));
                IndexInputCheckLabel.Text = "Слово удалено";
                WordsLabel.Text = viewModel.GenerateWordList();
                viewModel.Save();
            }
            catch
            {
                
            }
        }
    }
}
