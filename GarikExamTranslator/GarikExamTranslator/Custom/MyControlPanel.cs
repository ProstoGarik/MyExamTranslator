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
    public partial class MyControlPanel : Panel
    {
        private viewModel viewModel;
        private Point tempLocation;

        public MyControlPanel(viewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            tempLocation = new Point(this.Location.X+5, this.Location.Y + 10);
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

        public void AddWordLabel(int wordIndex)
       {
            MyWordLabel wordLabel = new MyWordLabel(wordIndex, viewModel);
            wordLabel.Location = new Point(tempLocation.X, tempLocation.Y);
            this.Controls.Add(wordLabel);
            tempLocation = new Point(tempLocation.X, tempLocation.Y + wordLabel.Size.Height + 10);
       }
    }
}
