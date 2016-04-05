namespace Final_Apllication
{
    partial class Pinscherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pinscherm));
            this.pinButton = new System.Windows.Forms.Button();
            this.saldoButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pinButton
            // 
            this.pinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pinButton.Location = new System.Drawing.Point(823, 154);
            this.pinButton.Name = "pinButton";
            this.pinButton.Size = new System.Drawing.Size(389, 44);
            this.pinButton.TabIndex = 0;
            this.pinButton.Text = "A - 10 Euro";
            this.pinButton.UseVisualStyleBackColor = false;
            // 
            // saldoButton
            // 
            this.saldoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saldoButton.Location = new System.Drawing.Point(823, 254);
            this.saldoButton.Name = "saldoButton";
            this.saldoButton.Size = new System.Drawing.Size(389, 44);
            this.saldoButton.TabIndex = 3;
            this.saldoButton.Text = "C - 50 Euro";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitButton.Location = new System.Drawing.Point(823, 204);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(389, 44);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "B - 20 Euro";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(823, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(389, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "# - Anders";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(537, 617);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(389, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "* - Afbreken";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(943, 617);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(389, 44);
            this.button3.TabIndex = 6;
            this.button3.Text = "C - Terug";
            // 
            // Pinscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pinButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saldoButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pinscherm";
            this.Text = "Pinscherm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pinButton;
        private System.Windows.Forms.Button saldoButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}