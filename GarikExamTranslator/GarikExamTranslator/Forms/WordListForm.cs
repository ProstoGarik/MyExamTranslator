using ExamTranslatorClassLibrary;
using GarikExamTranslator.Custom;
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
        MyControlPanel wordsPanel;

        public WordListForm(TranslatorMainForm returnForm, AddAndEditWordForm addAndEditWordForm, viewModel viewModel )
        {
            InitializeComponent();
            this.returnForm = returnForm;
            this.viewModel = viewModel;
            this.addAndEditWordForm = addAndEditWordForm;
        }

        private void WordListForm_Activated(object sender, EventArgs e)
        {
            if (viewModel.GetWordGroupsCount() != 0)
            {
                WordGroupsComboBox.Items.Clear();
                for (int i = 0; i < viewModel.GetWordGroupsCount(); i++)
                {
                    WordGroupsComboBox.Items.Add(viewModel.GetWordGroupNameByIndex(i));
                }
            }
            wordsPanel.GenerateWordList(WordGroupsComboBox.Text);
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            viewModel.FormResizeCloseOpen(this, returnForm);
        }

        private void WordListForm_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            wordsPanel = new MyControlPanel(viewModel, addAndEditWordForm, this);
            wordsPanel.Location = new Point(10, 35);
            wordsPanel.Size = new Size(400, 400);
            wordsPanel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(wordsPanel);
            viewModel.ApplyFont(WordListUpperLabel);
            viewModel.ApplyFont(StartTestLabel);
        }

        private void StartTestButton_Click(object sender, EventArgs e)
        {
            wordTestForm = new WordTestForm(this, viewModel);
            viewModel.CreateTestList();
            viewModel.FormResizeCloseOpen(this, wordTestForm);
        }

        private void WordListForm_Deactivate(object sender, EventArgs e)
        {
            wordsPanel.ResetWordList();
        }

        private void WordGroupsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            wordsPanel.GenerateWordList(WordGroupsComboBox.Text);
        }

        private void ReturnToMenuButton_MouseEnter(object sender, EventArgs e)
        {
            ReturnToMenuButton.Image = Properties.Resources.GoBack_Icon_OnHover;
        }

        private void ReturnToMenuButton_MouseLeave(object sender, EventArgs e)
        {
            ReturnToMenuButton.Image = Properties.Resources.GoBack_Icon;
        }

        private void StartTestButton_MouseEnter(object sender, EventArgs e)
        {
            StartTestButton.Image = Properties.Resources.Test_Icon_OnHover; 
        }

        private void StartTestButton_MouseLeave(object sender, EventArgs e)
        {
            StartTestButton.Image = Properties.Resources.Test_Icon;
        }
    }
}
