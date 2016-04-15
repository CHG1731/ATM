namespace Final_Apllication
{
    partial class Hoofdmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoofdmenu));
            this.pinButton = new System.Windows.Forms.Button();
            this.saldoButton = new System.Windows.Forms.Button();
            this.quickpinButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pinButton
            // 
            this.pinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinButton.Location = new System.Drawing.Point(635, 314);
            this.pinButton.Name = "pinButton";
            this.pinButton.Size = new System.Drawing.Size(389, 44);
            this.pinButton.TabIndex = 0;
            this.pinButton.Text = "A - Geld opnemen";
            this.pinButton.UseVisualStyleBackColor = false;
            // 
            // saldoButton
            // 
            this.saldoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saldoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoButton.Location = new System.Drawing.Point(635, 414);
            this.saldoButton.Name = "saldoButton";
            this.saldoButton.Size = new System.Drawing.Size(389, 44);
            this.saldoButton.TabIndex = 3;
            this.saldoButton.Text = "C - Snelkeuze";
            // 
            // quickpinButton
            // 
            this.quickpinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quickpinButton.BackColor = System.Drawing.Color.Red;
            this.quickpinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickpinButton.Location = new System.Drawing.Point(948, 624);
            this.quickpinButton.Name = "quickpinButton";
            this.quickpinButton.Size = new System.Drawing.Size(389, 44);
            this.quickpinButton.TabIndex = 2;
            this.quickpinButton.Text = "X - Afbreken";
            this.quickpinButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(635, 364);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(389, 44);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "B - Saldo informatie";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Hoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 706);
            this.Controls.Add(this.pinButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.quickpinButton);
            this.Controls.Add(this.saldoButton);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hoofdmenu";
            this.Text = "Pinscherm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pinButton;
        private System.Windows.Forms.Button saldoButton;
        private System.Windows.Forms.Button quickpinButton;
        private System.Windows.Forms.Button exitButton;
    }
}