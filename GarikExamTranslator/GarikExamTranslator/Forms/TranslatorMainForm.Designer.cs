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
            this.WordListButton = new System.Windows.Forms.Button();
            this.AddWordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WordListButton
            // 
            this.WordListButton.BackgroundImage = global::GarikExamTranslator.Properties.Resources.Book_Icon;
            this.WordListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WordListButton.FlatAppearance.BorderSize = 0;
            this.WordListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WordListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordListButton.Location = new System.Drawing.Point(483, 113);
            this.WordListButton.Name = "WordListButton";
            this.WordListButton.Size = new System.Drawing.Size(210, 210);
            this.WordListButton.TabIndex = 1;
            this.WordListButton.UseVisualStyleBackColor = true;
            this.WordListButton.Click += new System.EventHandler(this.WordListButton_Click);
            // 
            // AddWordButton
            // 
            this.AddWordButton.BackColor = System.Drawing.Color.Orange;
            this.AddWordButton.BackgroundImage = global::GarikExamTranslator.Properties.Resources.Add_Icon;
            this.AddWordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddWordButton.FlatAppearance.BorderSize = 0;
            this.AddWordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddWordButton.ForeColor = System.Drawing.Color.Transparent;
            this.AddWordButton.Location = new System.Drawing.Point(99, 113);
            this.AddWordButton.Name = "AddWordButton";
            this.AddWordButton.Size = new System.Drawing.Size(210, 210);
            this.AddWordButton.TabIndex = 0;
            this.AddWordButton.UseVisualStyleBackColor = false;
            this.AddWordButton.Click += new System.EventHandler(this.addWordButton_Click);
            // 
            // TranslatorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
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

