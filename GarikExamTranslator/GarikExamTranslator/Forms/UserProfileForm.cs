using ExamTranslatorClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarikExamTranslator.Forms
{
    public partial class UserProfileForm : Form
    {
        TranslatorMainForm returnForm;
        viewModel viewModel;
        UserDataClass userData;

        public UserProfileForm(TranslatorMainForm returnForm, viewModel viewModel)
        {
            InitializeComponent();
            this.returnForm = returnForm;
            this.viewModel = viewModel;
            userData = viewModel.GetUserData();
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            EditUserNameTextBox.Location = UsernameLabel.Location;
            viewModel.ApplyFont(UsernameLabel);
            viewModel.ApplyFont(UserDataUpperLabel);
            viewModel.ApplyFont(WordsTabLabel);
            viewModel.ApplyFont(TestsTabLabel);
            viewModel.ApplyFont(WordsAddedLabel);
            viewModel.ApplyFont(CompletedTestsLabel);
            viewModel.ApplyFont(PerfectTestsLabel);
            viewModel.ApplyFont(EditUserNameTextBox);
        }

        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            viewModel.FormResizeCloseOpen(this, returnForm);
        }

        private void UserProfileForm_Activated(object sender, EventArgs e)
        {
            EditUserNameTextBox.Visible = false;
            UsernameLabel.Text = userData.Username;
            WordsAddedLabel.Text = "Добавлено слов: " + userData.WordsAdded;
            CompletedTestsLabel.Text = "Пройдено тестов: " + userData.CompletedTests;
            PerfectTestsLabel.Text = "Идеальных тестов: " + userData.PerfectTests;
            try
            {
                UserPicturePicBox.Image = (Image)new Bitmap(Image.FromFile(userData.ImagePath), UserPicturePicBox.Size);
            }
            catch
            { }
            EditUsernameButton.Location = new Point(UsernameLabel.Size.Width + UsernameLabel.Location.X, EditUsernameButton.Location.Y);
        }

        private void ReturnToMenuButton_MouseEnter(object sender, EventArgs e)
        {
            ReturnToMenuButton.Image = Properties.Resources.GoBack_Icon_OnHover;
        }

        private void ReturnToMenuButton_MouseLeave(object sender, EventArgs e)
        {
            ReturnToMenuButton.Image = Properties.Resources.GoBack_Icon;
        }

        private void EditUsernameButton_Click(object sender, EventArgs e)
        {
            EditUsernameButton.Visible = false;
            UsernameLabel.Visible = false;
            EditUserNameTextBox.Visible = true;
            EditUserNameTextBox.Text = UsernameLabel.Text;
        }

        private void EditUserNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                UsernameLabel.Text = EditUserNameTextBox.Text;
                EditUsernameButton.Visible = true;
                UsernameLabel.Visible = true;
                EditUserNameTextBox.Visible = false;
                viewModel.EditUserData(UsernameLabel.Text, userData.WordsAdded, userData.CompletedTests, userData.PerfectTests, userData.ImagePath);
                viewModel.Save();
                EditUsernameButton.Location = new Point(UsernameLabel.Size.Width + UsernameLabel.Location.X, EditUsernameButton.Location.Y);
            }
        }

        private void UserPicturePicBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Изображение(*.jpg; *.jpeg; *.png;) | *.jpg; *.jpeg; *.png;";
            if(open.ShowDialog() == DialogResult.OK)
            {
                UserPicturePicBox.Image = (Image)new Bitmap(Image.FromFile(open.FileName), UserPicturePicBox.Size);
                viewModel.EditUserData(userData.Username, userData.WordsAdded, userData.CompletedTests, userData.PerfectTests, open.FileName);
            }
            viewModel.Save();
        }


        private void UserProfileForm_Click(object sender, EventArgs e)
        {
            EditUsernameButton.Visible = true;
            UsernameLabel.Visible = true;
            EditUserNameTextBox.Visible = false;
        }
    }
}
