namespace Final_Apllication
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
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitButton.Location = new System.Drawing.Point(123, 392);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(389, 44);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "A - JA";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(576, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(389, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "B - Nee";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaldoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1181, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitButton);
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
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button1;
    }
}