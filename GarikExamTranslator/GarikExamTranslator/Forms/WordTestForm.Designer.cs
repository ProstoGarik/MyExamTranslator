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
            this.AnswerButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.MainWordLabel = new System.Windows.Forms.Label();
            this.TestResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WordTestUpperLabel
            // 
            this.WordTestUpperLabel.AutoSize = true;
            this.WordTestUpperLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordTestUpperLabel.Location = new System.Drawing.Point(12, 9);
            this.WordTestUpperLabel.Name = "WordTestUpperLabel";
            this.WordTestUpperLabel.Size = new System.Drawing.Size(153, 25);
            this.WordTestUpperLabel.TabIndex = 1;
            this.WordTestUpperLabel.Text = "Тестирование";
            // 
            // WordTaskLabel
            // 
            this.WordTaskLabel.AutoSize = true;
            this.WordTaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordTaskLabel.Location = new System.Drawing.Point(13, 70);
            this.WordTaskLabel.Name = "WordTaskLabel";
            this.WordTaskLabel.Size = new System.Drawing.Size(185, 24);
            this.WordTaskLabel.TabIndex = 2;
            this.WordTaskLabel.Text = "Переведите слово:";
            // 
            // WordTranslationLabel
            // 
            this.WordTranslationLabel.AutoSize = true;
            this.WordTranslationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordTranslationLabel.Location = new System.Drawing.Point(12, 233);
            this.WordTranslationLabel.Name = "WordTranslationLabel";
            this.WordTranslationLabel.Size = new System.Drawing.Size(90, 24);
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
            // 
            // TestCounterLabel
            // 
            this.TestCounterLabel.AutoSize = true;
            this.TestCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestCounterLabel.Location = new System.Drawing.Point(673, 9);
            this.TestCounterLabel.Name = "TestCounterLabel";
            this.TestCounterLabel.Size = new System.Drawing.Size(115, 25);
            this.TestCounterLabel.TabIndex = 6;
            this.TestCounterLabel.Text = "NoCounter";
            // 
            // AnswerButton
            // 
            this.AnswerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerButton.Location = new System.Drawing.Point(12, 372);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(202, 66);
            this.AnswerButton.TabIndex = 8;
            this.AnswerButton.Text = "Ответить";
            this.AnswerButton.UseVisualStyleBackColor = true;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoBackButton.Location = new System.Drawing.Point(586, 372);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(202, 66);
            this.GoBackButton.TabIndex = 9;
            this.GoBackButton.Text = "Вернуться к списку";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // MainWordLabel
            // 
            this.MainWordLabel.AutoSize = true;
            this.MainWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainWordLabel.Location = new System.Drawing.Point(13, 121);
            this.MainWordLabel.Name = "MainWordLabel";
            this.MainWordLabel.Size = new System.Drawing.Size(81, 24);
            this.MainWordLabel.TabIndex = 10;
            this.MainWordLabel.Text = "NoWord";
            // 
            // TestResultLabel
            // 
            this.TestResultLabel.AutoSize = true;
            this.TestResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestResultLabel.Location = new System.Drawing.Point(301, 9);
            this.TestResultLabel.Name = "TestResultLabel";
            this.TestResultLabel.Size = new System.Drawing.Size(87, 24);
            this.TestResultLabel.TabIndex = 11;
            this.TestResultLabel.Text = "NoResult";
            // 
            // WordTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TestResultLabel);
            this.Controls.Add(this.MainWordLabel);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.TestCounterLabel);
            this.Controls.Add(this.TranslationInputTextBox);
            this.Controls.Add(this.WordTranslationLabel);
            this.Controls.Add(this.WordTaskLabel);
            this.Controls.Add(this.WordTestUpperLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WordTestForm";
            this.Text = "Garik Translator";
            this.Load += new System.EventHandler(this.WordTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WordTestUpperLabel;
        private System.Windows.Forms.Label WordTaskLabel;
        private System.Windows.Forms.Label WordTranslationLabel;
        private System.Windows.Forms.TextBox TranslationInputTextBox;
        private System.Windows.Forms.Label TestCounterLabel;
        private System.Windows.Forms.Button AnswerButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label MainWordLabel;
        private System.Windows.Forms.Label TestResultLabel;
    }
}