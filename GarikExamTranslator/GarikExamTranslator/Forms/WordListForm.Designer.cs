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
            this.WordGroupsComboBox = new System.Windows.Forms.ComboBox();
            this.StartTestLabel = new System.Windows.Forms.Label();
            this.StartTestButton = new System.Windows.Forms.Button();
            this.ReturnToMenuButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // WordListUpperLabel
            // 
            this.WordListUpperLabel.AutoSize = true;
            this.WordListUpperLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordListUpperLabel.ForeColor = System.Drawing.Color.White;
            this.WordListUpperLabel.Location = new System.Drawing.Point(12, 9);
            this.WordListUpperLabel.Name = "WordListUpperLabel";
            this.WordListUpperLabel.Size = new System.Drawing.Size(137, 25);
            this.WordListUpperLabel.TabIndex = 0;
            this.WordListUpperLabel.Text = "Список слов";
            // 
            // WordGroupsComboBox
            // 
            this.WordGroupsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordGroupsComboBox.FormattingEnabled = true;
            this.WordGroupsComboBox.Location = new System.Drawing.Point(155, 12);
            this.WordGroupsComboBox.Name = "WordGroupsComboBox";
            this.WordGroupsComboBox.Size = new System.Drawing.Size(121, 32);
            this.WordGroupsComboBox.TabIndex = 12;
            this.WordGroupsComboBox.SelectedIndexChanged += new System.EventHandler(this.WordGroupsComboBox_SelectedIndexChanged);
            // 
            // StartTestLabel
            // 
            this.StartTestLabel.AutoSize = true;
            this.StartTestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartTestLabel.ForeColor = System.Drawing.Color.White;
            this.StartTestLabel.Location = new System.Drawing.Point(662, 241);
            this.StartTestLabel.Name = "StartTestLabel";
            this.StartTestLabel.Size = new System.Drawing.Size(132, 25);
            this.StartTestLabel.TabIndex = 13;
            this.StartTestLabel.Text = "Начать тест";
            // 
            // StartTestButton
            // 
            this.StartTestButton.FlatAppearance.BorderSize = 0;
            this.StartTestButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.StartTestButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.StartTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartTestButton.Image = global::GarikExamTranslator.Properties.Resources.Test_Icon;
            this.StartTestButton.Location = new System.Drawing.Point(654, 99);
            this.StartTestButton.Name = "StartTestButton";
            this.StartTestButton.Size = new System.Drawing.Size(140, 150);
            this.StartTestButton.TabIndex = 11;
            this.StartTestButton.UseVisualStyleBackColor = true;
            this.StartTestButton.Click += new System.EventHandler(this.StartTestButton_Click);
            this.StartTestButton.MouseEnter += new System.EventHandler(this.StartTestButton_MouseEnter);
            this.StartTestButton.MouseLeave += new System.EventHandler(this.StartTestButton_MouseLeave);
            // 
            // ReturnToMenuButton
            // 
            this.ReturnToMenuButton.BackgroundImage = global::GarikExamTranslator.Properties.Resources.GoBack_Icon;
            this.ReturnToMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturnToMenuButton.FlatAppearance.BorderSize = 0;
            this.ReturnToMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.ReturnToMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.ReturnToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnToMenuButton.Location = new System.Drawing.Point(667, -25);
            this.ReturnToMenuButton.Name = "ReturnToMenuButton";
            this.ReturnToMenuButton.Size = new System.Drawing.Size(138, 138);
            this.ReturnToMenuButton.TabIndex = 6;
            this.ReturnToMenuButton.UseVisualStyleBackColor = true;
            this.ReturnToMenuButton.Click += new System.EventHandler(this.DoneButton_Click);
            this.ReturnToMenuButton.MouseEnter += new System.EventHandler(this.ReturnToMenuButton_MouseEnter);
            this.ReturnToMenuButton.MouseLeave += new System.EventHandler(this.ReturnToMenuButton_MouseLeave);
            // 
            // WordListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartTestLabel);
            this.Controls.Add(this.WordGroupsComboBox);
            this.Controls.Add(this.StartTestButton);
            this.Controls.Add(this.ReturnToMenuButton);
            this.Controls.Add(this.WordListUpperLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WordListForm";
            this.Text = "Garik Translator";
            this.Activated += new System.EventHandler(this.WordListForm_Activated);
            this.Deactivate += new System.EventHandler(this.WordListForm_Deactivate);
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
        private System.Windows.Forms.ComboBox WordGroupsComboBox;
        private System.Windows.Forms.Label StartTestLabel;
    }
}