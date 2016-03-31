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
    public partial class Beginscherm : Form
    {
        public Beginscherm()
        {
            InitializeComponent();
        }

        private void Beginscherm_Load(object sender, EventArgs e)
        {
            PinInvoer pinInvoer = new PinInvoer();
            Hoofdmenu hoofdmenu = new Hoofdmenu();
            ArduinoData arduino = new ArduinoData();
            ErrorScreen errorscr = new ErrorScreen();
            Boolean reset = false;
            Boolean pinCorrect;
            Boolean choiceMade;
            int wrongPinCodeAmount;
            int maxAmount = 4;
            //User user;

            try
            {
                while (true) ///Infinite loop so that the program returns here after every cancelation.
                {
                    while (true)
                    {
                        pinCorrect = false;
                        choiceMade = false;
                        int userID = 0;
                        wrongPinCodeAmount = 0;
                        reset = false;
                        //user = null;
                        while (true)
                        {
                            String s = arduino.getString();
                            if (s.Contains(",NEWUID"))
                            {
                                userID = arduino.getUser();
                                break;
                            }
                            else
                            {
                                Error.show("IN DA LOOP", "IN DA LOOP");
                            }
                        }
                        pinInvoer.Show();
                        Error.show("TEST", "TEST");
                        pinInvoer.Close();
                        Error.show("KILL ME", "KILL ME");
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {
                Error.show("BROKe", "AS FUCK");
            }

            /* DONT EVER DELETE BRACKETS BELOW THIS LINE */
        }
    }
}
