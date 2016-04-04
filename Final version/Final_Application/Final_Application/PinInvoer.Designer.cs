namespace Final_Apllication
{
    partial class PinInvoer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinInvoer));
            this.inputDisplay = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.rectifyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputDisplay
            // 
            this.inputDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputDisplay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inputDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputDisplay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDisplay.Location = new System.Drawing.Point(780, 328);
            this.inputDisplay.Name = "inputDisplay";
            this.inputDisplay.Size = new System.Drawing.Size(333, 50);
            this.inputDisplay.TabIndex = 0;
            this.inputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.confirmButton.Location = new System.Drawing.Point(578, 558);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(389, 44);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "A - Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Location = new System.Drawing.Point(1090, 558);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(389, 44);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "C - Correct";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // rectifyButton
            // 
            this.rectifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rectifyButton.Location = new System.Drawing.Point(49, 558);
            this.rectifyButton.Name = "rectifyButton";
            this.rectifyButton.Size = new System.Drawing.Size(389, 44);
            this.rectifyButton.TabIndex = 7;
            this.rectifyButton.Text = "D - Cancel";
            this.rectifyButton.UseVisualStyleBackColor = true;
            // 
            // PinInvoer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1518, 636);
            this.Controls.Add(this.inputDisplay);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.rectifyButton);
            this.Controls.Add(this.confirmButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PinInvoer";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputDisplay;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button rectifyButton;
        private System.Windows.Forms.Button cancelButton;
    }
}