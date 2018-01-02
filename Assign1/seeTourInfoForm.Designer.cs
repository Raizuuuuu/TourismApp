namespace Assign1
{
    partial class seeTourInfoForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.tourPictureBox = new System.Windows.Forms.PictureBox();
            this.tourNameLabel = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tourPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(24, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(100, 32);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(24, 62);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 32);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(24, 114);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(100, 50);
            this.addToCartButton.TabIndex = 2;
            this.addToCartButton.Text = "Add to Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            // 
            // tourPictureBox
            // 
            this.tourPictureBox.Location = new System.Drawing.Point(210, 17);
            this.tourPictureBox.Name = "tourPictureBox";
            this.tourPictureBox.Size = new System.Drawing.Size(805, 128);
            this.tourPictureBox.TabIndex = 3;
            this.tourPictureBox.TabStop = false;
            // 
            // tourNameLabel
            // 
            this.tourNameLabel.AutoSize = true;
            this.tourNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tourNameLabel.Location = new System.Drawing.Point(205, 182);
            this.tourNameLabel.Name = "tourNameLabel";
            this.tourNameLabel.Size = new System.Drawing.Size(208, 29);
            this.tourNameLabel.TabIndex = 4;
            this.tourNameLabel.Text = "Tour Name Here";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(206, 248);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(58, 20);
            this.detailsLabel.TabIndex = 5;
            this.detailsLabel.Text = "Details";
            // 
            // seeTourInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 500);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.tourNameLabel);
            this.Controls.Add(this.tourPictureBox);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.homeButton);
            this.Name = "seeTourInfoForm";
            this.Text = "seeTourInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.tourPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.PictureBox tourPictureBox;
        private System.Windows.Forms.Label tourNameLabel;
        private System.Windows.Forms.Label detailsLabel;
    }
}