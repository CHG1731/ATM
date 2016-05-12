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
            this.infvoornaam = new System.Windows.Forms.Label();
            this.infachternaam = new System.Windows.Forms.Label();
            this.voornaamfill = new System.Windows.Forms.Label();
            this.achternaamfill = new System.Windows.Forms.Label();
            this.connected = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KlantIDfill = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filladres = new System.Windows.Forms.Label();
            this.postcodefill = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Rekeningenbox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Firstnamebox
            // 
            this.Firstnamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstnamebox.Location = new System.Drawing.Point(16, 37);
            this.Firstnamebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Firstnamebox.Name = "Firstnamebox";
            this.Firstnamebox.Size = new System.Drawing.Size(197, 20);
            this.Firstnamebox.TabIndex = 0;
            this.Firstnamebox.Text = "First name";
            this.Firstnamebox.Enter += new System.EventHandler(this.Firstnamebox_Enter);
            // 
            // Lastnamebox
            // 
            this.Lastnamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastnamebox.Location = new System.Drawing.Point(223, 37);
            this.Lastnamebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Lastnamebox.Name = "Lastnamebox";
            this.Lastnamebox.Size = new System.Drawing.Size(185, 20);
            this.Lastnamebox.TabIndex = 1;
            this.Lastnamebox.Text = "Last name";
            this.Lastnamebox.TextChanged += new System.EventHandler(this.Lastnamebox_TextChanged);
            this.Lastnamebox.Enter += new System.EventHandler(this.Lastnamebox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter first and last name. Click search to continue\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(393, 28);
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
            this.usercbbox.Location = new System.Drawing.Point(16, 117);
            this.usercbbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usercbbox.Name = "usercbbox";
            this.usercbbox.Size = new System.Drawing.Size(392, 24);
            this.usercbbox.TabIndex = 4;
            // 
            // clientdeselect
            // 
            this.clientdeselect.BackColor = System.Drawing.Color.Red;
            this.clientdeselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientdeselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientdeselect.Location = new System.Drawing.Point(553, 7);
            this.clientdeselect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientdeselect.Name = "clientdeselect";
            this.clientdeselect.Size = new System.Drawing.Size(128, 135);
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
            this.clientselect.Location = new System.Drawing.Point(417, 7);
            this.clientselect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientselect.Name = "clientselect";
            this.clientselect.Size = new System.Drawing.Size(128, 135);
            this.clientselect.TabIndex = 7;
            this.clientselect.Text = "Selecteer client";
            this.clientselect.UseVisualStyleBackColor = false;
            this.clientselect.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(684, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "Klant informatie";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // infvoornaam
            // 
            this.infvoornaam.AutoSize = true;
            this.infvoornaam.BackColor = System.Drawing.Color.Silver;
            this.infvoornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infvoornaam.Location = new System.Drawing.Point(689, 75);
            this.infvoornaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infvoornaam.Name = "infvoornaam";
            this.infvoornaam.Size = new System.Drawing.Size(71, 16);
            this.infvoornaam.TabIndex = 9;
            this.infvoornaam.Text = "Voornaam";
            // 
            // infachternaam
            // 
            this.infachternaam.AutoSize = true;
            this.infachternaam.BackColor = System.Drawing.Color.Silver;
            this.infachternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infachternaam.Location = new System.Drawing.Point(792, 75);
            this.infachternaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infachternaam.Name = "infachternaam";
            this.infachternaam.Size = new System.Drawing.Size(80, 16);
            this.infachternaam.TabIndex = 10;
            this.infachternaam.Text = "Achternaam";
            // 
            // voornaamfill
            // 
            this.voornaamfill.AutoSize = true;
            this.voornaamfill.BackColor = System.Drawing.Color.Gainsboro;
            this.voornaamfill.Location = new System.Drawing.Point(689, 95);
            this.voornaamfill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.voornaamfill.Name = "voornaamfill";
            this.voornaamfill.Size = new System.Drawing.Size(0, 16);
            this.voornaamfill.TabIndex = 11;
            // 
            // achternaamfill
            // 
            this.achternaamfill.AutoSize = true;
            this.achternaamfill.BackColor = System.Drawing.Color.Gainsboro;
            this.achternaamfill.Location = new System.Drawing.Point(792, 95);
            this.achternaamfill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.achternaamfill.Name = "achternaamfill";
            this.achternaamfill.Size = new System.Drawing.Size(0, 16);
            this.achternaamfill.TabIndex = 12;
            // 
            // connected
            // 
            this.connected.AutoSize = true;
            this.connected.Location = new System.Drawing.Point(843, 7);
            this.connected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connected.Name = "connected";
            this.connected.Size = new System.Drawing.Size(0, 16);
            this.connected.TabIndex = 13;
            this.connected.Click += new System.EventHandler(this.label3_Click_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Database connection: ";
            // 
            // KlantIDfill
            // 
            this.KlantIDfill.AutoSize = true;
            this.KlantIDfill.BackColor = System.Drawing.Color.Gainsboro;
            this.KlantIDfill.Location = new System.Drawing.Point(907, 95);
            this.KlantIDfill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KlantIDfill.Name = "KlantIDfill";
            this.KlantIDfill.Size = new System.Drawing.Size(0, 16);
            this.KlantIDfill.TabIndex = 16;
            this.KlantIDfill.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(907, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "KlantID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(689, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Straat + Adres";
            // 
            // filladres
            // 
            this.filladres.AutoSize = true;
            this.filladres.BackColor = System.Drawing.Color.Gainsboro;
            this.filladres.Location = new System.Drawing.Point(691, 147);
            this.filladres.Name = "filladres";
            this.filladres.Size = new System.Drawing.Size(0, 16);
            this.filladres.TabIndex = 18;
            // 
            // postcodefill
            // 
            this.postcodefill.AutoSize = true;
            this.postcodefill.BackColor = System.Drawing.Color.Gainsboro;
            this.postcodefill.Location = new System.Drawing.Point(893, 147);
            this.postcodefill.Name = "postcodefill";
            this.postcodefill.Size = new System.Drawing.Size(0, 16);
            this.postcodefill.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(891, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Postcode";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Location = new System.Drawing.Point(686, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 105);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 42);
            this.label6.TabIndex = 22;
            this.label6.Text = "Rekeningen";
            // 
            // Rekeningenbox
            // 
            this.Rekeningenbox.BackColor = System.Drawing.SystemColors.Window;
            this.Rekeningenbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rekeningenbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Rekeningenbox.FormattingEnabled = true;
            this.Rekeningenbox.Location = new System.Drawing.Point(13, 243);
            this.Rekeningenbox.Margin = new System.Windows.Forms.Padding(4);
            this.Rekeningenbox.Name = "Rekeningenbox";
            this.Rekeningenbox.Size = new System.Drawing.Size(392, 24);
            this.Rekeningenbox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(561, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "label8";
            // 
            // Boot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1366, 719);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Rekeningenbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.postcodefill);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.filladres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KlantIDfill);
            this.Controls.Add(this.label5);
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
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Boot";
            this.Text = "Banking management Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Boot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label infvoornaam;
        private System.Windows.Forms.Label infachternaam;
        private System.Windows.Forms.Label voornaamfill;
        private System.Windows.Forms.Label achternaamfill;
        private System.Windows.Forms.Label connected;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label KlantIDfill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label filladres;
        private System.Windows.Forms.Label postcodefill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Rekeningenbox;
        private System.Windows.Forms.Label label8;
    }
}

