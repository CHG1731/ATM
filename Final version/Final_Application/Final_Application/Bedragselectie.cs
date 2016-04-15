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
            nope.Visible = false;
            InitializeComponent();
        }

        public void setDisplay(String value)
        {
            inputDisplay.Text = value + "€";
        }
        public void clearDisplay()
        {
            inputDisplay.Text = "";
        }
        public void showError()
        {
            nope.Visible = true;
        }

        private void falsepininfo_Click(object sender, EventArgs e)
        {

        }
    }
}
