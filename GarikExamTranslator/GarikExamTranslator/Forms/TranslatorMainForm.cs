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
            this.DoubleBuffered = true;
            viewModel.PreLoadForm(addAndEditWordForm);
            viewModel.PreLoadForm(wordListForm);
        }
    }
}
