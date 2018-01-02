namespace Assign1
{
    partial class AccountSettingsForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.oldPasswordBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(202, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 131);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(18, 23);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(90, 44);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(196, 236);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(168, 26);
            this.emailBox.TabIndex = 2;
            this.emailBox.Text = "Enter new email...";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(196, 351);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(165, 26);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.Text = "Enter new password...";
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(196, 296);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(168, 26);
            this.usernameBox.TabIndex = 4;
            this.usernameBox.Text = "Enter new username...";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(48, 459);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(482, 40);
            this.noteLabel.TabIndex = 6;
            this.noteLabel.Text = "Note: All options are optional, but you must enter your old password\r\n if any of " +
    "the values changes";
            this.noteLabel.Click += new System.EventHandler(this.noteLabel_Click);
            // 
            // oldPasswordBox
            // 
            this.oldPasswordBox.Location = new System.Drawing.Point(196, 407);
            this.oldPasswordBox.Name = "oldPasswordBox";
            this.oldPasswordBox.Size = new System.Drawing.Size(168, 26);
            this.oldPasswordBox.TabIndex = 7;
            this.oldPasswordBox.Text = "Enter old password...";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(378, 406);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(89, 31);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // AccountSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 508);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.oldPasswordBox);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AccountSettingsForm";
            this.Text = "AccountSettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.TextBox oldPasswordBox;
        private System.Windows.Forms.Button updateButton;
    }
}