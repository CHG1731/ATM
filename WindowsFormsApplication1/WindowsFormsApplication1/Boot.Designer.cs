namespace WindowsFormsApplication1
{
    partial class Boot
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
            this.Firstnamebox = new System.Windows.Forms.TextBox();
            this.Lastnamebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.usercbbox = new System.Windows.Forms.ComboBox();
            this.clientdeselect = new System.Windows.Forms.Button();
            this.clientselect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.infvoornaam = new System.Windows.Forms.Label();
            this.infachternaam = new System.Windows.Forms.Label();
            this.voornaamfill = new System.Windows.Forms.Label();
            this.achternaamfill = new System.Windows.Forms.Label();
            this.connected = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Firstnamebox
            // 
            this.Firstnamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstnamebox.Location = new System.Drawing.Point(12, 30);
            this.Firstnamebox.Name = "Firstnamebox";
            this.Firstnamebox.Size = new System.Drawing.Size(149, 20);
            this.Firstnamebox.TabIndex = 0;
            this.Firstnamebox.Text = "First name";
            this.Firstnamebox.Enter += new System.EventHandler(this.Firstnamebox_Enter);
            // 
            // Lastnamebox
            // 
            this.Lastnamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastnamebox.Location = new System.Drawing.Point(167, 30);
            this.Lastnamebox.Name = "Lastnamebox";
            this.Lastnamebox.Size = new System.Drawing.Size(140, 20);
            this.Lastnamebox.TabIndex = 1;
            this.Lastnamebox.Text = "Last name";
            this.Lastnamebox.TextChanged += new System.EventHandler(this.Lastnamebox_TextChanged);
            this.Lastnamebox.Enter += new System.EventHandler(this.Lastnamebox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter first and last name. Click search to continue\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search Person";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usercbbox
            // 
            this.usercbbox.BackColor = System.Drawing.SystemColors.Window;
            this.usercbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usercbbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.usercbbox.FormattingEnabled = true;
            this.usercbbox.Location = new System.Drawing.Point(12, 95);
            this.usercbbox.Name = "usercbbox";
            this.usercbbox.Size = new System.Drawing.Size(295, 21);
            this.usercbbox.TabIndex = 4;
            // 
            // clientdeselect
            // 
            this.clientdeselect.BackColor = System.Drawing.Color.Red;
            this.clientdeselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientdeselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientdeselect.Location = new System.Drawing.Point(415, 6);
            this.clientdeselect.Name = "clientdeselect";
            this.clientdeselect.Size = new System.Drawing.Size(96, 110);
            this.clientdeselect.TabIndex = 6;
            this.clientdeselect.Text = "Deselecteer client";
            this.clientdeselect.UseVisualStyleBackColor = false;
            this.clientdeselect.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // clientselect
            // 
            this.clientselect.BackColor = System.Drawing.Color.Lime;
            this.clientselect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clientselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clientselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientselect.Location = new System.Drawing.Point(313, 6);
            this.clientselect.Name = "clientselect";
            this.clientselect.Size = new System.Drawing.Size(96, 110);
            this.clientselect.TabIndex = 7;
            this.clientselect.Text = "Selecteer client";
            this.clientselect.UseVisualStyleBackColor = false;
            this.clientselect.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "Klant informatie";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // infvoornaam
            // 
            this.infvoornaam.AutoSize = true;
            this.infvoornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infvoornaam.Location = new System.Drawing.Point(517, 61);
            this.infvoornaam.Name = "infvoornaam";
            this.infvoornaam.Size = new System.Drawing.Size(71, 16);
            this.infvoornaam.TabIndex = 9;
            this.infvoornaam.Text = "Voornaam";
            // 
            // infachternaam
            // 
            this.infachternaam.AutoSize = true;
            this.infachternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infachternaam.Location = new System.Drawing.Point(594, 61);
            this.infachternaam.Name = "infachternaam";
            this.infachternaam.Size = new System.Drawing.Size(80, 16);
            this.infachternaam.TabIndex = 10;
            this.infachternaam.Text = "Achternaam";
            // 
            // voornaamfill
            // 
            this.voornaamfill.AutoSize = true;
            this.voornaamfill.Location = new System.Drawing.Point(517, 77);
            this.voornaamfill.Name = "voornaamfill";
            this.voornaamfill.Size = new System.Drawing.Size(0, 13);
            this.voornaamfill.TabIndex = 11;
            // 
            // achternaamfill
            // 
            this.achternaamfill.AutoSize = true;
            this.achternaamfill.Location = new System.Drawing.Point(594, 77);
            this.achternaamfill.Name = "achternaamfill";
            this.achternaamfill.Size = new System.Drawing.Size(0, 13);
            this.achternaamfill.TabIndex = 12;
            // 
            // connected
            // 
            this.connected.AutoSize = true;
            this.connected.Location = new System.Drawing.Point(632, 6);
            this.connected.Name = "connected";
            this.connected.Size = new System.Drawing.Size(0, 13);
            this.connected.TabIndex = 13;
            this.connected.Click += new System.EventHandler(this.label3_Click_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Database connection: ";
            // 
            // Boot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1393, 584);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.connected);
            this.Controls.Add(this.achternaamfill);
            this.Controls.Add(this.voornaamfill);
            this.Controls.Add(this.infachternaam);
            this.Controls.Add(this.infvoornaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientselect);
            this.Controls.Add(this.clientdeselect);
            this.Controls.Add(this.usercbbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lastnamebox);
            this.Controls.Add(this.Firstnamebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Boot";
            this.Text = "Banking management Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Boot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Firstnamebox;
        private System.Windows.Forms.TextBox Lastnamebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox usercbbox;
        private System.Windows.Forms.Button clientdeselect;
        private System.Windows.Forms.Button clientselect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label infvoornaam;
        private System.Windows.Forms.Label infachternaam;
        private System.Windows.Forms.Label voornaamfill;
        private System.Windows.Forms.Label achternaamfill;
        private System.Windows.Forms.Label connected;
        private System.Windows.Forms.Label label4;
    }
}

