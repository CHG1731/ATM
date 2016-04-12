using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Timers;

namespace Final_Apllication
{
    public partial class BlockScreen : Form
    {
        private Timer timer = new Timer();
        private Boolean closeForm = false;

        public BlockScreen()
        {
            InitializeComponent();
        }

        private void BlockScreen_Load(object sender, EventArgs e)
        {
          
        }

        public void popUp()
        {
            this.timer.Enabled = true;
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            while (true)
            {
                if (this.closeForm == true)
                {
                    break;
                }
            }
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.closeForm = true;
        }
    }
}
