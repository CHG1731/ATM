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
    public partial class StockScreen : Form
    {
        Stock stock;
        Boolean complete = false;

        public StockScreen(Stock s)
        {
            InitializeComponent();
            this.Refresh();
            this.stock = s;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            int tens = Int32.Parse(tensDisplay.Text);
            int twenties = Int32.Parse(twentiesDisplay.Text);
            int fifties = Int32.Parse(fiftiesDisplay.Text);
            stock.setBiljets(tens, twenties, fifties);
            complete = true;
            this.Close();
        }

        public Boolean getComplete()
        {
            return this.complete;
        }

        private void StockScreen_Load(object sender, EventArgs e)
        {
            Cursor.Show();
        }
    }
}
