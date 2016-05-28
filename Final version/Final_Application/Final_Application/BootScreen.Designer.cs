namespace Final_Application
{
    partial class BootScreen
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
            this.StartButton = new System.Windows.Forms.Button();
            this.KILLBUTTON = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ARDCONNECT
            // 
            this.ARDCONNECT.Location = new System.Drawing.Point(11, 110);
            this.ARDCONNECT.Name = "ARDCONNECT";
            this.ARDCONNECT.Size = new System.Drawing.Size(392, 23);
            this.ARDCONNECT.TabIndex = 0;
            this.ARDCONNECT.Text = "CONNECT ARDUINO";
            this.ARDCONNECT.UseVisualStyleBackColor = true;
            this.ARDCONNECT.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 54);
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
            this.COMPORTCHOOSE.Location = new System.Drawing.Point(281, 81);
            this.COMPORTCHOOSE.Name = "COMPORTCHOOSE";
            this.COMPORTCHOOSE.ReadOnly = true;
            this.COMPORTCHOOSE.Size = new System.Drawing.Size(122, 18);
            this.COMPORTCHOOSE.TabIndex = 2;
            this.COMPORTCHOOSE.Text = "Choose COM Port";
            this.COMPORTCHOOSE.TextChanged += new System.EventHandler(this.COMPORTCHOOSE_TextChanged);
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
            this.RefreshButton.Location = new System.Drawing.Point(281, 52);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(122, 23);
            this.RefreshButton.TabIndex = 7;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(154, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(94, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dispenser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(94, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "KeyPad";
            // 
            // BootScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(416, 307);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.KILLBUTTON);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.COMPORTCHOOSE);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ARDCONNECT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BootScreen";
            this.Text = "Start menu";
            this.Load += new System.EventHandler(this.BootScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ARDCONNECT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox COMPORTCHOOSE;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button KILLBUTTON;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

