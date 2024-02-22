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
            this.WordListUpperLabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.WordsLabel = new System.Windows.Forms.Label();
            this.ReturnToMenuButton = new System.Windows.Forms.Button();
            this.EditWordButton = new System.Windows.Forms.Button();
            this.EnterWordIndexLabel = new System.Windows.Forms.Label();
            this.WordIndexInputTextBox = new System.Windows.Forms.TextBox();
            this.IndexInputCheckLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // WordListUpperLabel
            // 
            this.WordListUpperLabel.AutoSize = true;
            this.WordListUpperLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordListUpperLabel.Location = new System.Drawing.Point(12, 9);
            this.WordListUpperLabel.Name = "WordListUpperLabel";
            this.WordListUpperLabel.Size = new System.Drawing.Size(137, 25);
            this.WordListUpperLabel.TabIndex = 0;
            this.WordListUpperLabel.Text = "Список слов";
            // 
            // WordsLabel
            // 
            this.WordsLabel.AutoSize = true;
            this.WordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordsLabel.Location = new System.Drawing.Point(13, 45);
            this.WordsLabel.Name = "WordsLabel";
            this.WordsLabel.Size = new System.Drawing.Size(92, 24);
            this.WordsLabel.TabIndex = 1;
            this.WordsLabel.Text = "Слов нет";
            // 
            // ReturnToMenuButton
            // 
            this.ReturnToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnToMenuButton.Location = new System.Drawing.Point(559, 12);
            this.ReturnToMenuButton.Name = "ReturnToMenuButton";
            this.ReturnToMenuButton.Size = new System.Drawing.Size(229, 77);
            this.ReturnToMenuButton.TabIndex = 6;
            this.ReturnToMenuButton.Text = "Вернуться";
            this.ReturnToMenuButton.UseVisualStyleBackColor = true;
            this.ReturnToMenuButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // EditWordButton
            // 
            this.EditWordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditWordButton.Location = new System.Drawing.Point(528, 372);
            this.EditWordButton.Name = "EditWordButton";
            this.EditWordButton.Size = new System.Drawing.Size(202, 66);
            this.EditWordButton.TabIndex = 7;
            this.EditWordButton.Text = "Редактировать";
            this.EditWordButton.UseVisualStyleBackColor = true;
            this.EditWordButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EnterWordIndexLabel
            // 
            this.EnterWordIndexLabel.AutoSize = true;
            this.EnterWordIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterWordIndexLabel.Location = new System.Drawing.Point(468, 260);
            this.EnterWordIndexLabel.Name = "EnterWordIndexLabel";
            this.EnterWordIndexLabel.Size = new System.Drawing.Size(320, 25);
            this.EnterWordIndexLabel.TabIndex = 8;
            this.EnterWordIndexLabel.Text = "Введите номер слова в списке";
            // 
            // WordIndexInputTextBox
            // 
            this.WordIndexInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordIndexInputTextBox.Location = new System.Drawing.Point(528, 299);
            this.WordIndexInputTextBox.Name = "WordIndexInputTextBox";
            this.WordIndexInputTextBox.Size = new System.Drawing.Size(202, 29);
            this.WordIndexInputTextBox.TabIndex = 9;
            this.WordIndexInputTextBox.TextChanged += new System.EventHandler(this.IndexInputCheckLabel_TextChanged);
            // 
            // IndexInputCheckLabel
            // 
            this.IndexInputCheckLabel.AutoSize = true;
            this.IndexInputCheckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IndexInputCheckLabel.Location = new System.Drawing.Point(468, 331);
            this.IndexInputCheckLabel.Name = "IndexInputCheckLabel";
            this.IndexInputCheckLabel.Size = new System.Drawing.Size(320, 25);
            this.IndexInputCheckLabel.TabIndex = 10;
            this.IndexInputCheckLabel.Text = "Введите номер слова в списке";
            // 
            // WordListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IndexInputCheckLabel);
            this.Controls.Add(this.WordIndexInputTextBox);
            this.Controls.Add(this.EnterWordIndexLabel);
            this.Controls.Add(this.EditWordButton);
            this.Controls.Add(this.ReturnToMenuButton);
            this.Controls.Add(this.WordsLabel);
            this.Controls.Add(this.WordListUpperLabel);
            this.Name = "WordListForm";
            this.Text = "Garik Translator";
            this.Activated += new System.EventHandler(this.WordListForm_Activated);
            this.Load += new System.EventHandler(this.WordListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WordListUpperLabel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label WordsLabel;
        private System.Windows.Forms.Button ReturnToMenuButton;
        private System.Windows.Forms.Button EditWordButton;
        private System.Windows.Forms.Label EnterWordIndexLabel;
        private System.Windows.Forms.TextBox WordIndexInputTextBox;
        private System.Windows.Forms.Label IndexInputCheckLabel;
    }
}