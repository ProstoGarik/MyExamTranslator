using ExamTranslatorClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
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
            if (WordInputTextBox.Text.Trim() == "" || TranslationInputTextBox.Text.Trim() == "" || WordGroupsComboBox.Text.Trim() == "")
            {
                MessageBox.Show( "Не все поля заполнены", "Ошибка");
            }
            else
            {
                if (isEditMode)
                {
                    viewModel.EditWord(WordInputTextBox.Text, TranslationInputTextBox.Text, WordGroupsComboBox.Text);
                    viewModel.FormResizeCloseOpen(this, returnForm);
                    isEditMode = false;
                }
                else
                {
                    viewModel.AddWord(WordInputTextBox.Text, TranslationInputTextBox.Text, WordGroupsComboBox.Text);
                    viewModel.FormResizeCloseOpen(this, returnForm);
                }
                SaveNClear();
            }
        }

        private void AddAndEditWordForm_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            viewModel.ApplyFont(AddEditLabel);
            viewModel.ApplyFont(GroupLabel);
            viewModel.ApplyFont(TranslationLabel);
            viewModel.ApplyFont(WordLabel);
        }

        private void AddAndEditWordForm_Activated(object sender, EventArgs e)
        {
            if(viewModel.GetTargetWord() != null)
            {
                isEditMode = true;
                DeleteButton.Enabled = true;
                DeleteButton.Visible = true;
                this.word = viewModel.GetTargetWord();
                WordInputTextBox.Text = word.Word;
                TranslationInputTextBox.Text = word.Translation;
                WordGroupsComboBox.Text = word.Group;
            }
            else
            {
                DeleteButton.Enabled = false;
                DeleteButton.Visible = false;
            }
            if(viewModel.GetWordGroupsCount() != 0)
            {
                WordGroupsComboBox.Items.Clear();
                for (int i = 0; i < viewModel.GetWordGroupsCount(); i++)
                {
                    WordGroupsComboBox.Items.Add(viewModel.GetWordGroupNameByIndex(i));
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            viewModel.DeleteWord();
            viewModel.FormResizeCloseOpen(this, returnForm);
            isEditMode = false;
            SaveNClear();
        }

        private void SaveNClear()
        {
            WordInputTextBox.Text = "";
            TranslationInputTextBox.Text = "";
            viewModel.ResetChosenWord();
            viewModel.Save();
        }

        private void DoneButton_MouseEnter(object sender, EventArgs e)
        {
            DoneButton.Image = Properties.Resources.Done_Icon_OnHover;
            
        }

        private void DoneButton_MouseLeave(object sender, EventArgs e)
        {
            DoneButton.Image = Properties.Resources.Done_Icon;
        }

        private void DeleteButton_MouseEnter(object sender, EventArgs e)
        {
            DeleteButton.Image = Properties.Resources.Delete_Icon_OnHover;
        }

        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton.Image = Properties.Resources.Delete_Icon;
        }
    }
}
