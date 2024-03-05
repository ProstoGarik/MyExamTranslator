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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ReturnToMenuButton = new System.Windows.Forms.Button();
            this.StartTestButton = new System.Windows.Forms.Button();
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
            // StartTestButton
            // 
            this.StartTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartTestButton.Location = new System.Drawing.Point(559, 108);
            this.StartTestButton.Name = "StartTestButton";
            this.StartTestButton.Size = new System.Drawing.Size(229, 77);
            this.StartTestButton.TabIndex = 11;
            this.StartTestButton.Text = "Начать тест";
            this.StartTestButton.UseVisualStyleBackColor = true;
            this.StartTestButton.Click += new System.EventHandler(this.StartTestButton_Click);
            // 
            // WordListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartTestButton);
            this.Controls.Add(this.ReturnToMenuButton);
            this.Controls.Add(this.WordListUpperLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button ReturnToMenuButton;
        private System.Windows.Forms.Button StartTestButton;
    }
}