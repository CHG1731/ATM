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

namespace Final_Application
{
    public partial class Init1 : Form
    {
        public Init1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            fetchCom();
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
            while (true)
            {
                HTTP testhttp = new HTTP();
                SerialPort testard = ArduinoClass.getPort();
                String RawUID = testard.ReadTo(",NEWUID");
                //String UID = string.Concat("/api/pass/" + RawUID);
                String KlantID = testhttp.getKlantID(RawUID);
                String UID = String.Concat("/api/klants/", KlantID);
                Klant tmpklant = testhttp.getKlant(UID);
                String klantdata = string.Concat("Voornaam: ", tmpklant.Naam, " Achternaam: ", tmpklant.Achternaam, " Adres: ",tmpklant.Adres, " Postcode: ",tmpklant.Postcode);
                Error.show(klantdata,"KLANT DATA");
                break;
            }
            //Error.show("NEXT FRAME PLOX", "NEXT FRAME ERROR");
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            fetchCom();
        }
    }
}
