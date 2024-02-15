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
            this.addWordButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addWordButton
            // 
            this.addWordButton.Location = new System.Drawing.Point(12, 12);
            this.addWordButton.Name = "addWordButton";
            this.addWordButton.Size = new System.Drawing.Size(219, 75);
            this.addWordButton.TabIndex = 0;
            this.addWordButton.Text = "Добавить Слово";
            this.addWordButton.UseVisualStyleBackColor = true;
            this.addWordButton.Click += new System.EventHandler(this.addWordButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(569, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "Просмотреть Слова";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TranslatorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addWordButton);
            this.Name = "TranslatorMainForm";
            this.Text = "Garik Translator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addWordButton;
        private System.Windows.Forms.Button button2;
    }
}

