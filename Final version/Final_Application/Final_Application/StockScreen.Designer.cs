namespace Final_Apllication
{
    partial class StockScreen
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
            this.tensDisplay = new System.Windows.Forms.TextBox();
            this.twentiesDisplay = new System.Windows.Forms.TextBox();
            this.fiftiesDisplay = new System.Windows.Forms.TextBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tensDisplay
            // 
            this.tensDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tensDisplay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tensDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tensDisplay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tensDisplay.Location = new System.Drawing.Point(113, 263);
            this.tensDisplay.Name = "tensDisplay";
            this.tensDisplay.Size = new System.Drawing.Size(201, 50);
            this.tensDisplay.TabIndex = 1;
            this.tensDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // twentiesDisplay
            // 
            this.twentiesDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.twentiesDisplay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.twentiesDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twentiesDisplay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twentiesDisplay.Location = new System.Drawing.Point(409, 263);
            this.twentiesDisplay.Name = "twentiesDisplay";
            this.twentiesDisplay.Size = new System.Drawing.Size(201, 50);
            this.twentiesDisplay.TabIndex = 2;
            this.twentiesDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fiftiesDisplay
            // 
            this.fiftiesDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fiftiesDisplay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fiftiesDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fiftiesDisplay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiftiesDisplay.Location = new System.Drawing.Point(708, 263);
            this.fiftiesDisplay.Name = "fiftiesDisplay";
            this.fiftiesDisplay.Size = new System.Drawing.Size(201, 50);
            this.fiftiesDisplay.TabIndex = 3;
            this.fiftiesDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(453, 387);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(120, 27);
            this.AcceptButton.TabIndex = 14;
            this.AcceptButton.Text = "Invoeren";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // StockScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 604);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.fiftiesDisplay);
            this.Controls.Add(this.twentiesDisplay);
            this.Controls.Add(this.tensDisplay);
            this.Name = "StockScreen";
            this.Text = "StockScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputDisplay;
        private System.Windows.Forms.TextBox tensDisplay;
        private System.Windows.Forms.TextBox twentiesDisplay;
        private System.Windows.Forms.TextBox fiftiesDisplay;
        private System.Windows.Forms.Button AcceptButton;
    }
}