namespace GarikExamTranslator.Forms
{
    partial class SelectUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectUserForm));
            this.SelectUserLabel = new System.Windows.Forms.Label();
            this.SelectUserListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // SelectUserLabel
            // 
            this.SelectUserLabel.AutoSize = true;
            this.SelectUserLabel.BackColor = System.Drawing.Color.Transparent;
            this.SelectUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectUserLabel.ForeColor = System.Drawing.Color.White;
            this.SelectUserLabel.Location = new System.Drawing.Point(210, 9);
            this.SelectUserLabel.Name = "SelectUserLabel";
            this.SelectUserLabel.Size = new System.Drawing.Size(385, 42);
            this.SelectUserLabel.TabIndex = 3;
            this.SelectUserLabel.Text = "Выбор пользователя";
            // 
            // SelectUserListView
            // 
            this.SelectUserListView.BackColor = System.Drawing.Color.Orange;
            this.SelectUserListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectUserListView.HideSelection = false;
            this.SelectUserListView.LabelWrap = false;
            this.SelectUserListView.Location = new System.Drawing.Point(28, 73);
            this.SelectUserListView.Name = "SelectUserListView";
            this.SelectUserListView.Size = new System.Drawing.Size(741, 351);
            this.SelectUserListView.TabIndex = 4;
            this.SelectUserListView.UseCompatibleStateImageBehavior = false;
            // 
            // SelectUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GarikExamTranslator.Properties.Resources.Orange_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectUserListView);
            this.Controls.Add(this.SelectUserLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectUserForm";
            this.Text = "Garik Translator";
            this.Load += new System.EventHandler(this.SelectUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectUserLabel;
        private System.Windows.Forms.ListView SelectUserListView;
    }
}