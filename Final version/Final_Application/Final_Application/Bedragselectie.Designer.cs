namespace Final_Apllication
{
    partial class Bedragselectie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bedragselectie));
            this.inputDisplay = new System.Windows.Forms.TextBox();
            this.nope = new System.Windows.Forms.Label();
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
            this.inputDisplay.Location = new System.Drawing.Point(592, 235);
            this.inputDisplay.Name = "inputDisplay";
            this.inputDisplay.Size = new System.Drawing.Size(214, 50);
            this.inputDisplay.TabIndex = 1;
            this.inputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nope
            // 
            this.nope.AutoSize = true;
            this.nope.BackColor = System.Drawing.Color.Transparent;
            this.nope.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nope.ForeColor = System.Drawing.Color.Red;
            this.nope.Location = new System.Drawing.Point(512, 373);
            this.nope.Name = "nope";
            this.nope.Size = new System.Drawing.Size(523, 24);
            this.nope.TabIndex = 14;
            this.nope.Text = "Bedrag kan niet gepint worden. Voer een veelvoed van 10 in.";
            this.nope.Visible = false;
            this.nope.Click += new System.EventHandler(this.falsepininfo_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.confirmButton.BackColor = System.Drawing.Color.DarkGreen;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(474, 413);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(278, 44);
            this.confirmButton.TabIndex = 15;
            this.confirmButton.Text = "✔ - Bevestig";
            this.confirmButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.BackColor = System.Drawing.Color.Yellow;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(784, 413);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(278, 44);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = " C - Terug";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // rectifyButton
            // 
            this.rectifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rectifyButton.BackColor = System.Drawing.Color.Red;
            this.rectifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectifyButton.Location = new System.Drawing.Point(902, 539);
            this.rectifyButton.Name = "rectifyButton";
            this.rectifyButton.Size = new System.Drawing.Size(278, 44);
            this.rectifyButton.TabIndex = 17;
            this.rectifyButton.Text = "X - Afbreken";
            this.rectifyButton.UseVisualStyleBackColor = false;
            // 
            // Bedragselectie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 628);
            this.Controls.Add(this.rectifyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.nope);
            this.Controls.Add(this.inputDisplay);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bedragselectie";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputDisplay;
        protected internal System.Windows.Forms.Label nope;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button rectifyButton;
    }
}