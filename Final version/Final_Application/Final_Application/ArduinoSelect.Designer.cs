namespace Final_Application
{
    partial class ArduinoSelect
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rfidbox = new System.Windows.Forms.ComboBox();
            this.dispbox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KeyPad + RFID Com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dispenser Com";
            // 
            // Rfidbox
            // 
            this.Rfidbox.FormattingEnabled = true;
            this.Rfidbox.Location = new System.Drawing.Point(123, 1);
            this.Rfidbox.Name = "Rfidbox";
            this.Rfidbox.Size = new System.Drawing.Size(121, 21);
            this.Rfidbox.TabIndex = 2;
            // 
            // dispbox
            // 
            this.dispbox.FormattingEnabled = true;
            this.dispbox.Location = new System.Drawing.Point(123, 25);
            this.dispbox.Name = "dispbox";
            this.dispbox.Size = new System.Drawing.Size(121, 21);
            this.dispbox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ArduinoSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 105);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dispbox);
            this.Controls.Add(this.Rfidbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ArduinoSelect";
            this.Text = "ArduinoSelect";
            this.Load += new System.EventHandler(this.ArduinoSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Rfidbox;
        private System.Windows.Forms.ComboBox dispbox;
        private System.Windows.Forms.Button button1;
    }
}