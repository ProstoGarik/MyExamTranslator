namespace GarikExamTranslator
{
    partial class AddAndEditWordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAndEditWordForm));
            this.AddEditLabel = new System.Windows.Forms.Label();
            this.WordLabel = new System.Windows.Forms.Label();
            this.TranslationLabel = new System.Windows.Forms.Label();
            this.WordInputTextBox = new System.Windows.Forms.TextBox();
            this.TranslationInputTextBox = new System.Windows.Forms.TextBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.WordGroupsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddEditLabel
            // 
            this.AddEditLabel.AutoSize = true;
            this.AddEditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEditLabel.ForeColor = System.Drawing.Color.White;
            this.AddEditLabel.Location = new System.Drawing.Point(12, 9);
            this.AddEditLabel.Name = "AddEditLabel";
            this.AddEditLabel.Size = new System.Drawing.Size(446, 33);
            this.AddEditLabel.TabIndex = 0;
            this.AddEditLabel.Text = "Добавление / Изменение слова";
            // 
            // WordLabel
            // 
            this.WordLabel.AutoSize = true;
            this.WordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordLabel.ForeColor = System.Drawing.Color.White;
            this.WordLabel.Location = new System.Drawing.Point(12, 77);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(93, 31);
            this.WordLabel.TabIndex = 1;
            this.WordLabel.Text = "Слово";
            // 
            // TranslationLabel
            // 
            this.TranslationLabel.AutoSize = true;
            this.TranslationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TranslationLabel.ForeColor = System.Drawing.Color.White;
            this.TranslationLabel.Location = new System.Drawing.Point(12, 223);
            this.TranslationLabel.Name = "TranslationLabel";
            this.TranslationLabel.Size = new System.Drawing.Size(124, 31);
            this.TranslationLabel.TabIndex = 2;
            this.TranslationLabel.Text = "Перевод";
            // 
            // WordInputTextBox
            // 
            this.WordInputTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.WordInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordInputTextBox.Location = new System.Drawing.Point(17, 121);
            this.WordInputTextBox.Name = "WordInputTextBox";
            this.WordInputTextBox.Size = new System.Drawing.Size(376, 29);
            this.WordInputTextBox.TabIndex = 3;
            // 
            // TranslationInputTextBox
            // 
            this.TranslationInputTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TranslationInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TranslationInputTextBox.Location = new System.Drawing.Point(17, 270);
            this.TranslationInputTextBox.Name = "TranslationInputTextBox";
            this.TranslationInputTextBox.Size = new System.Drawing.Size(376, 29);
            this.TranslationInputTextBox.TabIndex = 4;
            // 
            // DoneButton
            // 
            this.DoneButton.BackgroundImage = global::GarikExamTranslator.Properties.Resources.Done_Icon;
            this.DoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoneButton.FlatAppearance.BorderSize = 0;
            this.DoneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoneButton.Location = new System.Drawing.Point(26, 328);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(110, 110);
            this.DoneButton.TabIndex = 5;
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            this.DoneButton.MouseEnter += new System.EventHandler(this.DoneButton_MouseEnter);
            this.DoneButton.MouseLeave += new System.EventHandler(this.DoneButton_MouseLeave);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(559, 361);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(229, 77);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Удалить слово";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // WordGroupsComboBox
            // 
            this.WordGroupsComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.WordGroupsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordGroupsComboBox.FormattingEnabled = true;
            this.WordGroupsComboBox.Location = new System.Drawing.Point(546, 121);
            this.WordGroupsComboBox.Name = "WordGroupsComboBox";
            this.WordGroupsComboBox.Size = new System.Drawing.Size(103, 32);
            this.WordGroupsComboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(541, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Группа";
            // 
            // AddAndEditWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WordGroupsComboBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.TranslationInputTextBox);
            this.Controls.Add(this.WordInputTextBox);
            this.Controls.Add(this.TranslationLabel);
            this.Controls.Add(this.WordLabel);
            this.Controls.Add(this.AddEditLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAndEditWordForm";
            this.Text = "Garik Translator";
            this.Activated += new System.EventHandler(this.AddAndEditWordForm_Activated);
            this.Load += new System.EventHandler(this.AddAndEditWordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddEditLabel;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.Label TranslationLabel;
        private System.Windows.Forms.TextBox WordInputTextBox;
        private System.Windows.Forms.TextBox TranslationInputTextBox;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ComboBox WordGroupsComboBox;
        private System.Windows.Forms.Label label1;
    }
}