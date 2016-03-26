namespace Final_Application
{
    partial class Init1
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
            this.ARDCONNECT = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.COMPORTCHOOSE = new System.Windows.Forms.TextBox();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.KILLBUTTON = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ARDCONNECT
            // 
            this.ARDCONNECT.Location = new System.Drawing.Point(12, 39);
            this.ARDCONNECT.Name = "ARDCONNECT";
            this.ARDCONNECT.Size = new System.Drawing.Size(392, 23);
            this.ARDCONNECT.TabIndex = 0;
            this.ARDCONNECT.Text = "CONNECT ARDUINO";
            this.ARDCONNECT.UseVisualStyleBackColor = true;
            this.ARDCONNECT.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // COMPORTCHOOSE
            // 
            this.COMPORTCHOOSE.BackColor = System.Drawing.Color.Black;
            this.COMPORTCHOOSE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.COMPORTCHOOSE.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPORTCHOOSE.ForeColor = System.Drawing.Color.Yellow;
            this.COMPORTCHOOSE.Location = new System.Drawing.Point(281, 16);
            this.COMPORTCHOOSE.Name = "COMPORTCHOOSE";
            this.COMPORTCHOOSE.ReadOnly = true;
            this.COMPORTCHOOSE.Size = new System.Drawing.Size(122, 18);
            this.COMPORTCHOOSE.TabIndex = 2;
            this.COMPORTCHOOSE.Text = "Choose COM Port";
            this.COMPORTCHOOSE.TextChanged += new System.EventHandler(this.COMPORTCHOOSE_TextChanged);
            // 
            // StatusText
            // 
            this.StatusText.BackColor = System.Drawing.SystemColors.Desktop;
            this.StatusText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusText.Location = new System.Drawing.Point(12, 68);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(392, 13);
            this.StatusText.TabIndex = 3;
            this.StatusText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.White;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.Lime;
            this.StartButton.Location = new System.Drawing.Point(13, 179);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(391, 116);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "GO!";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Visible = false;
            this.StartButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // KILLBUTTON
            // 
            this.KILLBUTTON.BackColor = System.Drawing.Color.DarkRed;
            this.KILLBUTTON.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.KILLBUTTON.Location = new System.Drawing.Point(12, 139);
            this.KILLBUTTON.Name = "KILLBUTTON";
            this.KILLBUTTON.Size = new System.Drawing.Size(391, 34);
            this.KILLBUTTON.TabIndex = 6;
            this.KILLBUTTON.Text = "KILL PROGRAM";
            this.KILLBUTTON.UseVisualStyleBackColor = false;
            this.KILLBUTTON.Click += new System.EventHandler(this.KILLBUTTON_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(139, 14);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(137, 23);
            this.RefreshButton.TabIndex = 7;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(416, 307);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.KILLBUTTON);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.COMPORTCHOOSE);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ARDCONNECT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Start menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button ARDCONNECT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox COMPORTCHOOSE;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button KILLBUTTON;
        private System.Windows.Forms.Button RefreshButton;
    }
}