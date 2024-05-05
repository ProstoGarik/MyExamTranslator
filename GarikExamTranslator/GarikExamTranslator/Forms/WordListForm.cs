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
        private PreTestForm PreTestForm;
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
            Refresh();
            WordGroupsComboBox.Items.Clear();
            for (int i = 0; i < viewModel.GetWordGroupsCount(); i++)
            {
                WordGroupsComboBox.Items.Add(viewModel.GetWordGroupNameByIndex(i));
            }
            wordsPanel.GenerateWordList(WordGroupsComboBox.Text);
            if (WordGroupsComboBox.Text == "Без Группы")
            {
                DeleteGroupButton.Image = Properties.Resources.Delete_Icon_NotActive;
                DeleteGroupButton.Enabled = false;
            }
            else
            {
                DeleteGroupButton.Image = Properties.Resources.Delete_Icon;
                DeleteGroupButton.Enabled = true;
            }
            HideButtons();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            viewModel.FormResizeCloseOpen(this, returnForm);
        }

        private void WordListForm_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            wordsPanel = new MyControlPanel(viewModel, addAndEditWordForm, this, EditWordButton, DeleteWordButton);
            wordsPanel.Location = new Point(10, 35);
            wordsPanel.Size = new Size(400, 400);
            wordsPanel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(wordsPanel);
            viewModel.ApplyFont(WordListUpperLabel);
            viewModel.ApplyFont(StartTestLabel);
            viewModel.ApplyFont(DeleteGroupLabel);
            viewModel.ApplyFont(EditWordButton);
            viewModel.ApplyFont(DeleteWordButton);
            viewModel.ApplyFont(WordGroupsComboBox);
        }

        private void StartTestButton_Click(object sender, EventArgs e)
        {
            PreTestForm = new PreTestForm(this, viewModel);
            viewModel.FormResizeCloseOpen(this, PreTestForm);
        }

        private void WordListForm_Deactivate(object sender, EventArgs e)
        {
            wordsPanel.ResetWordList();
        }

        private void WordGroupsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(WordGroupsComboBox.Text == "Без Группы")
            {
                DeleteGroupButton.Image = Properties.Resources.Delete_Icon_NotActive;
                DeleteGroupButton.Enabled = false;
            }
            else
            {
                DeleteGroupButton.Image = Properties.Resources.Delete_Icon;
                DeleteGroupButton.Enabled = true;
            }
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

        private void DeleteGroupButton_Click(object sender, EventArgs e)
        {
            viewModel.DeleteGroup(WordGroupsComboBox.Text);
            WordGroupsComboBox.Text = "Без Группы";
            WordGroupsComboBox.Items.Clear();
            for (int i = 0; i < viewModel.GetWordGroupsCount(); i++)
            {
                WordGroupsComboBox.Items.Add(viewModel.GetWordGroupNameByIndex(i));
            }
            wordsPanel.GenerateWordList(WordGroupsComboBox.Text);

        }

        private void DeleteGroupButton_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void DeleteGroupButton_MouseEnter(object sender, EventArgs e)
        {
            if(DeleteGroupButton.Enabled)
            {
                DeleteGroupButton.Image = Properties.Resources.Delete_Icon_OnHover;
            }
        }

        private void DeleteGroupButton_MouseLeave(object sender, EventArgs e)
        {
            if (DeleteGroupButton.Enabled)
            {
                DeleteGroupButton.Image = Properties.Resources.Delete_Icon;
            }
        }

        private void WordListForm_Shown(object sender, EventArgs e)
        {
            Refresh();
        }

        private void EditWordButton_Click(object sender, EventArgs e)
        {
            viewModel.FormResizeCloseOpen(this, addAndEditWordForm);
            HideButtons();
        }

        private void DeleteWordButton_Click(object sender, EventArgs e)
        {
            viewModel.DeleteWord();
            wordsPanel.RegenerateWordList();
            HideButtons();
        }

        private void HideButtons()
        {
            EditWordButton.Hide();
            DeleteWordButton.Hide();
            EditWordButton.Enabled = false;
            DeleteWordButton.Enabled = false;
        }
    }
}
