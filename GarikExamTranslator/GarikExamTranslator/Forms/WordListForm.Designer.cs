namespace GarikExamTranslator
{
    partial class WordListForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordListForm));
            this.WordListUpperLabel = new System.Windows.Forms.Label();
            this.StartTestLabel = new System.Windows.Forms.Label();
            this.DeleteGroupLabel = new System.Windows.Forms.Label();
            this.EditWordButton = new System.Windows.Forms.Button();
            this.DeleteWordButton = new System.Windows.Forms.Button();
            this.DeleteGroupButton = new System.Windows.Forms.Button();
            this.StartTestButton = new System.Windows.Forms.Button();
            this.ReturnToMenuButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.WordGroupsComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // WordListUpperLabel
            // 
            this.WordListUpperLabel.AutoSize = true;
            this.WordListUpperLabel.BackColor = System.Drawing.Color.Transparent;
            this.WordListUpperLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordListUpperLabel.ForeColor = System.Drawing.Color.White;
            this.WordListUpperLabel.Location = new System.Drawing.Point(12, 9);
            this.WordListUpperLabel.Name = "WordListUpperLabel";
            this.WordListUpperLabel.Size = new System.Drawing.Size(137, 25);
            this.WordListUpperLabel.TabIndex = 0;
            this.WordListUpperLabel.Text = "Список слов";
            // 
            // StartTestLabel
            // 
            this.StartTestLabel.AutoSize = true;
            this.StartTestLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartTestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartTestLabel.ForeColor = System.Drawing.Color.White;
            this.StartTestLabel.Location = new System.Drawing.Point(662, 252);
            this.StartTestLabel.Name = "StartTestLabel";
            this.StartTestLabel.Size = new System.Drawing.Size(132, 25);
            this.StartTestLabel.TabIndex = 13;
            this.StartTestLabel.Text = "Начать тест";
            // 
            // DeleteGroupLabel
            // 
            this.DeleteGroupLabel.AutoSize = true;
            this.DeleteGroupLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeleteGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteGroupLabel.ForeColor = System.Drawing.Color.White;
            this.DeleteGroupLabel.Location = new System.Drawing.Point(645, 416);
            this.DeleteGroupLabel.Name = "DeleteGroupLabel";
            this.DeleteGroupLabel.Size = new System.Drawing.Size(166, 25);
            this.DeleteGroupLabel.TabIndex = 15;
            this.DeleteGroupLabel.Text = "Удалить группу";
            // 
            // EditWordButton
            // 
            this.EditWordButton.BackColor = System.Drawing.Color.YellowGreen;
            this.EditWordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditWordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditWordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditWordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditWordButton.ForeColor = System.Drawing.Color.White;
            this.EditWordButton.Location = new System.Drawing.Point(410, 12);
            this.EditWordButton.Name = "EditWordButton";
            this.EditWordButton.Size = new System.Drawing.Size(105, 43);
            this.EditWordButton.TabIndex = 16;
            this.EditWordButton.Text = "Изменить";
            this.EditWordButton.UseVisualStyleBackColor = false;
            this.EditWordButton.Click += new System.EventHandler(this.EditWordButton_Click);
            // 
            // DeleteWordButton
            // 
            this.DeleteWordButton.BackColor = System.Drawing.Color.Crimson;
            this.DeleteWordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteWordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteWordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteWordButton.ForeColor = System.Drawing.Color.White;
            this.DeleteWordButton.Location = new System.Drawing.Point(536, 12);
            this.DeleteWordButton.Name = "DeleteWordButton";
            this.DeleteWordButton.Size = new System.Drawing.Size(105, 43);
            this.DeleteWordButton.TabIndex = 17;
            this.DeleteWordButton.Text = "Удалить";
            this.DeleteWordButton.UseVisualStyleBackColor = false;
            this.DeleteWordButton.Click += new System.EventHandler(this.DeleteWordButton_Click);
            // 
            // DeleteGroupButton
            // 
            this.DeleteGroupButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteGroupButton.BackgroundImage = global::GarikExamTranslator.Properties.Resources.Delete_Icon;
            this.DeleteGroupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteGroupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteGroupButton.FlatAppearance.BorderSize = 0;
            this.DeleteGroupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteGroupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DeleteGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteGroupButton.Location = new System.Drawing.Point(667, 312);
            this.DeleteGroupButton.Name = "DeleteGroupButton";
            this.DeleteGroupButton.Size = new System.Drawing.Size(110, 110);
            this.DeleteGroupButton.TabIndex = 14;
            this.DeleteGroupButton.UseVisualStyleBackColor = false;
            this.DeleteGroupButton.Click += new System.EventHandler(this.DeleteGroupButton_Click);
            this.DeleteGroupButton.MouseEnter += new System.EventHandler(this.DeleteGroupButton_MouseEnter);
            this.DeleteGroupButton.MouseLeave += new System.EventHandler(this.DeleteGroupButton_MouseLeave);
            // 
            // StartTestButton
            // 
            this.StartTestButton.BackColor = System.Drawing.Color.Transparent;
            this.StartTestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartTestButton.FlatAppearance.BorderSize = 0;
            this.StartTestButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StartTestButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StartTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartTestButton.Image = global::GarikExamTranslator.Properties.Resources.Test_Icon;
            this.StartTestButton.Location = new System.Drawing.Point(654, 99);
            this.StartTestButton.Name = "StartTestButton";
            this.StartTestButton.Size = new System.Drawing.Size(140, 150);
            this.StartTestButton.TabIndex = 11;
            this.StartTestButton.UseVisualStyleBackColor = false;
            this.StartTestButton.Click += new System.EventHandler(this.StartTestButton_Click);
            this.StartTestButton.MouseEnter += new System.EventHandler(this.StartTestButton_MouseEnter);
            this.StartTestButton.MouseLeave += new System.EventHandler(this.StartTestButton_MouseLeave);
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
            this.ReturnToMenuButton.Location = new System.Drawing.Point(667, -25);
            this.ReturnToMenuButton.Name = "ReturnToMenuButton";
            this.ReturnToMenuButton.Size = new System.Drawing.Size(138, 138);
            this.ReturnToMenuButton.TabIndex = 6;
            this.ReturnToMenuButton.UseVisualStyleBackColor = false;
            this.ReturnToMenuButton.Click += new System.EventHandler(this.DoneButton_Click);
            this.ReturnToMenuButton.MouseEnter += new System.EventHandler(this.ReturnToMenuButton_MouseEnter);
            this.ReturnToMenuButton.MouseLeave += new System.EventHandler(this.ReturnToMenuButton_MouseLeave);
            // 
            // WordGroupsComboBox
            // 
            this.WordGroupsComboBox.BackColor = System.Drawing.Color.Orange;
            this.WordGroupsComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WordGroupsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WordGroupsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordGroupsComboBox.ForeColor = System.Drawing.Color.White;
            this.WordGroupsComboBox.FormattingEnabled = true;
            this.WordGroupsComboBox.Location = new System.Drawing.Point(155, 2);
            this.WordGroupsComboBox.Name = "WordGroupsComboBox";
            this.WordGroupsComboBox.Size = new System.Drawing.Size(217, 33);
            this.WordGroupsComboBox.TabIndex = 12;
            this.WordGroupsComboBox.Text = "Без Группы";
            this.WordGroupsComboBox.SelectedIndexChanged += new System.EventHandler(this.WordGroupsComboBox_SelectedIndexChanged);
            // 
            // WordListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = global::GarikExamTranslator.Properties.Resources.Orange_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteWordButton);
            this.Controls.Add(this.EditWordButton);
            this.Controls.Add(this.DeleteGroupLabel);
            this.Controls.Add(this.DeleteGroupButton);
            this.Controls.Add(this.StartTestLabel);
            this.Controls.Add(this.WordGroupsComboBox);
            this.Controls.Add(this.StartTestButton);
            this.Controls.Add(this.ReturnToMenuButton);
            this.Controls.Add(this.WordListUpperLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WordListForm";
            this.Text = "Garik Translator";
            this.Activated += new System.EventHandler(this.WordListForm_Activated);
            this.Deactivate += new System.EventHandler(this.WordListForm_Deactivate);
            this.Load += new System.EventHandler(this.WordListForm_Load);
            this.Shown += new System.EventHandler(this.WordListForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WordListUpperLabel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button ReturnToMenuButton;
        private System.Windows.Forms.Button StartTestButton;
        private System.Windows.Forms.Label StartTestLabel;
        private System.Windows.Forms.Button DeleteGroupButton;
        private System.Windows.Forms.Label DeleteGroupLabel;
        private System.Windows.Forms.Button EditWordButton;
        private System.Windows.Forms.Button DeleteWordButton;
        private System.Windows.Forms.ComboBox WordGroupsComboBox;
    }
}