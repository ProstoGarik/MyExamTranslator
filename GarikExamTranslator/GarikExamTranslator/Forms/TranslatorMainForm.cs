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
    public partial class TranslatorMainForm : Form
    {
        viewModel viewModel;
        AddAndEditWordForm addAndEditWordForm;
        WordListForm wordListForm;

        public TranslatorMainForm()
        {
            InitializeComponent();
            viewModel = new viewModel();
            addAndEditWordForm = new AddAndEditWordForm(this, viewModel, false);
            wordListForm = new WordListForm(this, addAndEditWordForm, viewModel);
        }


        private void addWordButton_Click(object sender, EventArgs e)
        {
            viewModel.FormResizeCloseOpen(this, addAndEditWordForm);
        }

        private void WordListButton_Click(object sender, EventArgs e)
        {
            viewModel.FormResizeCloseOpen(this, wordListForm);
        }

        private void TranslatorMainForm_Load(object sender, EventArgs e)
        {
            Refresh();
            this.DoubleBuffered = true;
            viewModel.PreLoadForm(addAndEditWordForm);
            viewModel.PreLoadForm(wordListForm);
            viewModel.ApplyFont(WelcomeLabel);
            viewModel.ApplyFont(WordListLabel);
            viewModel.ApplyFont(AddWordLabel);
        }

        private void WordListButton_MouseEnter(object sender, EventArgs e)
        {
            WordListButton.Image = Properties.Resources.Book_Icon_OnHover;
        }

        private void WordListButton_MouseLeave(object sender, EventArgs e)
        {
            WordListButton.Image = Properties.Resources.Book_Icon;
        }

        private void AddWordButton_MouseEnter(object sender, EventArgs e)
        {
            AddWordButton.Image = Properties.Resources.Add_Icon_OnHover;
        }

        private void AddWordButton_MouseLeave(object sender, EventArgs e)
        {
            AddWordButton.Image = Properties.Resources.Add_Icon;
        }

        private void TranslatorMainForm_Shown(object sender, EventArgs e)
        {
            Refresh();
        }

        private void TranslatorMainForm_Activated(object sender, EventArgs e)
        {
            Refresh();
        }

        private void UserProfileButton_MouseEnter(object sender, EventArgs e)
        {
            UserProfileButton.Image = Properties.Resources.User_Icon_OnHover;
        }

        private void UserProfileButton_MouseLeave(object sender, EventArgs e)
        {
            UserProfileButton.Image = Properties.Resources.User_Icon;
        }
    }
}
