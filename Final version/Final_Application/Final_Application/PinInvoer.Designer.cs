﻿namespace Final_Apllication
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.rectifyButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.falsepininfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.inputDisplay.Location = new System.Drawing.Point(680, 240);
            this.inputDisplay.Name = "inputDisplay";
            this.inputDisplay.Size = new System.Drawing.Size(201, 50);
            this.inputDisplay.TabIndex = 0;
            this.inputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.BackColor = System.Drawing.Color.Yellow;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(680, 319);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(278, 44);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = " C - Corrigeren";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // rectifyButton
            // 
            this.rectifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rectifyButton.BackColor = System.Drawing.Color.Red;
            this.rectifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectifyButton.Location = new System.Drawing.Point(1070, 555);
            this.rectifyButton.Name = "rectifyButton";
            this.rectifyButton.Size = new System.Drawing.Size(278, 44);
            this.rectifyButton.TabIndex = 7;
            this.rectifyButton.Text = "X - Afbreken";
            this.rectifyButton.UseVisualStyleBackColor = false;
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.confirmButton.BackColor = System.Drawing.Color.DarkGreen;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(680, 369);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(278, 44);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "✔ - Bevestig";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(603, 487);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // falsepininfo
            // 
            this.falsepininfo.AutoSize = true;
            this.falsepininfo.BackColor = System.Drawing.Color.Transparent;
            this.falsepininfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.falsepininfo.ForeColor = System.Drawing.Color.Red;
            this.falsepininfo.Location = new System.Drawing.Point(907, 258);
            this.falsepininfo.Name = "falsepininfo";
            this.falsepininfo.Size = new System.Drawing.Size(140, 24);
            this.falsepininfo.TabIndex = 13;
            this.falsepininfo.Text = "FOUTIEVE PIN";
            this.falsepininfo.Visible = false;
            // 
            // PinInvoer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 636);
            this.Controls.Add(this.falsepininfo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.inputDisplay);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.rectifyButton);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PinInvoer";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputDisplay;
        private System.Windows.Forms.Button rectifyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        protected internal System.Windows.Forms.PictureBox pictureBox2;
        protected internal System.Windows.Forms.Label falsepininfo;
    }
}