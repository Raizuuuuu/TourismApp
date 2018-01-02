namespace Assign1
{
    partial class PersonalizeForm
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
            this.homeButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.fontSizeLabel = new System.Windows.Forms.Label();
            this.fontLabel = new System.Windows.Forms.Label();
            this.fontBox = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(12, 22);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(102, 36);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 260);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 26);
            this.textBox2.TabIndex = 2;
            // 
            // fontSizeLabel
            // 
            this.fontSizeLabel.AutoSize = true;
            this.fontSizeLabel.Location = new System.Drawing.Point(141, 224);
            this.fontSizeLabel.Name = "fontSizeLabel";
            this.fontSizeLabel.Size = new System.Drawing.Size(77, 20);
            this.fontSizeLabel.TabIndex = 3;
            this.fontSizeLabel.Text = "Font Size";
            // 
            // fontLabel
            // 
            this.fontLabel.AutoSize = true;
            this.fontLabel.Location = new System.Drawing.Point(141, 98);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(42, 20);
            this.fontLabel.TabIndex = 4;
            this.fontLabel.Text = "Font";
            // 
            // fontBox
            // 
            this.fontBox.FormattingEnabled = true;
            this.fontBox.Items.AddRange(new object[] {
            "Microsoft Sans Serif",
            "Ariel"});
            this.fontBox.Location = new System.Drawing.Point(145, 146);
            this.fontBox.Name = "fontBox";
            this.fontBox.Size = new System.Drawing.Size(166, 28);
            this.fontBox.TabIndex = 5;
            this.fontBox.Text = "Microsoft Sans Serif";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(352, 330);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(102, 36);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // PersonalizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 388);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.fontBox);
            this.Controls.Add(this.fontLabel);
            this.Controls.Add(this.fontSizeLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.homeButton);
            this.Name = "PersonalizeForm";
            this.Text = "PersonalizeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label fontSizeLabel;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.ComboBox fontBox;
        private System.Windows.Forms.Button updateButton;
    }
}