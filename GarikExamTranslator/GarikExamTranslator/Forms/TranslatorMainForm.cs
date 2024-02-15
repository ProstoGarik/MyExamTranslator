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

        public TranslatorMainForm()
        {
            InitializeComponent();
            viewModel = new viewModel();
            addAndEditWordForm = new AddAndEditWordForm();
        }


        private void addWordButton_Click(object sender, EventArgs e)
        {
            viewModel.FormResizeCloseOpen(this, addAndEditWordForm);
        }
    }
}
