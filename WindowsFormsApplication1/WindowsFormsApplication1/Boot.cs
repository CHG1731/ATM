using MySql.Data.MySqlClient;
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
        private static MySqlConnection connection;
        private static string connectionString = ConfigurationManager.ConnectionStrings["MyDbContextConnectionStringRemote"].ConnectionString;
        public Boot()
        {
            InitializeComponent();
            makeConnection();
        }

        private void Boot_Load(object sender, EventArgs e)
        {

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
                string rowz = string.Format("{0} : {1}", row.ItemArray[4], row.ItemArray[3]);
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
            Lastnamebox.Enabled = true;
            Firstnamebox.Enabled = true;
            usercbbox.Enabled = true;
            button1.Enabled = true;
            Firstnamebox.Text = "First name";
            Lastnamebox.Text = "Last name";
            usercbbox.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lastnamebox.Enabled = false;
            Firstnamebox.Enabled = false;
            usercbbox.Enabled = false;
            button1.Enabled = false;
        }

        private void Lastnamebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
