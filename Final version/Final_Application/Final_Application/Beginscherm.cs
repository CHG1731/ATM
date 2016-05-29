using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Application;

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
            bool config = false;
            ArduinoSelect init = new ArduinoSelect();
            if (!config)
            {
                var result = init.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //Make the ports
                    config = true;
                }
                else
                {
                    Application.Exit();
                }
            }
            PinInvoer pinInvoer = new PinInvoer();
            Hoofdmenu hoofdmenu = new Hoofdmenu();
            ArduinoData arduino = new ArduinoData();
            Hash security = new Hash();
            Executer executer;
            Boolean reset = false;
            Boolean pinCorrect;
            String[] pasInformation;
            bool EE = true;
            //User user;

            //try
            //{
            while (true) ///Infinite loop so that the program returns here after every cancelation.
            {
                while (true)
                {
                    pinCorrect = false;
                    pasInformation = new String[4];
                    reset = false;
                    executer = null;
                    String KlantID;
                    String rekeningID;
                    String pasID;
                    HTTPget httpget = new HTTPget();
                    HTTPpost httppost = new HTTPpost();
                    while (true)
                    {
                        String s = arduino.getFirstString();
                        if (s.Contains(",NEWUID"))
                        {
                            pasInformation = s.Split('\n', '\n', '\n');
                            KlantID = pasInformation[2];
                            rekeningID = pasInformation[1];
                            pasID = pasInformation[0];
                            Error.show(httpget.getActiefStand(pasInformation[0]).ToString());
                            break;
                        }
                    }
                    if (!httpget.getActiefStand(pasID))
                    {
                        BlockScreen tmp = new BlockScreen();
                        break;
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
                                pinInvoer.falsepininfo.Visible = false;
                                insertedDigits++;
                                pincode += input.ElementAt(0);
                            }
                            else if (input.Contains("#KEY"))
                            {
                                reset = true;
                                break;
                            }
                            else if (input.Contains("CKEY"))
                            {
                                pinInvoer.clear();
                                insertedDigits = 0;
                                pincode = "";
                            }
                            if (insertedDigits == 4)
                            {
                                if (input.Contains("*")) { confirmed = true; }
                            }
                        }
                        pinInvoer.clear();
                        if (reset == true) { break; }
                        if (pincode == "1337" && EE) //Added easter egg
                        {
                            pinInvoer.pictureBox2.Visible = true;
                            pinInvoer.Refresh();
                            System.Threading.Thread.Sleep(8000);
                            reset = true;
                            pinInvoer.pictureBox2.Visible = false;
                            break;
                        }
                        /*
                        if (security.checkHash(rekeningID, pincode) == false)
                        {
                            pinInvoer.falsepininfo.Visible = true;
                            HTTPpost tmp = new HTTPpost();
                            tmp.Incrementfalsepin(pasID);
                            if(!httpget.getActiefStand(pasID))
                            {
                                pinInvoer.Close();
                            }
                        }
                        */
                        else
                        {
                            httppost.resetfalsepin(pasID);
                            pinCorrect = true;
                        }
                    }
                    pinInvoer.Hide();
                    if (reset == true)
                    {
                        break;
                    }
                    hoofdmenu.Show();
                    executer = new Executer(rekeningID, KlantID, arduino, pasID);
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
        /*
        catch (Exception) //Made the application safe, as soon as an exception is found, Close everything and show the out of order Form, main thread isnt even running anymore
        {
            ErrorScreen error = new ErrorScreen();
            List<Form> openForms = new List<Form>();
            foreach (Form f in Application.OpenForms)
                openForms.Add(f);
            foreach (Form f in openForms)
            {
                if (f.Name != "ErrorScreen")
                    f.Close();
            }
            while (true)
            { } //Loop forever :)
        }
    }
    */
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
            if (input.Length > 4)
            {
                result = false;
            }
            return result;
        }
    }
}
