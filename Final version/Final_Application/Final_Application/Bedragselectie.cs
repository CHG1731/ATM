using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Apllication
{
    public partial class Bedragselectie : Form
    {
        public Bedragselectie()
        {
            InitializeComponent();
            Cursor.Hide();
        }

        public void setDisplay(String value)
        {
            inputDisplay.Text = value + "€";
        }
        public void clearDisplay()
        {
            inputDisplay.Text = "";
        }
        public void showError(int errorNr)
        {
            if (errorNr == 1)
            {
                nope.Visible = true;
            }
            else
            {
                nope.Text = "Bedrag is te hoog.\nBedragen die meer als 1000 euro bedragen kunt u\nAlleen bij een van onze filialen opnemen.";
                nope.Visible = true;
            }
        }

        private void falsepininfo_Click(object sender, EventArgs e)
        {

        }
    }
}
