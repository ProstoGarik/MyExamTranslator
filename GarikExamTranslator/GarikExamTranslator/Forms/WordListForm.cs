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
    public partial class WordListForm : Form
    {
        private viewModel viewModel;
        private TranslatorMainForm returnForm;
        public WordListForm(TranslatorMainForm returnForm, viewModel viewModel)
        {
            InitializeComponent();
            this.returnForm = returnForm;
            this.viewModel = viewModel;
        }

        private void WordListForm_Load(object sender, EventArgs e)
        {
            WordsLabel.Text = viewModel.GenerateWordList();
        }
    }
}
