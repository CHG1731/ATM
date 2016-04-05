namespace Final_Application
{
    partial class SaldoScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaldoScreen));
            this.inputDisplay = new System.Windows.Forms.TextBox();
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
            this.inputDisplay.Location = new System.Drawing.Point(707, 185);
            this.inputDisplay.Name = "inputDisplay";
            this.inputDisplay.Size = new System.Drawing.Size(100, 50);
            this.inputDisplay.TabIndex = 1;
            this.inputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaldoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1181, 609);
            this.Controls.Add(this.inputDisplay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaldoScreen";
            this.Text = "SaldoScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputDisplay;
    }
}