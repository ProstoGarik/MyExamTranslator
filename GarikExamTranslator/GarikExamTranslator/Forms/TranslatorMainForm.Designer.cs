namespace GarikExamTranslator
{
    partial class TranslatorMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslatorMainForm));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.AddWordLabel = new System.Windows.Forms.Label();
            this.WordListLabel = new System.Windows.Forms.Label();
            this.WordListButton = new System.Windows.Forms.Button();
            this.AddWordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(228, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(359, 42);
            this.WelcomeLabel.TabIndex = 2;
            this.WelcomeLabel.Text = "Добро пожаловать!";
            // 
            // AddWordLabel
            // 
            this.AddWordLabel.AutoSize = true;
            this.AddWordLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddWordLabel.ForeColor = System.Drawing.Color.White;
            this.AddWordLabel.Location = new System.Drawing.Point(99, 326);
            this.AddWordLabel.Name = "AddWordLabel";
            this.AddWordLabel.Size = new System.Drawing.Size(215, 31);
            this.AddWordLabel.TabIndex = 3;
            this.AddWordLabel.Text = "Добавить слово";
            // 
            // WordListLabel
            // 
            this.WordListLabel.AutoSize = true;
            this.WordListLabel.BackColor = System.Drawing.Color.Transparent;
            this.WordListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordListLabel.ForeColor = System.Drawing.Color.White;
            this.WordListLabel.Location = new System.Drawing.Point(477, 326);
            this.WordListLabel.Name = "WordListLabel";
            this.WordListLabel.Size = new System.Drawing.Size(268, 31);
            this.WordListLabel.TabIndex = 4;
            this.WordListLabel.Text = "Добавленные слова";
            // 
            // WordListButton
            // 
            this.WordListButton.BackColor = System.Drawing.Color.Transparent;
            this.WordListButton.BackgroundImage = global::GarikExamTranslator.Properties.Resources.Book_Icon;
            this.WordListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WordListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WordListButton.FlatAppearance.BorderSize = 0;
            this.WordListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.WordListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.WordListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WordListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordListButton.Location = new System.Drawing.Point(483, 113);
            this.WordListButton.Name = "WordListButton";
            this.WordListButton.Size = new System.Drawing.Size(210, 210);
            this.WordListButton.TabIndex = 1;
            this.WordListButton.UseVisualStyleBackColor = false;
            this.WordListButton.Click += new System.EventHandler(this.WordListButton_Click);
            this.WordListButton.MouseEnter += new System.EventHandler(this.WordListButton_MouseEnter);
            this.WordListButton.MouseLeave += new System.EventHandler(this.WordListButton_MouseLeave);
            // 
            // AddWordButton
            // 
            this.AddWordButton.BackColor = System.Drawing.Color.Transparent;
            this.AddWordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddWordButton.BackgroundImage")));
            this.AddWordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddWordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddWordButton.FlatAppearance.BorderSize = 0;
            this.AddWordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddWordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddWordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddWordButton.ForeColor = System.Drawing.Color.Transparent;
            this.AddWordButton.Location = new System.Drawing.Point(86, 113);
            this.AddWordButton.Name = "AddWordButton";
            this.AddWordButton.Size = new System.Drawing.Size(210, 210);
            this.AddWordButton.TabIndex = 0;
            this.AddWordButton.UseVisualStyleBackColor = false;
            this.AddWordButton.Click += new System.EventHandler(this.addWordButton_Click);
            this.AddWordButton.MouseEnter += new System.EventHandler(this.AddWordButton_MouseEnter);
            this.AddWordButton.MouseLeave += new System.EventHandler(this.AddWordButton_MouseLeave);
            // 
            // TranslatorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = global::GarikExamTranslator.Properties.Resources.Orange_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WordListLabel);
            this.Controls.Add(this.AddWordLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.WordListButton);
            this.Controls.Add(this.AddWordButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TranslatorMainForm";
            this.Text = "Garik Translator";
            this.Activated += new System.EventHandler(this.TranslatorMainForm_Activated);
            this.Load += new System.EventHandler(this.TranslatorMainForm_Load);
            this.Shown += new System.EventHandler(this.TranslatorMainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddWordButton;
        private System.Windows.Forms.Button WordListButton;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label AddWordLabel;
        private System.Windows.Forms.Label WordListLabel;
    }
}

