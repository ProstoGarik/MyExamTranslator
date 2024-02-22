using ExamTranslatorClassLibrary;
using System;
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
    public partial class AddAndEditWordForm : Form
    {
        Form returnForm;
        viewModel viewModel;
        private WordClass word;
        bool isEditMode = false;
        public AddAndEditWordForm(Form returnForm, viewModel viewModel, bool isEditMode)
        {
            InitializeComponent();
            this.returnForm = returnForm;
            this.viewModel = viewModel;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if(isEditMode)
            {
                viewModel.EditWord(WordInputTextBox.Text, TranslationInputTextBox.Text);
                viewModel.FormResizeCloseOpen(this, returnForm);
                isEditMode = false;
            }
            else
            {
                viewModel.AddWord(WordInputTextBox.Text, TranslationInputTextBox.Text);
                viewModel.FormResizeCloseOpen(this, returnForm);
            }
            viewModel.ResetChosenWord();
            WordInputTextBox.Text = "";
            TranslationInputTextBox.Text = "";

        }

        private void AddAndEditWordForm_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void AddAndEditWordForm_Activated(object sender, EventArgs e)
        {
            if(viewModel.workinWithWord != null)
            {
                isEditMode = true;
                this.word = viewModel.workinWithWord;
                WordInputTextBox.Text = word.Word;
                TranslationInputTextBox.Text = word.Translation;
            }
        }
    }
}
