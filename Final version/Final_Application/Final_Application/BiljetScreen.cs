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
    public partial class BiljetScreen : Form
    {
        public BiljetScreen()
        {
            InitializeComponent();
        }

        public void setLabel1(String tens)
        {
            label1.Text = "A: " + tens + " x 10";
        }

        public void setLabel2(String tens, String twenties)
        {
            label2.Text = "B: " + tens + " x 10,  " + twenties + " x 20";
        }

        public void setLabel3(String tens, String fifties)
        {
            label3.Text = "B: " + tens + " x 10,  " +fifties+"x 50";
        }

        public void setLabel4(String tens, String twenties, String fifties)
        {
            label4.Text = "B: " + tens + " x 10,  " + twenties + " x 20   " + fifties + "x 50";
        }
    }
}
