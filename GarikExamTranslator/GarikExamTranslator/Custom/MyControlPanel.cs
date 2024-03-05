using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarikExamTranslator.Custom
{
    public partial class MyControlPanel : Panel
    {
        private viewModel viewModel;
        private Point tempLocation;
        private Stack<Control> labelStack;
        private AddAndEditWordForm addAndEditWordForm;
        private Form thisForm;

        public MyControlPanel(viewModel viewModel, AddAndEditWordForm addAndEditWordForm, Form thisForm)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            labelStack = new Stack<Control>();
            this.addAndEditWordForm = addAndEditWordForm;
            this.thisForm = thisForm;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.AutoScroll = false;
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;
            this.HorizontalScroll.Maximum = 0;
            this.AutoScroll = true;
        }

        private void AddWordLabel(int wordIndex)
        {
            MyWordLabel wordLabel = new MyWordLabel(wordIndex, viewModel, addAndEditWordForm, thisForm);
            wordLabel.Location = new Point(tempLocation.X, tempLocation.Y);
            this.Controls.Add(wordLabel);
            tempLocation = new Point(tempLocation.X, tempLocation.Y + wordLabel.Size.Height + 10);
            labelStack.Push(wordLabel);
        }

        public void ResetWordList()
        {
            while(labelStack.Count > 0)
            {
                this.Controls.Remove(labelStack.Pop());
            }
            tempLocation = new Point(this.Location.X + 5, this.Location.Y + 10);
        }

        public void GenerateWordList()
        {
            ResetWordList();
            for (int i = 1; i < viewModel.GetWordListCount() + 1; i++)
            {
                this.AddWordLabel(i);
            }
        }
    }
}
