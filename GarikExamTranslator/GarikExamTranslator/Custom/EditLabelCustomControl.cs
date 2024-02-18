using ExamTranslatorClassLibrary;
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
    public partial class EditLabelCustomControl : Label
    {
        private int index;
        private AddAndEditWordForm editForm;
        public EditLabelCustomControl(int index, AddAndEditWordForm editForm)
        {
            InitializeComponent();
            this.index = index;
            this.editForm = editForm;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
    }
}
