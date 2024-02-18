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
            // WordListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WordsLabel);
            this.Controls.Add(this.WordListUpperLabel);
            this.Name = "WordListForm";
            this.Text = "Word List";
            this.Load += new System.EventHandler(this.WordListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WordListUpperLabel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label WordsLabel;
    }
}