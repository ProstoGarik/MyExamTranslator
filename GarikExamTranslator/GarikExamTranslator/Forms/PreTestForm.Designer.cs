namespace GarikExamTranslator.Forms
{
    partial class PreTestForm
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
            this.WordsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.AddEditLabel = new System.Windows.Forms.Label();
            this.SelectAllCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ReturnToMenuButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WordsCheckedListBox
            // 
            this.WordsCheckedListBox.BackColor = System.Drawing.Color.Orange;
            this.WordsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WordsCheckedListBox.CheckOnClick = true;
            this.WordsCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordsCheckedListBox.ForeColor = System.Drawing.Color.White;
            this.WordsCheckedListBox.FormattingEnabled = true;
            this.WordsCheckedListBox.Location = new System.Drawing.Point(33, 108);
            this.WordsCheckedListBox.Name = "WordsCheckedListBox";
            this.WordsCheckedListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WordsCheckedListBox.Size = new System.Drawing.Size(739, 242);
            this.WordsCheckedListBox.TabIndex = 0;
            this.WordsCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.WordsCheckedListBox_ItemCheck);
            // 
            // AddEditLabel
            // 
            this.AddEditLabel.AutoSize = true;
            this.AddEditLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddEditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEditLabel.ForeColor = System.Drawing.Color.White;
            this.AddEditLabel.Location = new System.Drawing.Point(212, 9);
            this.AddEditLabel.Name = "AddEditLabel";
            this.AddEditLabel.Size = new System.Drawing.Size(391, 33);
            this.AddEditLabel.TabIndex = 1;
            this.AddEditLabel.Text = "Выберите группы для теста";
            // 
            // SelectAllCheckedListBox
            // 
            this.SelectAllCheckedListBox.BackColor = System.Drawing.Color.Orange;
            this.SelectAllCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectAllCheckedListBox.CheckOnClick = true;
            this.SelectAllCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectAllCheckedListBox.ForeColor = System.Drawing.Color.White;
            this.SelectAllCheckedListBox.FormattingEnabled = true;
            this.SelectAllCheckedListBox.Location = new System.Drawing.Point(33, 56);
            this.SelectAllCheckedListBox.Name = "SelectAllCheckedListBox";
            this.SelectAllCheckedListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectAllCheckedListBox.Size = new System.Drawing.Size(739, 32);
            this.SelectAllCheckedListBox.TabIndex = 2;
            this.SelectAllCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.SelectAllCheckedListBox_ItemCheck);
            // 
            // ReturnToMenuButton
            // 
            this.ReturnToMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.ReturnToMenuButton.BackgroundImage = global::GarikExamTranslator.Properties.Resources.GoBack_Icon;
            this.ReturnToMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturnToMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnToMenuButton.FlatAppearance.BorderSize = 0;
            this.ReturnToMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ReturnToMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ReturnToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnToMenuButton.Location = new System.Drawing.Point(634, 356);
            this.ReturnToMenuButton.Name = "ReturnToMenuButton";
            this.ReturnToMenuButton.Size = new System.Drawing.Size(138, 92);
            this.ReturnToMenuButton.TabIndex = 18;
            this.ReturnToMenuButton.UseVisualStyleBackColor = false;
            this.ReturnToMenuButton.Click += new System.EventHandler(this.ReturnToMenuButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.Transparent;
            this.DoneButton.BackgroundImage = global::GarikExamTranslator.Properties.Resources.Done_Icon;
            this.DoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoneButton.FlatAppearance.BorderSize = 0;
            this.DoneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DoneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoneButton.Location = new System.Drawing.Point(33, 356);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(96, 92);
            this.DoneButton.TabIndex = 19;
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // PreTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GarikExamTranslator.Properties.Resources.Orange_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.ReturnToMenuButton);
            this.Controls.Add(this.SelectAllCheckedListBox);
            this.Controls.Add(this.AddEditLabel);
            this.Controls.Add(this.WordsCheckedListBox);
            this.Name = "PreTestForm";
            this.Text = "PreTestForm";
            this.Load += new System.EventHandler(this.PreTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox WordsCheckedListBox;
        private System.Windows.Forms.Label AddEditLabel;
        private System.Windows.Forms.CheckedListBox SelectAllCheckedListBox;
        private System.Windows.Forms.Button ReturnToMenuButton;
        private System.Windows.Forms.Button DoneButton;
    }
}