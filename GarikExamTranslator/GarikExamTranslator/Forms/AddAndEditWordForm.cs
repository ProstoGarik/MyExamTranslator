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
        bool isEditMode;
        private WordClass word;
        public AddAndEditWordForm(Form returnForm, viewModel viewModel, bool isEditMode, WordClass word = null)
        {
            InitializeComponent();
            this.returnForm = returnForm;
            this.viewModel = viewModel;
            this.isEditMode = isEditMode;
            this.word = word;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            viewModel.AddWord(WordInputTextBox.Text, TranslationInputTextBox.Text);
            viewModel.FormResizeCloseOpen(this, returnForm);
        }

        private void AddAndEditWordForm_Load(object sender, EventArgs e)
        {
            
        }

        private void AddAndEditWordForm_Shown(object sender, EventArgs e)
        {
            WordInputTextBox.Text = viewModel.workinWithWord.Word;
            TranslationInputTextBox.Text = viewModel.workinWithWord.Translation;
        }
    }
}
