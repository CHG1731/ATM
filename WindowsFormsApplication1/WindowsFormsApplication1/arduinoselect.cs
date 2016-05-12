using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class arduinoselect : Form
    {
        public arduinoselect()
        {
            InitializeComponent();
        }

        private void arduinoselect_Load(object sender, EventArgs e)
        {
            findcom();
        }
        private void findcom()
        {
            hardwarebox.Items.Clear();
            String[] ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (String port in ports)
            {
                hardwarebox.Items.Add(port);
            }
            if (ports.Length < 1)
            {
                hardwarebox.Items.Add("No ports available");
            }
            else
            {
                hardwarebox.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            findcom();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SerialPort tmp = new SerialPort();
            tmp.BaudRate = 9600;
            tmp.PortName = hardwarebox.SelectedItem.ToString();
            tmp.Open();
            if (tmp.ReadLine().Contains("1234#"))
            {
                Boot.hardware = tmp;
                this.Close();
            }
            else
            {
                MessageBox.Show("Is dit gecertificeerde hardware", "Hardware fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tmp.Close();
        }
    }
}
