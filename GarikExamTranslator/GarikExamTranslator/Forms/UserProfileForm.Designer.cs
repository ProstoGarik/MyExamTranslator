namespace GarikExamTranslator.Forms
{
    partial class UserProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileForm));
            this.UserDataUpperLabel = new System.Windows.Forms.Label();
            this.WordsTabLabel = new System.Windows.Forms.Label();
            this.WordsAddedLabel = new System.Windows.Forms.Label();
            this.CompletedTestsLabel = new System.Windows.Forms.Label();
            this.TestsTabLabel = new System.Windows.Forms.Label();
            this.PerfectTestsLabel = new System.Windows.Forms.Label();
            this.UserPicturePicBox = new System.Windows.Forms.PictureBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ReturnToMenuButton = new System.Windows.Forms.Button();
            this.EditUsernameButton = new System.Windows.Forms.Button();
            this.EditUserNameTextBox = new System.Windows.Forms.TextBox();
            this.OtherTabLabel = new System.Windows.Forms.Label();
            this.AppStartedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicturePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDataUpperLabel
            // 
            this.UserDataUpperLabel.AutoSize = true;
            this.UserDataUpperLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserDataUpperLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserDataUpperLabel.ForeColor = System.Drawing.Color.White;
            this.UserDataUpperLabel.Location = new System.Drawing.Point(12, 9);
            this.UserDataUpperLabel.Name = "UserDataUpperLabel";
            this.UserDataUpperLabel.Size = new System.Drawing.Size(339, 31);
            this.UserDataUpperLabel.TabIndex = 4;
            this.UserDataUpperLabel.Text = "Статистика пользователя";
            // 
            // WordsTabLabel
            // 
            this.WordsTabLabel.AutoSize = true;
            this.WordsTabLabel.BackColor = System.Drawing.Color.Transparent;
            this.WordsTabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordsTabLabel.ForeColor = System.Drawing.Color.White;
            this.WordsTabLabel.Location = new System.Drawing.Point(12, 176);
            this.WordsTabLabel.Name = "WordsTabLabel";
            this.WordsTabLabel.Size = new System.Drawing.Size(93, 31);
            this.WordsTabLabel.TabIndex = 6;
            this.WordsTabLabel.Text = "Слова";
            // 
            // WordsAddedLabel
            // 
            this.WordsAddedLabel.AutoSize = true;
            this.WordsAddedLabel.BackColor = System.Drawing.Color.Transparent;
            this.WordsAddedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordsAddedLabel.ForeColor = System.Drawing.Color.White;
            this.WordsAddedLabel.Location = new System.Drawing.Point(12, 232);
            this.WordsAddedLabel.Name = "WordsAddedLabel";
            this.WordsAddedLabel.Size = new System.Drawing.Size(227, 31);
            this.WordsAddedLabel.TabIndex = 7;
            this.WordsAddedLabel.Text = "Добавлено слов:";
            // 
            // CompletedTestsLabel
            // 
            this.CompletedTestsLabel.AutoSize = true;
            this.CompletedTestsLabel.BackColor = System.Drawing.Color.Transparent;
            this.CompletedTestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompletedTestsLabel.ForeColor = System.Drawing.Color.White;
            this.CompletedTestsLabel.Location = new System.Drawing.Point(410, 232);
            this.CompletedTestsLabel.Name = "CompletedTestsLabel";
            this.CompletedTestsLabel.Size = new System.Drawing.Size(237, 31);
            this.CompletedTestsLabel.TabIndex = 9;
            this.CompletedTestsLabel.Text = "Пройдено тестов:";
            // 
            // TestsTabLabel
            // 
            this.TestsTabLabel.AutoSize = true;
            this.TestsTabLabel.BackColor = System.Drawing.Color.Transparent;
            this.TestsTabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestsTabLabel.ForeColor = System.Drawing.Color.White;
            this.TestsTabLabel.Location = new System.Drawing.Point(410, 176);
            this.TestsTabLabel.Name = "TestsTabLabel";
            this.TestsTabLabel.Size = new System.Drawing.Size(91, 31);
            this.TestsTabLabel.TabIndex = 8;
            this.TestsTabLabel.Text = "Тесты";
            // 
            // PerfectTestsLabel
            // 
            this.PerfectTestsLabel.AutoSize = true;
            this.PerfectTestsLabel.BackColor = System.Drawing.Color.Transparent;
            this.PerfectTestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PerfectTestsLabel.ForeColor = System.Drawing.Color.White;
            this.PerfectTestsLabel.Location = new System.Drawing.Point(410, 291);
            this.PerfectTestsLabel.Name = "PerfectTestsLabel";
            this.PerfectTestsLabel.Size = new System.Drawing.Size(253, 31);
            this.PerfectTestsLabel.TabIndex = 10;
            this.PerfectTestsLabel.Text = "Идеальных тестов:";
            // 
            // UserPicturePicBox
            // 
            this.UserPicturePicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserPicturePicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPicturePicBox.Location = new System.Drawing.Point(18, 58);
            this.UserPicturePicBox.Name = "UserPicturePicBox";
            this.UserPicturePicBox.Size = new System.Drawing.Size(85, 85);
            this.UserPicturePicBox.TabIndex = 12;
            this.UserPicturePicBox.TabStop = false;
            this.UserPicturePicBox.Click += new System.EventHandler(this.UserPicturePicBox_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(109, 58);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(192, 31);
            this.UsernameLabel.TabIndex = 13;
            this.UsernameLabel.Text = "Пользователь";
            // 
            // ReturnToMenuButton
            // 
            this.ReturnToMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.ReturnToMenuButton.BackgroundImage = global::GarikExamTranslator.Properties.Resources.GoBack_Icon;
            this.ReturnToMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturnToMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnToMenuButton.FlatAppearance.BorderSize = 0;
            this.ReturnToMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ReturnToMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ReturnToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnToMenuButton.Location = new System.Drawing.Point(668, -16);
            this.ReturnToMenuButton.Name = "ReturnToMenuButton";
            this.ReturnToMenuButton.Size = new System.Drawing.Size(138, 138);
            this.ReturnToMenuButton.TabIndex = 14;
            this.ReturnToMenuButton.UseVisualStyleBackColor = false;
            this.ReturnToMenuButton.Click += new System.EventHandler(this.ReturnToMenuButton_Click);
            this.ReturnToMenuButton.MouseEnter += new System.EventHandler(this.ReturnToMenuButton_MouseEnter);
            this.ReturnToMenuButton.MouseLeave += new System.EventHandler(this.ReturnToMenuButton_MouseLeave);
            // 
            // EditUsernameButton
            // 
            this.EditUsernameButton.BackColor = System.Drawing.Color.Transparent;
            this.EditUsernameButton.BackgroundImage = global::GarikExamTranslator.Properties.Resources.Edit_Icon;
            this.EditUsernameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditUsernameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditUsernameButton.FlatAppearance.BorderSize = 0;
            this.EditUsernameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EditUsernameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EditUsernameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditUsernameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditUsernameButton.Location = new System.Drawing.Point(301, 58);
            this.EditUsernameButton.Name = "EditUsernameButton";
            this.EditUsernameButton.Size = new System.Drawing.Size(50, 50);
            this.EditUsernameButton.TabIndex = 15;
            this.EditUsernameButton.UseVisualStyleBackColor = false;
            this.EditUsernameButton.Click += new System.EventHandler(this.EditUsernameButton_Click);
            // 
            // EditUserNameTextBox
            // 
            this.EditUserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditUserNameTextBox.Location = new System.Drawing.Point(115, 123);
            this.EditUserNameTextBox.MaxLength = 25;
            this.EditUserNameTextBox.Name = "EditUserNameTextBox";
            this.EditUserNameTextBox.Size = new System.Drawing.Size(236, 38);
            this.EditUserNameTextBox.TabIndex = 16;
            this.EditUserNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditUserNameTextBox_KeyDown);
            // 
            // OtherTabLabel
            // 
            this.OtherTabLabel.AutoSize = true;
            this.OtherTabLabel.BackColor = System.Drawing.Color.Transparent;
            this.OtherTabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OtherTabLabel.ForeColor = System.Drawing.Color.White;
            this.OtherTabLabel.Location = new System.Drawing.Point(12, 303);
            this.OtherTabLabel.Name = "OtherTabLabel";
            this.OtherTabLabel.Size = new System.Drawing.Size(104, 31);
            this.OtherTabLabel.TabIndex = 17;
            this.OtherTabLabel.Text = "Другое";
            // 
            // AppStartedLabel
            // 
            this.AppStartedLabel.AutoSize = true;
            this.AppStartedLabel.BackColor = System.Drawing.Color.Transparent;
            this.AppStartedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppStartedLabel.ForeColor = System.Drawing.Color.White;
            this.AppStartedLabel.Location = new System.Drawing.Point(12, 365);
            this.AppStartedLabel.Name = "AppStartedLabel";
            this.AppStartedLabel.Size = new System.Drawing.Size(301, 31);
            this.AppStartedLabel.TabIndex = 18;
            this.AppStartedLabel.Text = "Запусков приложения:";
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GarikExamTranslator.Properties.Resources.Orange_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AppStartedLabel);
            this.Controls.Add(this.OtherTabLabel);
            this.Controls.Add(this.EditUserNameTextBox);
            this.Controls.Add(this.EditUsernameButton);
            this.Controls.Add(this.ReturnToMenuButton);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UserPicturePicBox);
            this.Controls.Add(this.PerfectTestsLabel);
            this.Controls.Add(this.CompletedTestsLabel);
            this.Controls.Add(this.TestsTabLabel);
            this.Controls.Add(this.WordsAddedLabel);
            this.Controls.Add(this.WordsTabLabel);
            this.Controls.Add(this.UserDataUpperLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserProfileForm";
            this.Text = "Garik Translator";
            this.Activated += new System.EventHandler(this.UserProfileForm_Activated);
            this.Load += new System.EventHandler(this.UserProfileForm_Load);
            this.Shown += new System.EventHandler(this.UserProfileForm_Shown);
            this.Click += new System.EventHandler(this.UserProfileForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.UserPicturePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserDataUpperLabel;
        private System.Windows.Forms.Label WordsTabLabel;
        private System.Windows.Forms.Label WordsAddedLabel;
        private System.Windows.Forms.Label CompletedTestsLabel;
        private System.Windows.Forms.Label TestsTabLabel;
        private System.Windows.Forms.Label PerfectTestsLabel;
        private System.Windows.Forms.PictureBox UserPicturePicBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button ReturnToMenuButton;
        private System.Windows.Forms.Button EditUsernameButton;
        private System.Windows.Forms.TextBox EditUserNameTextBox;
        private System.Windows.Forms.Label OtherTabLabel;
        private System.Windows.Forms.Label AppStartedLabel;
    }
}