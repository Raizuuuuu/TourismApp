namespace Assign1
{
    partial class RegisterForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(25, 27);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 31);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(188, 379);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(136, 31);
            this.createAccountButton.TabIndex = 1;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.usernameBox.Location = new System.Drawing.Point(125, 120);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(267, 26);
            this.usernameBox.TabIndex = 2;
            this.usernameBox.Text = "Username";
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.passwordBox.Location = new System.Drawing.Point(125, 205);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(267, 26);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.Text = "Password";
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            this.passwordBox.Enter += new System.EventHandler(this.passwordBox_Enter);
            // 
            // emailBox
            // 
            this.emailBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.emailBox.Location = new System.Drawing.Point(125, 288);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(267, 26);
            this.emailBox.TabIndex = 4;
            this.emailBox.Text = "Email";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 445);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.backButton);
            this.Name = "RegisterForm";
            this.Text = "Register!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox emailBox;
    }
}