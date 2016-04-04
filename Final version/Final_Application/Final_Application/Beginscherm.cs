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
            Executer executer;
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
                        executer = null;
                        //user = null;
                        while (true)
                        {
                            String s = arduino.getString();
                            if (s.Contains(",NEWUID"))
                            {
                                userID = arduino.getUser();
                                break;
                            }
                        }
                        pinInvoer.Show();
                        while (pinCorrect == false)
                        {
                            int insertedDigits = 0;
                            String pin = "";
                            Boolean confirmed = false;
                            while (confirmed == false) ///Waits for user input until 4 digits have been submitted.
                            {
                                String input = arduino.getString();
                                if (checkInput(input) == true && insertedDigits < 4)
                                {
                                    pinInvoer.printStar();
                                    insertedDigits++;
                                    pin += input.ElementAt(0);
                                }
                                else if (input.Contains("$KEY"))
                                {
                                    reset = true;
                                    break;
                                }
                                else if (input.Contains("CKEY"))
                                {
                                    pinInvoer.clear();
                                    insertedDigits = 0;
                                    pin = "";
                                }
                                if(insertedDigits == 4)
                                {
                                    if (input.Contains("AKEY")) { confirmed = true; }
                                }
                            }
                            pinInvoer.clear();
                            executer = new Executer(pin, userID);
                            if (reset == true) { break; }
                            /*if (executer.validatePincode() == false)
                            {
                                if(++wrongPinCodeAmount == 3)
                                {
                                    dataBase.blockCard();
                                    reset = true;
                                    break;
                                }
                            }
                            else
                            {
                                pinCorrect = true;
                            }*/
                            pinCorrect = true;
                        }
                        pinInvoer.Hide();
                        if (reset == true)
                        {
                            break;
                        }
                        hoofdmenu.Show();
                        while(choiceMade == false)
                        {
                            int choice = arduino.getChoice();
                            if (choice != 0)
                            {
                                choiceMade = true;
                                hoofdmenu.Hide();
                                executer.executeChoice(choice);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                Error.show("BROKe", "AS FUCK");
            }

            /* DONT EVER DELETE BRACKETS BELOW THIS LINE */
        }

        private Boolean checkInput(String input)
        {
            Boolean result = false;
            for (int i = 1; i < 10; i++)
            {
                if (input.Contains(i.ToString()))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
