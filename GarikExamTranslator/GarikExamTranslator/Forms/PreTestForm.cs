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
    public partial class PreTestForm : Form
    {
        private viewModel viewModel;
        private bool isSelectAll = false;
        private WordListForm returnForm;
        private List<string> selecredGroups;
        private WordTestForm wordTestForm;
        public PreTestForm(WordListForm returnForm, viewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            this.returnForm = returnForm;
            this.selecredGroups = new List<string>();
            wordTestForm = new WordTestForm(returnForm, viewModel);
        }

        private void PreTestForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < viewModel.GetWordGroupsCount(); i++)
            {
                WordsCheckedListBox.Items.Add(viewModel.GetWordGroupNameByIndex(i));
            }
            SelectAllCheckedListBox.Items.Add("Все слова");
            viewModel.ApplyFont(SelectAllCheckedListBox);
            viewModel.ApplyFont(WordsCheckedListBox);
            viewModel.ApplyFont(ChooseGroupsLabel);
        }

        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            viewModel.FormResizeCloseOpen(this, returnForm, true);
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if(isSelectAll)
            {
                viewModel.CreateTestList(selecredGroups, true);
            }
            else
            {
                foreach (string index in WordsCheckedListBox.CheckedItems)
                {
                    selecredGroups.Add(index);
                }
                viewModel.CreateTestList(selecredGroups, false);
            }
            viewModel.FormResizeCloseOpen(this, wordTestForm);
        }

        private void SelectAllCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            WordsCheckedListBox.Enabled = !WordsCheckedListBox.Enabled;
            SelectAllCheckedListBox.ClearSelected();
            isSelectAll = !isSelectAll;
        }

        private void WordsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            WordsCheckedListBox.ClearSelected();
        }
    }
}
