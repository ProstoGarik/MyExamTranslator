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
        private int queueNum = 1;
        private string CurrentGroup;
        private Button editButton;
        private Button deleteButton;
        private Button sayButton;


        public MyControlPanel(viewModel viewModel, AddAndEditWordForm addAndEditWordForm, Form thisForm,
            Button editButton, Button deleteButton, Button sayButton)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            labelStack = new Stack<Control>();
            this.addAndEditWordForm = addAndEditWordForm;
            this.thisForm = thisForm;
            this.editButton = editButton;
            this.deleteButton = deleteButton;
            this.sayButton = sayButton;
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
            MyWordLabel wordLabel = new MyWordLabel(wordIndex, queueNum, viewModel, addAndEditWordForm, thisForm, editButton, deleteButton, sayButton);
            wordLabel.Location = new Point(tempLocation.X, tempLocation.Y);
            this.Controls.Add(wordLabel);
            tempLocation = new Point(tempLocation.X, tempLocation.Y + wordLabel.Size.Height + 10);
            queueNum++;
            labelStack.Push(wordLabel);
        }

        public void ResetWordList()
        {
            while(labelStack.Count > 0)
            {
                this.Controls.Remove(labelStack.Pop());
            }
            tempLocation = new Point(this.Location.X + 5, this.Location.Y + 10);
            queueNum = 1;
        }

        public void GenerateWordList(string group)
        {
            CurrentGroup = group;
            ResetWordList();
            for (int i = 1; i < viewModel.GetWordListCount() + 1; i++)
            {
                if (viewModel.GetWordByIndex(i).Group == group)
                {
                    this.AddWordLabel(i);
                }
            }
        }

        public void RegenerateWordList()
        {
            ResetWordList();
            for (int i = 1; i < viewModel.GetWordListCount() + 1; i++)
            {
                if (viewModel.GetWordByIndex(i).Group == CurrentGroup)
                {
                    this.AddWordLabel(i);
                }
            }
        }
    }
}
