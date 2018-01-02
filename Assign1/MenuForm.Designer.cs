namespace Assign1
{
    partial class MenuForm
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.findToursButton = new System.Windows.Forms.Button();
            this.manageToursButton = new System.Windows.Forms.Button();
            this.accountSettingsButton = new System.Windows.Forms.Button();
            this.personalizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(465, 406);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(114, 44);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(21, 35);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(67, 36);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // findToursButton
            // 
            this.findToursButton.Location = new System.Drawing.Point(158, 115);
            this.findToursButton.Name = "findToursButton";
            this.findToursButton.Size = new System.Drawing.Size(295, 44);
            this.findToursButton.TabIndex = 2;
            this.findToursButton.Text = "Find Tours";
            this.findToursButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findToursButton.UseVisualStyleBackColor = true;
            // 
            // manageToursButton
            // 
            this.manageToursButton.Location = new System.Drawing.Point(158, 181);
            this.manageToursButton.Name = "manageToursButton";
            this.manageToursButton.Size = new System.Drawing.Size(295, 44);
            this.manageToursButton.TabIndex = 3;
            this.manageToursButton.Text = "Manage Tours";
            this.manageToursButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageToursButton.UseVisualStyleBackColor = true;
            // 
            // accountSettingsButton
            // 
            this.accountSettingsButton.Location = new System.Drawing.Point(158, 252);
            this.accountSettingsButton.Name = "accountSettingsButton";
            this.accountSettingsButton.Size = new System.Drawing.Size(295, 44);
            this.accountSettingsButton.TabIndex = 4;
            this.accountSettingsButton.Text = "Account Settings";
            this.accountSettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountSettingsButton.UseVisualStyleBackColor = true;
            // 
            // personalizeButton
            // 
            this.personalizeButton.Location = new System.Drawing.Point(158, 323);
            this.personalizeButton.Name = "personalizeButton";
            this.personalizeButton.Size = new System.Drawing.Size(295, 44);
            this.personalizeButton.TabIndex = 5;
            this.personalizeButton.Text = "Personalize";
            this.personalizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personalizeButton.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 462);
            this.Controls.Add(this.personalizeButton);
            this.Controls.Add(this.accountSettingsButton);
            this.Controls.Add(this.manageToursButton);
            this.Controls.Add(this.findToursButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logoutButton);
            this.Name = "MenuForm";
            this.Text = "Home Page!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button findToursButton;
        private System.Windows.Forms.Button manageToursButton;
        private System.Windows.Forms.Button accountSettingsButton;
        private System.Windows.Forms.Button personalizeButton;
    }
}