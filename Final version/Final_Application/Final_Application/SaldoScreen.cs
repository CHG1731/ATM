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
    public partial class SaldoScreen : Form
    {
        public SaldoScreen(int saldo)
        {
            InitializeComponent();
            Cursor.Hide();
            
            saldoLabel.Text = (saldo/100+".00€");
            this.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void inputDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaldoScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
