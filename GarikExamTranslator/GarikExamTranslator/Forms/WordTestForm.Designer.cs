namespace GarikExamTranslator.Forms
{
    partial class WordTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordTestForm));
            this.WordTestUpperLabel = new System.Windows.Forms.Label();
            this.WordTaskLabel = new System.Windows.Forms.Label();
            this.WordTranslationLabel = new System.Windows.Forms.Label();
            this.TranslationInputTextBox = new System.Windows.Forms.TextBox();
            this.TestCounterLabel = new System.Windows.Forms.Label();
            this.MainWordLabel = new System.Windows.Forms.Label();
            this.TestResultLabel = new System.Windows.Forms.Label();
            this.AnswerButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.PerfectResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WordTestUpperLabel
            // 
            this.WordTestUpperLabel.AutoSize = true;
            this.WordTestUpperLabel.BackColor = System.Drawing.Color.Transparent;
            this.WordTestUpperLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordTestUpperLabel.ForeColor = System.Drawing.Color.White;
            this.WordTestUpperLabel.Location = new System.Drawing.Point(12, 9);
            this.WordTestUpperLabel.Name = "WordTestUpperLabel";
            this.WordTestUpperLabel.Size = new System.Drawing.Size(191, 31);
            this.WordTestUpperLabel.TabIndex = 1;
            this.WordTestUpperLabel.Text = "Тестирование";
            // 
            // WordTaskLabel
            // 
            this.WordTaskLabel.AutoSize = true;
            this.WordTaskLabel.BackColor = System.Drawing.Color.Transparent;
            this.WordTaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordTaskLabel.ForeColor = System.Drawing.Color.White;
            this.WordTaskLabel.Location = new System.Drawing.Point(13, 70);
            this.WordTaskLabel.Name = "WordTaskLabel";
            this.WordTaskLabel.Size = new System.Drawing.Size(254, 31);
            this.WordTaskLabel.TabIndex = 2;
            this.WordTaskLabel.Text = "Переведите слово:";
            // 
            // WordTranslationLabel
            // 
            this.WordTranslationLabel.AutoSize = true;
            this.WordTranslationLabel.BackColor = System.Drawing.Color.Transparent;
            this.WordTranslationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordTranslationLabel.ForeColor = System.Drawing.Color.White;
            this.WordTranslationLabel.Location = new System.Drawing.Point(12, 233);
            this.WordTranslationLabel.Name = "WordTranslationLabel";
            this.WordTranslationLabel.Size = new System.Drawing.Size(124, 31);
            this.WordTranslationLabel.TabIndex = 3;
            this.WordTranslationLabel.Text = "Перевод";
            // 
            // TranslationInputTextBox
            // 
            this.TranslationInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TranslationInputTextBox.Location = new System.Drawing.Point(12, 278);
            this.TranslationInputTextBox.Name = "TranslationInputTextBox";
            this.TranslationInputTextBox.Size = new System.Drawing.Size(376, 29);
            this.TranslationInputTextBox.TabIndex = 5;
            this.TranslationInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TranslationInputTextBox_KeyDown);
            // 
            // TestCounterLabel
            // 
            this.TestCounterLabel.AutoSize = true;
            this.TestCounterLabel.BackColor = System.Drawing.Color.Transparent;
            this.TestCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestCounterLabel.ForeColor = System.Drawing.Color.White;
            this.TestCounterLabel.Location = new System.Drawing.Point(642, 9);
            this.TestCounterLabel.Name = "TestCounterLabel";
            this.TestCounterLabel.Size = new System.Drawing.Size(146, 31);
            this.TestCounterLabel.TabIndex = 6;
            this.TestCounterLabel.Text = "NoCounter";
            // 
            // MainWordLabel
            // 
            this.MainWordLabel.AutoSize = true;
            this.MainWordLabel.BackColor = System.Drawing.Color.Transparent;
            this.MainWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainWordLabel.ForeColor = System.Drawing.Color.White;
            this.MainWordLabel.Location = new System.Drawing.Point(13, 121);
            this.MainWordLabel.Name = "MainWordLabel";
            this.MainWordLabel.Size = new System.Drawing.Size(113, 31);
            this.MainWordLabel.TabIndex = 10;
            this.MainWordLabel.Text = "NoWord";
            // 
            // TestResultLabel
            // 
            this.TestResultLabel.AutoSize = true;
            this.TestResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.TestResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestResultLabel.ForeColor = System.Drawing.Color.White;
            this.TestResultLabel.Location = new System.Drawing.Point(301, 9);
            this.TestResultLabel.Name = "TestResultLabel";
            this.TestResultLabel.Size = new System.Drawing.Size(127, 31);
            this.TestResultLabel.TabIndex = 11;
            this.TestResultLabel.Text = "NoResult";
            // 
            // AnswerButton
            // 
            this.AnswerButton.BackColor = System.Drawing.Color.Transparent;
            this.AnswerButton.BackgroundImage = global::GarikExamTranslator.Properties.Resources.Done_Icon;
            this.AnswerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnswerButton.FlatAppearance.BorderSize = 0;
            this.AnswerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AnswerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerButton.Location = new System.Drawing.Point(12, 328);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(110, 110);
            this.AnswerButton.TabIndex = 12;
            this.AnswerButton.UseVisualStyleBackColor = false;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            this.AnswerButton.MouseEnter += new System.EventHandler(this.AnswerButton_MouseEnter);
            this.AnswerButton.MouseLeave += new System.EventHandler(this.AnswerButton_MouseLeave);
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.Color.Transparent;
            this.GoBackButton.BackgroundImage = global::GarikExamTranslator.Properties.Resources.GoBack_Icon;
            this.GoBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoBackButton.FlatAppearance.BorderSize = 0;
            this.GoBackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GoBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GoBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoBackButton.Location = new System.Drawing.Point(648, 308);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(138, 138);
            this.GoBackButton.TabIndex = 9;
            this.GoBackButton.UseVisualStyleBackColor = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            this.GoBackButton.MouseEnter += new System.EventHandler(this.GoBackButton_MouseEnter);
            this.GoBackButton.MouseLeave += new System.EventHandler(this.GoBackButton_MouseLeave);
            // 
            // PerfectResultLabel
            // 
            this.PerfectResultLabel.AutoSize = true;
            this.PerfectResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.PerfectResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PerfectResultLabel.ForeColor = System.Drawing.Color.White;
            this.PerfectResultLabel.Location = new System.Drawing.Point(301, 83);
            this.PerfectResultLabel.Name = "PerfectResultLabel";
            this.PerfectResultLabel.Size = new System.Drawing.Size(226, 31);
            this.PerfectResultLabel.TabIndex = 13;
            this.PerfectResultLabel.Text = "Идеальный тест!";
            // 
            // WordTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = global::GarikExamTranslator.Properties.Resources.Orange_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PerfectResultLabel);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.TestResultLabel);
            this.Controls.Add(this.MainWordLabel);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.TestCounterLabel);
            this.Controls.Add(this.TranslationInputTextBox);
            this.Controls.Add(this.WordTranslationLabel);
            this.Controls.Add(this.WordTaskLabel);
            this.Controls.Add(this.WordTestUpperLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WordTestForm";
            this.Text = "Garik Translator";
            this.Activated += new System.EventHandler(this.WordTestForm_Activated);
            this.Load += new System.EventHandler(this.WordTestForm_Load);
            this.Shown += new System.EventHandler(this.WordTestForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WordTestUpperLabel;
        private System.Windows.Forms.Label WordTaskLabel;
        private System.Windows.Forms.Label WordTranslationLabel;
        private System.Windows.Forms.TextBox TranslationInputTextBox;
        private System.Windows.Forms.Label TestCounterLabel;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label MainWordLabel;
        private System.Windows.Forms.Label TestResultLabel;
        private System.Windows.Forms.Button AnswerButton;
        private System.Windows.Forms.Label PerfectResultLabel;
    }
}