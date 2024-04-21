using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarikExamTranslator.Custom
{
    public partial class MyWordLabel : Label
    {
        private viewModel viewModel;
        private string word;
        private string translation;
        private int wordIndex;
        private int queueNum;
        private Button editButton;
        private Button deleteButton;


        public MyWordLabel(int wordIndex, int queueNum, viewModel viewModel, AddAndEditWordForm addAndEditWordForm, Form thisForm,
            Button editButton, Button DeleteButton)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            this.wordIndex = wordIndex;
            this.queueNum = queueNum;
            this.word = viewModel.GetWordByIndex(wordIndex).Word;
            this.translation = viewModel.GetWordByIndex(wordIndex).Translation;
            this.MaximumSize = new Size(350, 500);
            this.ForeColor = Color.White;
            this.editButton = editButton;
            this.deleteButton = DeleteButton;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            viewModel.ApplyFont(this);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Font = new Font("", 18, FontStyle.Regular);
            this.Text = (queueNum).ToString() + ") " + word + " - " + translation;
            this.AutoSize = true;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            viewModel.ChooseWordByIndex(this.wordIndex);
            viewModel.MoveLabelButtons(editButton, deleteButton, this);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.Font = new Font(this.Font.FontFamily, 20, FontStyle.Regular);
            Cursor = Cursors.Hand;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Font = new Font(this.Font.FontFamily, 18, FontStyle.Regular);
            Cursor = DefaultCursor;
        }
    }
}
