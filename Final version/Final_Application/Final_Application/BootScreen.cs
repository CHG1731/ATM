using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Application
{
    public partial class BootScreen : Form
    {
        public BootScreen()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            fetchCom();
            //StartButton.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ArduinoClass.makePort(comboBox1.SelectedItem.ToString()) == true)
                {
                    StatusText.ForeColor = Color.Green;
                    StatusText.Text = "ARDUINO CONNECTED";
                    StartButton.Visible = true;
                }
                else
                {
                    StatusText.ForeColor = Color.Red;
                    StatusText.Text = "NO CONNECTION";
                }
            }
            catch (Exception)
            {
                Error.show("No port selected", "Error");
            }
        }
        public class Error
        {
            public static void show(String s, String x)
            {
                MessageBox.Show(s, x,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void COMPORTCHOOSE_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void fetchCom()
        {
            String[] ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (String port in ports)
            {
                comboBox1.Items.Add(port);
            }
            if (ports.Length < 1)
            {
                comboBox1.Items.Add("No ports available");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void KILLBUTTON_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Start s = new Start();
            s.run();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            fetchCom();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            HTTPpost test = new HTTPpost();
            test.UpdateBalans(1,999);
        }
    }

}
