﻿using System;
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
    public partial class ByeScreen : Form
    {
        public ByeScreen()
        {
            InitializeComponent();
            Cursor.Hide();
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

        private void ByeScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
