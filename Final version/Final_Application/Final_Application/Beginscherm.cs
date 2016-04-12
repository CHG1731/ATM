﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

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
            BlockScreen block = new BlockScreen();
            Hash security = new Hash();
            Executer executer;
            Boolean reset = false;
            Boolean pinCorrect;
            String[] pasInformation;
            int wrongPinCodeAmount;
            //User user;

            try
            {
                while (true) ///Infinite loop so that the program returns here after every cancelation.
                {
                    while (true)
                    {
                        pinCorrect = false;
                        pasInformation = new String[4];
                        wrongPinCodeAmount = 0;
                        reset = false;
                        executer = null;
                        String userName;
                        String rekeningID;
                        String pasID;
                        //user = null;
                        block.popUp();
                        while (true)
                        {
                            String s = arduino.getFirstString();
                            if (s.Contains(",NEWUID"))
                            {
                                pasInformation = s.Split('\n', '\n', '\n');
                                userName = pasInformation[0];
                                rekeningID = pasInformation[1];
                                pasID = pasInformation[2];
                                //Error.show(userName, "Boe");
                                //Error.show(rekeningID, "Boe");
                                //Error.show(pasID, "Boe");
                                break;
                            }
                        }
                        pinInvoer.Show();
                        while (pinCorrect == false)
                        {
                            int insertedDigits = 0;
                            String pincode = "";
                            Boolean confirmed = false;
                            while (confirmed == false) ///Waits for user input until 4 digits have been submitted.
                            {
                                String input = arduino.getString();
                                if (checkInput(input) == true && insertedDigits < 4)
                                {
                                    pinInvoer.printStar();
                                    insertedDigits++;
                                    pincode += input.ElementAt(0);
                                }
                                else if (input.Contains("#KEY"))
                                {
                                    reset = true;
                                    break;
                                }
                                else if (input.Contains("BKEY"))
                                {
                                    pinInvoer.clear();
                                    insertedDigits = 0;
                                    pincode = "";
                                }
                                if (insertedDigits == 4)
                                {
                                    if (input.Contains("AKEY")) { confirmed = true; }
                                }
                            }
                            pinInvoer.clear();
                            if (reset == true) { break; }
                            if (security.checkHash(rekeningID, pincode) == false)
                            {
                                if (++wrongPinCodeAmount == 3)
                                {
                                    //security.blockCard(pasID);
                                    //temp.showBlockScreen();
                                    //private void showBlockScreen()
                                    reset = true;
                                    break;
                                }
                            }
                            else
                            {
                                pinCorrect = true;
                            }
                        }
                        pinInvoer.Hide();
                        if (reset == true)
                        {
                            break;
                        }
                        hoofdmenu.Show();
                        executer = new Executer(rekeningID, userName, arduino);
                        while (true)
                        {
                            int choice = arduino.getChoice();
                            if (choice != 0)
                            {
                                executer.executeChoice(choice);
                                if (executer.getEndOfSession() == true)
                                {
                                    hoofdmenu.Hide();
                                    break;
                                }
                            }

                        }
                    }
                }
            }
            catch (Exception)
            {
                ErrorScreen error = new ErrorScreen();
                error.Show();
            }

            /* DONT EVER DELETE BRACKETS BELOW THIS LINE */
        }

        private Boolean checkInput(String input)
        {
            Boolean result = false;
            for (int i = 0; i < 10; i++)
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
