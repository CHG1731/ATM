using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ATM
{
    public partial class Start : Form
    {
        public Start()
        {
            Cursor.Hide();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            SerialPort startPort = Arduino.getPort();
            String s = startPort.ReadTo("\r\n");
            if (startPort.ReadTo("\r\n") == "NEW")
            {
                DebugText.Text = "CARD FOUND";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
