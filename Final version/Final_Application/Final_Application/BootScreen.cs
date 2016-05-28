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
        String com1;
        String com2;
        public BootScreen()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            fetchCom(comboBox1);
            fetchCom(comboBox2);
            StartButton.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
        private void fetchCom(ComboBox cbbox)
        {
            String[] ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (String port in ports)
            {
                cbbox.Items.Add(port);
            }
            if (ports.Length < 1)
            {
                cbbox.Items.Add("No ports available");
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
            com1 = comboBox1.SelectedText;
            com2 = comboBox2.SelectedText;
            Start s = new Start();
            s.run();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox1.Items.Clear();
            fetchCom(comboBox1);
            fetchCom(comboBox2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
           // Printer print = new Printer("Koekje", 0.6);
           // print.printTicket();
        }

        private void BootScreen_Load(object sender, EventArgs e)
        {

        }

        public String getcom1()
        {
            return com1;
        }
        public String getcom2()
        {
            return com2;
        }
    }
}