﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class Boot : Form
    {
        public static string wachtwoordtekst;
        public static string gebruikertekst;
        private string connectionString;
        //private string connectionString = "server=145.24.222.163;Port=8500;UserId=dev;Password=dev!123;database=OP3;CharSet=utf8;Persist Security Info=True;";
        private static MySqlConnection connection;
        public Boot()
        {
            InitializeComponent();
        }

        private void Boot_Load(object sender, EventArgs e)
        {
            Enabled = false;
            Credentialform cred = new Credentialform();
            cred.ShowDialog();
            Enabled = true;
            connectionString = "server=145.24.222.163;Port=8500;UserId=" + gebruikertekst + ";Password=" + wachtwoordtekst + ";database=OP3;CharSet=utf8;Persist Security Info=True;";
            makeConnection();
            checkconnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usercbbox.Items.Clear();
            string command = "SELECT * FROM OP3.Klant where Naam ='" + Firstnamebox.Text + "' AND Achternaam ='" + Lastnamebox.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(command, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                string rowz = string.Format("{0} : {1} : {2}", row.ItemArray[0], row.ItemArray[3], row.ItemArray[4]);
                usercbbox.Items.Add(rowz);
            }
            if (usercbbox.Items.Count > 0)
            {
                usercbbox.SelectedIndex = 0;
            }
        }
        private void makeConnection()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Firstnamebox_Enter(object sender, EventArgs e)
        {
            Firstnamebox.Clear();
        }

        private void Lastnamebox_Enter(object sender, EventArgs e)
        {
            Lastnamebox.Clear();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Rekeningenbox.Items.Clear();
            Lastnamebox.Enabled = true;
            Firstnamebox.Enabled = true;
            usercbbox.Enabled = true;
            button1.Enabled = true;
            Firstnamebox.Text = "First name";
            Lastnamebox.Text = "Last name";
            usercbbox.Items.Clear();
            usercbbox.Refresh();
            filladres.ResetText();
            voornaamfill.ResetText();
            achternaamfill.ResetText();
            postcodefill.ResetText();
            KlantIDfill.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usercbbox.Text))
            {
                Lastnamebox.Enabled = false;
                Firstnamebox.Enabled = false;
                usercbbox.Enabled = false;
                button1.Enabled = false;
                Fillklantinformatie(usercbbox.SelectedItem.ToString().Substring(0,4));
            }
            else
            {
                MessageBox.Show("Selecteer een geldige klant", "Fout met klant informatie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Fillklantinformatie(String KlantID)
        {
            string command = "SELECT * FROM OP3.Klant where KlantID = '" + KlantID + "'";
            MySqlDataAdapter retr = new MySqlDataAdapter(command, connection);
            DataTable klantdt = new DataTable();
            retr.Fill(klantdt);
            DataRow[] rows = klantdt.Select();
            voornaamfill.Text = rows[0].ItemArray[1].ToString();
            achternaamfill.Text = rows[0].ItemArray[2].ToString();
            KlantIDfill.Text = rows[0].ItemArray[0].ToString();
            filladres.Text = rows[0].ItemArray[3].ToString();
            postcodefill.Text = rows[0].ItemArray[4].ToString();
            Fillrekeninginformatie(KlantID);
        }
        private void Fillrekeninginformatie(String KlantID)
        {
            Rekeningenbox.Items.Clear();
            string command = "SELECT * FROM OP3.Rekening where RekeningID in (SELECT RekeningID FROM OP3.Pas where KlantID = "+KlantID+");";
            MySqlDataAdapter da = new MySqlDataAdapter(command, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                string rowz = string.Format("{0} : {1}", row.ItemArray[0],row.ItemArray[2]);
                Rekeningenbox.Items.Add(rowz);
            }
            if (Rekeningenbox.Items.Count > 0)
            {
                Rekeningenbox.SelectedIndex = 0;
            }
        }
        private void checkconnection()
        {
            if(connection.Ping())
            {
                connected.ForeColor = Color.Green;
                connected.Text = "Connected";
            }
            else
            {
                connected.ForeColor = Color.Red;
                connected.Text = "Disconnected";
                MessageBox.Show("Kan geen verbinding maken met de database", "Database connectie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        private void Lastnamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}