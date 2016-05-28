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
    public partial class ArduinoSelect : Form
    {
        public ArduinoSelect()
        {
            InitializeComponent();
        }

        private void ArduinoSelect_Load(object sender, EventArgs e)
        {
            fetchCom(Rfidbox);
            fetchCom(dispbox);
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
    }
}
