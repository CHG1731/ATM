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
    public partial class SaldoScreen : Form
    {
        public SaldoScreen(double saldo)
        {
            InitializeComponent();
            inputDisplay.AppendText(saldo.ToString());
        }
    }
}
