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
    public partial class SelectUserForm : Form
    {

        viewModel viewModel;
        UserProfileForm returnForm;


        public SelectUserForm(viewModel viewModel, UserProfileForm returnForm)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            this.returnForm = returnForm;
        }

        private void SelectUserForm_Load(object sender, EventArgs e)
        {
            viewModel.ApplyFont(SelectUserLabel);
            viewModel.ApplyFont(SelectUserListView);
            SelectUserListView.Items.Add("Пользователь1");
        }
    }
}
