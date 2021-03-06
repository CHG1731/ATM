﻿using System;
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
            String substring = "";
            if(!(tens.Equals("0")))
            {
                substring = tens + " x 10 ";
            }
            label2.Text = "B: "+ substring + twenties + " x 20";
        }

        public void setLabel3(String tens, String fifties)
        {
            String substring = "";
            if (!(tens.Equals("0")))
            {
                substring = tens + " x 10 ";
            }
            label3.Text = "C: " + substring +fifties+"x 50";
        }

        public void setLabel4(String tens, String twenties, String fifties)
        {
            String substring1 = "";
            String substring2 = "";
            if (!(tens.Equals("0")))
            {
                substring1 = tens + " x 10 ";
            }
            if (!(twenties.Equals("0")))
            {
                substring2 = twenties + " x 20 ";
            }
            label4.Text = "D: " + substring1 + substring2 + fifties + "x 50";
        }

        public void showInsufficient()
        {
            label3.Text = "Bedrag kan niet gepint worden,";
            label4.Text = "er zijn onvoldoende biljetten op vooraad.";
            this.Show();
            this.Refresh();
            sleepnow().Wait();
            this.Close();
        }

        async Task sleepnow()
        {
            //its all ogre now
            System.Threading.Thread.Sleep(5000);
        }
    }
}
