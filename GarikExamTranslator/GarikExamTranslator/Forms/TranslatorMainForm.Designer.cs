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
            this.AddWordButton = new System.Windows.Forms.Button();
            this.WordListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddWordButton
            // 
            this.AddWordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddWordButton.Location = new System.Drawing.Point(12, 12);
            this.AddWordButton.Name = "AddWordButton";
            this.AddWordButton.Size = new System.Drawing.Size(219, 75);
            this.AddWordButton.TabIndex = 0;
            this.AddWordButton.Text = "Добавить Слово";
            this.AddWordButton.UseVisualStyleBackColor = true;
            this.AddWordButton.Click += new System.EventHandler(this.addWordButton_Click);
            // 
            // WordListButton
            // 
            this.WordListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordListButton.Location = new System.Drawing.Point(569, 12);
            this.WordListButton.Name = "WordListButton";
            this.WordListButton.Size = new System.Drawing.Size(219, 75);
            this.WordListButton.TabIndex = 1;
            this.WordListButton.Text = "Просмотреть Слова";
            this.WordListButton.UseVisualStyleBackColor = true;
            this.WordListButton.Click += new System.EventHandler(this.WordListButton_Click);
            // 
            // TranslatorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WordListButton);
            this.Controls.Add(this.AddWordButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TranslatorMainForm";
            this.Text = "Garik Translator";
            this.Load += new System.EventHandler(this.TranslatorMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddWordButton;
        private System.Windows.Forms.Button WordListButton;
    }
}

